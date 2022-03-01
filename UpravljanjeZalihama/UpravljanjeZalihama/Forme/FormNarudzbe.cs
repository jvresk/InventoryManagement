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
    public partial class FormNarudzbe : Form
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

        public FormNarudzbe()
        {
            InitializeComponent();
        }

        private DataTable dt;

        private void FormNarudzbe_Load(object sender, EventArgs e)
        {
            DohvatiNarudzbe();
        }

        private void DohvatiNarudzbe()
        {
            if (rbUTijeku.Checked == true)
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    string query = @"select a.id_artikl, a.naziv, r.id_radnik, r.ime as ime_radnika, r.prezime as prezime_radnika, d.id_dobavljac, d.ime as dobavljac, p.datum, sp.kolicina, p.id_dokument
                                    from artikl a, radnik r, dobavljac d, dokument p, stavke_dokument sp
                                    where a.id_artikl=sp.id_artikl and sp.id_dokument=p.id_dokument and p.id_radnik=r.id_radnik and p.id_dobavljac=d.id_dobavljac and p.vrsta = 'true' and zaprimljeno='false';";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgvNarudzbe.DataSource = null;
                    dgvNarudzbe.DataSource = dt;
                }
            }else if(rbZaprimljene.Checked == true)
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    string query = @"select a.id_artikl, a.naziv, r.id_radnik, r.ime as ime_radnika, r.prezime as prezime_radnika, d.id_dobavljac, d.ime as dobavljac, p.datum, sp.kolicina, p.id_dokument
                                    from artikl a, radnik r, dobavljac d, dokument p, stavke_dokument sp
                                    where a.id_artikl=sp.id_artikl and sp.id_dokument=p.id_dokument and p.id_radnik=r.id_radnik and p.id_dobavljac=d.id_dobavljac and p.vrsta = 'true' and zaprimljeno='true';";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgvNarudzbe.DataSource = null;
                    dgvNarudzbe.DataSource = dt;
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
                    " or [dobavljac] like '%" + txtPretrazi.Text + "%' " +
                    " or [ime_radnika] like '%" + txtPretrazi.Text + "%' " +
                    " or [prezime_radnika] like '%" + txtPretrazi.Text + "%' ";
                dgvNarudzbe.DataSource = dv;
            }

            else
            {
                MessageBox.Show("Unesite pojam za pretraživanje!");
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    
                    txtDatum.Text = DateTime.Now.ToString();


                    string upit = "select * from public.unos_dokumenta (CAST('" + txtDatum.Text + "' AS TIMESTAMP WITHOUT TIME ZONE), '" + int.Parse(txtIDRadnik.Text) + "', '" + int.Parse(txtIDDObavljac.Text) + "', 'false', NULL); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();
                    
                   
                    txtIDDokument.Text = null;

                }


            }
            catch (Exception er)
            {

                MessageBox.Show("Greška! \n " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                using (NpgsqlConnection con = GetConnection())
                {

                    DohvatiZadnjiDokument();
                    con.Open();

                    string upit = "select * from public.unos_stavke_dokumenta ('" + txtID.Text + "', '" + txtIDDokument.Text + "', '" + txtKolicina.Text + "'); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);

                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Narudzba je uspješno zaprimljena!");
                    

                    con.Close();

                    

                }
            }
            catch (Exception er)
            {

                MessageBox.Show("Greška 2! \n " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            NarudzbaZaprimljena();
        }

        private int rowIndex = -1;

        private void dgvNarudzbe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;

                txtDatum.Text = DateTime.Now.ToString();
                
                txtID.Text = dgvNarudzbe.Rows[e.RowIndex].Cells["id_artikl"].Value.ToString();
                txtIDRadnik.Text = dgvNarudzbe.Rows[e.RowIndex].Cells["id_radnik"].Value.ToString();
                txtIDDObavljac.Text = dgvNarudzbe.Rows[e.RowIndex].Cells["id_dobavljac"].Value.ToString();
                txtKolicina.Text = dgvNarudzbe.Rows[e.RowIndex].Cells["kolicina"].Value.ToString();
                txtIDDokument.Text = dgvNarudzbe.Rows[e.RowIndex].Cells["id_dokument"].Value.ToString();
                txtbrojdok.Text= dgvNarudzbe.Rows[e.RowIndex].Cells["id_dokument"].Value.ToString();




            }
        }

        private void DohvatiZadnjiDokument()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                NpgsqlCommand sc = new NpgsqlCommand("select id_dokument from dokument order by id_dokument desc limit 1; ", con);

                NpgsqlDataReader reader;

                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("id_dokument", typeof(string));
                dt.Load(reader);
                con.Close();

                txtIDDokument.Text = dt.Rows[0][0].ToString();
            }
        }

        private void NarudzbaZaprimljena()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                NpgsqlCommand sc = new NpgsqlCommand("update dokument set zaprimljeno = 'true' where id_dokument= '"+ txtbrojdok.Text + "'", con);

                NpgsqlDataReader reader;

                reader = sc.ExecuteReader();
               
                con.Close();

               
            }
        }

        private void rbUTijeku_CheckedChanged(object sender, EventArgs e)
        {
            DohvatiNarudzbe();
        }

        private void rbZaprimljene_CheckedChanged(object sender, EventArgs e)
        {
            DohvatiNarudzbe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form primke = new FormPrimke();
            primke.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form narudzbe = new FormRucnaNarudzba();
            narudzbe.Show();
        }
    }
}
