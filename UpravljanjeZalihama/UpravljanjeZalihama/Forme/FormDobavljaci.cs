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
    public partial class FormDobavljaci : Form
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


        public FormDobavljaci()
        {
            InitializeComponent();
        }

        

        private void FormDobavljaci_Load(object sender, EventArgs e)
        {
            TestConnection();
            DohvatiDobavljace();
        }

        private DataTable dt;

        private void DohvatiDobavljace()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                string query = @"select * from dobavljac;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvDobavljaci.DataSource = null;
                dgvDobavljaci.DataSource = dt;
            }
        }

        private int rowIndex = -1;

        private void dgvArtikli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtID.Text= dgvDobavljaci.Rows[e.RowIndex].Cells["id_dobavljac"].Value.ToString();
                txtIme.Text = dgvDobavljaci.Rows[e.RowIndex].Cells["ime"].Value.ToString();
                txtKontakt.Text = dgvDobavljaci.Rows[e.RowIndex].Cells["kontakt"].Value.ToString();
                txtAdresa.Text = dgvDobavljaci.Rows[e.RowIndex].Cells["adresa"].Value.ToString();
                txtEmail.Text = dgvDobavljaci.Rows[e.RowIndex].Cells["email"].Value.ToString();
               
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
                    txtIme.Select();


                    string upit = "select * from public.unos_dobavljaca (CAST('" + txtIme.Text + "'AS CHARACTER VARYING) ,CAST('" + txtKontakt.Text + "' AS CHARACTER VARYING), CAST('" + txtEmail.Text + "'AS CHARACTER VARYING), CAST('" + txtAdresa.Text + "'AS CHARACTER VARYING)); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Novi dobavljač je uspješno dodan!");

                    txtID.Text = txtIme.Text = txtKontakt.Text = txtEmail.Text = txtAdresa.Text = null;
                    DohvatiDobavljace();
                }
            }


            catch (Exception er)
            {

                MessageBox.Show("Molim popunite sva polja za unos! " + er.Message.Remove(0, 7), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
               
            
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            txtID.Text = txtIme.Text = txtKontakt.Text = txtEmail.Text = txtAdresa.Text = null;
            btnSpremi.Enabled = true;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = GetConnection())
            {
                if (rowIndex < 0)
                {
                    MessageBox.Show("Molim odaberite dobavljača kojeg želite urediti");
                }

                else
                {

                    rowIndex = -1;
                    txtIme.Select();
                    string upit = "select * from public.uredi_dobavljaca('" + int.Parse(txtID.Text) + " ', CAST('" + txtIme.Text + "'AS CHARACTER VARYING) ,CAST('" + txtKontakt.Text + "' AS CHARACTER VARYING), CAST( '" + txtEmail.Text + "' AS CHARACTER VARYING), CAST( '" + txtAdresa.Text + "' AS CHARACTER VARYING)); ";

                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Dobavljač je uspješno uređen!");

                    txtID.Text = txtIme.Text = txtKontakt.Text = txtEmail.Text = txtAdresa.Text = null;
                    DohvatiDobavljace();
                    btnSpremi.Enabled = true;
                }
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Molim odaberite dobavljača kojeg želite obrisati!");
            }

            else
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    rowIndex = -1;

                    string upit = "select * from public.izbrisi_dobavljaca('" + int.Parse(txtID.Text) + " ');";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Dobavljač je uspješno izbrisan!");

                    txtID.Text = txtIme.Text = txtKontakt.Text = txtEmail.Text = txtAdresa.Text = null;
                    DohvatiDobavljace();
                    btnSpremi.Enabled = true;
                }
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;

            if (txtPretrazi.Text != "")
            {
                dv.RowFilter = "ime LIKE '" + txtPretrazi.Text + "%'" +
                     " or [kontakt] like '%" + txtPretrazi.Text + "%' " +
                    " or [email] like '%" + txtPretrazi.Text + "%' " +
                    " or [adresa] like '%" + txtPretrazi.Text + "%' ";
                dgvDobavljaci.DataSource = dv;
            }

            else
            {
                MessageBox.Show("Unesite pojam za pretraživanje!");
            }
        }
    }
}
