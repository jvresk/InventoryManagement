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
    public partial class FormRadnici : Form
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

        public FormRadnici()
        {
            InitializeComponent();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            txtID.Text = txtIme.Text = txtPrezime.Text = txtEmail.Text = txtAdresa.Text = txtTelefon.Text = null;
            btnSpremi.Enabled = true;
        }

        private void FormRadnici_Load(object sender, EventArgs e)
        {
            TestConnection();
            DohvatiRadnike();
        }

        private DataTable dt;

        private void DohvatiRadnike()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                string query = @"select * from radnik;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvRadnici.DataSource = null;
                dgvRadnici.DataSource = dt;
            }
        }

        private int rowIndex = -1;

        private void dgvRadnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtID.Text = dgvRadnici.Rows[e.RowIndex].Cells["id_radnik"].Value.ToString();
                txtIme.Text = dgvRadnici.Rows[e.RowIndex].Cells["ime"].Value.ToString();
                txtPrezime.Text = dgvRadnici.Rows[e.RowIndex].Cells["prezime"].Value.ToString();
                txtEmail.Text = dgvRadnici.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtTelefon.Text = dgvRadnici.Rows[e.RowIndex].Cells["telefon"].Value.ToString();
                txtAdresa.Text = dgvRadnici.Rows[e.RowIndex].Cells["adresa"].Value.ToString();

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


                    string upit = "select * from public.unos_radnika (CAST('" + txtIme.Text + "'AS CHARACTER VARYING) ,CAST('" + txtPrezime.Text + "' AS CHARACTER VARYING), CAST('" + txtEmail.Text + "'AS CHARACTER VARYING), CAST('" + txtTelefon.Text + "'AS CHARACTER VARYING), CAST('" + txtAdresa.Text + "' AS CHARACTER VARYING)); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Novi radnik je uspješno dodan!");

                    txtID.Text = txtIme.Text = txtPrezime.Text = txtEmail.Text = txtAdresa.Text = txtTelefon.Text = null;
                    DohvatiRadnike();
                }
            }
            catch (Exception er)
            {

                MessageBox.Show("Nisu sva polja popunjena, molim: \n " + er.Message.Remove(0,7), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
           
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Molim odaberite radnika kojeg želite obrisati!");
            }

            else
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    rowIndex = -1;

                    string upit = "select * from public.izbrisi_radnika('" + int.Parse(txtID.Text) + " ');";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Radnik je uspješno izbrisan!");

                    txtID.Text = txtIme.Text = txtPrezime.Text = txtEmail.Text = txtAdresa.Text = txtTelefon.Text = null;
                    DohvatiRadnike();
                    btnSpremi.Enabled = true;
                }
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = GetConnection())
            {
                if (rowIndex < 0)
                {
                    MessageBox.Show("Molim odaberite radnika kojeg želite urediti");
                }

                else
                {

                    rowIndex = -1;
                    txtIme.Select();
                    string upit = "select * from public.uredi_radnika('" + int.Parse(txtID.Text) + " ', CAST('" + txtIme.Text + "'AS CHARACTER VARYING) ,CAST('" + txtPrezime.Text + "' AS CHARACTER VARYING), CAST( '" + txtEmail.Text + "' AS CHARACTER VARYING),  CAST('" + txtTelefon.Text + "'AS CHARACTER VARYING), CAST( '" + txtAdresa.Text + "' AS CHARACTER VARYING)); ";

                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Dobavljač je uspješno uređen!");

                    txtID.Text = txtIme.Text = txtPrezime.Text = txtEmail.Text = txtAdresa.Text = txtTelefon.Text = null;
                    DohvatiRadnike();
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
                     " or [prezime] like '%" + txtPretrazi.Text + "%' " +
                     " or [email] LIKE '" + txtPretrazi.Text + "%'" +
                    " or [telefon] like '%" + txtPretrazi.Text + "%' " +
                    " or [adresa] like '%" + txtPretrazi.Text + "%' ";
                dgvRadnici.DataSource = dv;
            }

            else
            {
                MessageBox.Show("Unesite pojam za pretraživanje!");
            }
        }
    }
}
