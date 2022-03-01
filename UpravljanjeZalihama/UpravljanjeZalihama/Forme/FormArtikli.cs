using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace UpravljanjeZalihama.Forme
{
    public partial class FormArtikli : Form
    {

        //konekcija
        private static void TestConnection()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
            }
        }

        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=pgadmin4;Database=zaliheDB;");
        }


        public FormArtikli()
        {
            InitializeComponent();
        }

        private void FormArtikli_Load(object sender, EventArgs e)
        {
            TestConnection();
            DohvatiArtikle();
            PopuniVrsteArtikla();
            PopuniDobavljace();
        }

        private DataTable dt;

        private void PopuniVrsteArtikla()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                NpgsqlCommand sc = new NpgsqlCommand("select id_vrsta_artikla, naziv from vrsta_artikla", con);
                NpgsqlDataReader reader;

                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("id_vrsta_artikla", typeof(string));
                dt.Columns.Add("naziv", typeof(string));
                dt.Load(reader);

                cmbVrstaArtikla.ValueMember = "id_vrsta_artikla";
                cmbVrstaArtikla.DisplayMember = "naziv";
                cmbVrstaArtikla.DataSource = dt;

                con.Close();

                txtID.Text = txtNaziv.Text = txtOpis.Text = txtDonjaGranica.Text = txtGornjaGranica.Text = txtNabavnaCijena.Text = txtProdajnaCijena.Text = cmbVrstaArtikla.Text = null;

            }
        }

        private void PopuniDobavljace()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                NpgsqlCommand sc = new NpgsqlCommand("select id_dobavljac, ime from dobavljac", con);
                NpgsqlDataReader reader;

                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("id_dobavljac", typeof(string));
                dt.Columns.Add("ime", typeof(string));
                dt.Load(reader);

                cmbDobavljac.ValueMember = "id_dobavljac";
                cmbDobavljac.DisplayMember = "ime";
                cmbDobavljac.DataSource = dt;

                con.Close();

                cmbDobavljac.Text = txtID.Text = txtNaziv.Text = txtOpis.Text = txtDonjaGranica.Text = txtGornjaGranica.Text = txtNabavnaCijena.Text = txtProdajnaCijena.Text = cmbVrstaArtikla.Text = null;

            }
        }



        private void DohvatiArtikle()
        {

            using (NpgsqlConnection con = GetConnection())
            {
                string query = @"select a.id_artikl, a.naziv, a.opis, a.nabavna_cijena, a.prodajna_cijena, 
                                a.donja_granica_kolicine, a.gornja_granica_kolicine, v.naziv as vrsta_artikla, d.ime as dobavljac from artikl a, vrsta_artikla v, dobavljac d
                                where a.id_vrsta_artikla=v.id_vrsta_artikla and a.id_dobavljac=d.id_dobavljac;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = dt;

            }

        }

        private int rowIndex = -1;
        //private NpgsqlConnection con;



        private void btnDodajVrstuArtikla_Click(object sender, EventArgs e)
        {
            Form vrstaArtikla = new FormVrstaArtikla();
            vrstaArtikla.Show();
        }

        private void btnPopusti_Click(object sender, EventArgs e)
        {
            Form popusti = new FormPopusti();
            popusti.Show();
        }

        private void dgvArtikli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtID.Text = dgvArtikli.Rows[e.RowIndex].Cells["id_artikl"].Value.ToString();
                txtNaziv.Text = dgvArtikli.Rows[e.RowIndex].Cells["naziv"].Value.ToString();
                txtOpis.Text = dgvArtikli.Rows[e.RowIndex].Cells["opis"].Value.ToString();
                txtDonjaGranica.Text = dgvArtikli.Rows[e.RowIndex].Cells["donja_granica_kolicine"].Value.ToString();
                txtGornjaGranica.Text = dgvArtikli.Rows[e.RowIndex].Cells["gornja_granica_kolicine"].Value.ToString();
                txtNabavnaCijena.Text = dgvArtikli.Rows[e.RowIndex].Cells["nabavna_cijena"].Value.ToString();
                txtProdajnaCijena.Text = dgvArtikli.Rows[e.RowIndex].Cells["prodajna_cijena"].Value.ToString();
                cmbVrstaArtikla.Text = dgvArtikli.Rows[e.RowIndex].Cells["vrsta_artikla"].Value.ToString();
                cmbDobavljac.Text = dgvArtikli.Rows[e.RowIndex].Cells["dobavljac"].Value.ToString();

                btnSpremi.Enabled = false;


                using (NpgsqlConnection con = GetConnection())
                {
                    con.Open();

                    NpgsqlCommand sc = new NpgsqlCommand("select kolicina_na_skladistu from stanje_na_skladistu where id_artikl = '" + int.Parse(txtID.Text.ToString()) + " '; ", con);

                    NpgsqlDataReader reader;

                    reader = sc.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("kolicina_na_skladistu", typeof(string));
                    dt.Load(reader);

                    
                    txtZalihe.Text = dt.Rows[0][0].ToString();

                    con.Close();

                }

            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    rowIndex = -1;
                    txtNaziv.Select();

                    int dobavljac = Convert.ToInt32(cmbDobavljac.SelectedValue.ToString());

                    int vrsta = Convert.ToInt32(cmbVrstaArtikla.SelectedValue.ToString());

                    string upit = "select * from public.unos_artikla (CAST('" + txtNaziv.Text + "'AS CHARACTER VARYING) ,CAST('" + txtOpis.Text + "' AS CHARACTER VARYING), CAST( '" + txtNabavnaCijena.Text + "' AS MONEY), CAST( '" + txtProdajnaCijena.Text + "' AS MONEY), '" + int.Parse(txtDonjaGranica.Text) + " ', '" + int.Parse(txtGornjaGranica.Text) + " ', '" + vrsta + "', '" + dobavljac + "'); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Novi artikl je uspješno dodan!");

                    txtID.Text = txtNaziv.Text = txtOpis.Text = txtDonjaGranica.Text = txtGornjaGranica.Text = txtNabavnaCijena.Text = txtProdajnaCijena.Text = cmbVrstaArtikla.Text = null;
                    DohvatiArtikle();
                }
            }

            catch (Exception er)
            {
                MessageBox.Show("Molim popunite sva polja! \n " +er.Message,  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            txtID.Text = txtNaziv.Text = txtOpis.Text = txtDonjaGranica.Text = txtGornjaGranica.Text = txtNabavnaCijena.Text = txtProdajnaCijena.Text = cmbVrstaArtikla.Text = null;
            btnSpremi.Enabled = true;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = GetConnection())
            {
                if (rowIndex < 0)
                {
                    MessageBox.Show("Molim odaberite artikl koji želite ažurirati");
                }

                else
                {
                    int vrsta = Convert.ToInt32(cmbVrstaArtikla.SelectedValue.ToString());
                    int dobavljac = Convert.ToInt32(cmbDobavljac.SelectedValue.ToString());

                    rowIndex = -1;
                    txtNaziv.Select();
                    string upit = "select * from public.uredi_artikl('" + int.Parse(txtID.Text) + " ', CAST('" + txtNaziv.Text + "'AS CHARACTER VARYING) ,CAST('" + txtOpis.Text + "' AS CHARACTER VARYING), CAST( '" + txtNabavnaCijena.Text + "' AS MONEY), CAST( '" + txtProdajnaCijena.Text + "' AS MONEY), '" + int.Parse(txtDonjaGranica.Text) + " ', '" + int.Parse(txtGornjaGranica.Text) + " ', '" + vrsta + "', '" + dobavljac + "'); ";

                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Artikl je uspješno uređen!");

                    txtID.Text = txtNaziv.Text = txtOpis.Text = txtDonjaGranica.Text = txtGornjaGranica.Text = txtNabavnaCijena.Text = txtProdajnaCijena.Text = cmbVrstaArtikla.Text = null;
                    DohvatiArtikle();
                    btnSpremi.Enabled = true;
                }
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Molim odaberite artikl koji želite obrisati");
            }

            else
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    rowIndex = -1;

                    string upit = "select * from public.izbrisi_artikl('" + int.Parse(txtID.Text) + " ');";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Artikl je uspješno izbrisan!");

                    txtID.Text = txtNaziv.Text = txtOpis.Text = txtDonjaGranica.Text = txtGornjaGranica.Text = txtNabavnaCijena.Text = txtProdajnaCijena.Text = cmbVrstaArtikla.Text = null;
                    DohvatiArtikle();
                    btnSpremi.Enabled = true;
                }
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;

            if (txtPretrazi.Text != "")
            {
                dv.RowFilter = "naziv LIKE '" + txtPretrazi.Text + "%'" +
                     " or [naziv] like '%" + txtPretrazi.Text + "%' " +
                    " or [opis] like '%" + txtPretrazi.Text + "%' " +
                    " or [vrsta_artikla] like '%" + txtPretrazi.Text + "%' ";
                dgvArtikli.DataSource = dv;
            }

            else
            {
                MessageBox.Show("Unesite pojam za pretraživanje!");
            }


        }
    }
}
