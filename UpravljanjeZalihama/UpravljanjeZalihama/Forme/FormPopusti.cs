using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace UpravljanjeZalihama.Forme
{
    public partial class FormPopusti : Form
    {

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


        public FormPopusti()
        {
            InitializeComponent();
        }

        private void FormPopusti_Load(object sender, EventArgs e)
        {
            TestConnection();
            DohvatiPopuste();
            PopuniArtikle();
        }

        private void PopuniArtikle()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                NpgsqlCommand sc = new NpgsqlCommand("select id_artikl, naziv from artikl", con);
                NpgsqlDataReader reader;

                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("id_artikl", typeof(string));
                dt.Columns.Add("naziv", typeof(string));
                dt.Load(reader);

                cmbArtikl.ValueMember = "id_artikl";
                cmbArtikl.DisplayMember = "naziv";
                cmbArtikl.DataSource = dt;

                con.Close();

               cmbArtikl.Text = txtAkcijskaCijena.Text = null;

            }
        }

        private void DohvatiPopuste()
        {
            txtDanasnji.Text = DateTime.Now.ToString();

            if (rbSvi.Checked == true) { 
                using (NpgsqlConnection con = GetConnection())
                {
                    string query = @"select p.id_popust,p.datum_pocetka, p.datum_zavrsetka, p.akcijska_cijena, a.naziv from artikl a, popust p
                                    where a.id_artikl=p.id_artikl;";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgvPopusti.DataSource = null;
                    dgvPopusti.DataSource = dt;
                }
            }

            else if (rbProsli.Checked == true)
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    string query = @"select p.id_popust,p.datum_pocetka, p.datum_zavrsetka, p.akcijska_cijena, a.naziv from artikl a, popust p
                                    where a.id_artikl=p.id_artikl and p.datum_zavrsetka < '" + txtDanasnji.Text + "';";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgvPopusti.DataSource = null;
                    dgvPopusti.DataSource = dt;
                }

            }

            else if (rbAktualni.Checked == true)
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    string query = @"select p.id_popust,p.datum_pocetka, p.datum_zavrsetka, p.akcijska_cijena, a.naziv from artikl a, popust p
                                    where a.id_artikl=p.id_artikl and  p.datum_pocetka <= '" + txtDanasnji.Text + "' and p.datum_zavrsetka > '" + txtDanasnji.Text + "';";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgvPopusti.DataSource = null;
                    dgvPopusti.DataSource = dt;
                }

            }
        }

        private DataTable dt;
        private int rowIndex = -1;

        private void dgvPopusti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtID.Text = dgvPopusti.Rows[e.RowIndex].Cells["id_popust"].Value.ToString();
                dtpPocetak.Text = dgvPopusti.Rows[e.RowIndex].Cells["datum_pocetka"].Value.ToString();
                dtpZavrsetak.Text = dgvPopusti.Rows[e.RowIndex].Cells["datum_zavrsetka"].Value.ToString();
                txtAkcijskaCijena.Text = dgvPopusti.Rows[e.RowIndex].Cells["akcijska_cijena"].Value.ToString();
                cmbArtikl.Text = dgvPopusti.Rows[e.RowIndex].Cells["naziv"].Value.ToString();

                btnSpremi.Enabled = false;

            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    rowIndex = -1;


                    int artikl = Convert.ToInt32(cmbArtikl.SelectedValue.ToString());

                    string upit = "select * from public.unos_popusta (CAST('" + dtpPocetak.Text + "'AS TIMESTAMP WITHOUT TIME ZONE) ,CAST('" + dtpZavrsetak.Text + "' AS TIMESTAMP WITHOUT TIME ZONE), CAST( '" + txtAkcijskaCijena.Text + "' AS MONEY), '" + artikl + "'); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Novi popust je uspješno dodan!");

                    cmbArtikl.Text = txtAkcijskaCijena.Text = null;
                    DohvatiPopuste();
                }
            }
            catch (Exception er)
            {

                MessageBox.Show("Molim popunite sva polja! \n " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = GetConnection())
            {
                if (rowIndex < 0)
                {
                    MessageBox.Show("Molim odaberite popust koji želite ažurirati");
                }

                else
                {
                    int artikl = Convert.ToInt32(cmbArtikl.SelectedValue.ToString());

                    rowIndex = -1;
                    string upit = "select * from public.uredi_popust('" + int.Parse(txtID.Text) + " ', CAST('" + dtpPocetak.Text + "'AS TIMESTAMP WITHOUT TIME ZONE) ,CAST('" + dtpZavrsetak.Text + "' AS TIMESTAMP WITHOUT TIME ZONE), CAST( '" + txtAkcijskaCijena.Text + "' AS MONEY), '" + artikl + "'); ";

                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Popust je uspješno uređen!");

                    cmbArtikl.Text = txtAkcijskaCijena.Text = null;
                    DohvatiPopuste();
                    btnSpremi.Enabled = true;
                }
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            cmbArtikl.Text = txtAkcijskaCijena.Text = null;
            DohvatiPopuste();
            btnSpremi.Enabled = true;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Molim odaberite popust koji želite obrisati");
            }

            else
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    rowIndex = -1;

                    string upit = "select * from public.izbrisi_popust('" + int.Parse(txtID.Text) + " ');";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Popust je uspješno izbrisan!");

                    cmbArtikl.Text = txtAkcijskaCijena.Text = null;
                    DohvatiPopuste();
                    btnSpremi.Enabled = true;
                }
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;

            if (txtPretrazi.Text != "")
            {
                dv.RowFilter = "naziv LIKE '" + txtPretrazi.Text + "%'";
                dgvPopusti.DataSource = dv;
            }

            else
            {
                MessageBox.Show("Unesite pojam za pretraživanje!");
            }
        }

        private void rbSvi_CheckedChanged(object sender, EventArgs e)
        {
            DohvatiPopuste();
        }

        private void rbProsli_CheckedChanged(object sender, EventArgs e)
        {
            DohvatiPopuste();
        }

        private void rbAktualni_CheckedChanged(object sender, EventArgs e)
        {
            DohvatiPopuste();
        }
    }
}
