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
    public partial class FormVrstaArtikla : Form
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

        public FormVrstaArtikla()
        {
            InitializeComponent();
        }

        private void FormVrstaArtikla_Load(object sender, EventArgs e)
        {
            TestConnection();
            DohvatiVrsteArtikla();
        }

        private DataTable dt;

        private void DohvatiVrsteArtikla()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                string query = @"select * from vrsta_artikla;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvVrstaArtikla.DataSource = null;
                dgvVrstaArtikla.DataSource = dt;
            }
        }

        private int rowIndex = -1;

        private void dgvVrstaArtikla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
                txtID.Text = dgvVrstaArtikla.Rows[e.RowIndex].Cells["id_vrsta_artikla"].Value.ToString();
                txtNaziv.Text = dgvVrstaArtikla.Rows[e.RowIndex].Cells["naziv"].Value.ToString();
                txtOpis.Text = dgvVrstaArtikla.Rows[e.RowIndex].Cells["opis"].Value.ToString();
                
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
                    txtNaziv.Select();


                    string upit = "select * from public.unos_vrste_artikla (CAST('" + txtNaziv.Text + "'AS CHARACTER VARYING) ,CAST('" + txtOpis.Text + "' AS CHARACTER VARYING)); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Nova vrsta artikla je uspješno dodana!");

                    txtID.Text = txtNaziv.Text = txtOpis.Text = null;
                    DohvatiVrsteArtikla();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Molim popunite sva polja! \n ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            txtID.Text = txtNaziv.Text = txtOpis.Text = null;
            btnSpremi.Enabled = true;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {

            using (NpgsqlConnection con = GetConnection())
            {
                if (rowIndex < 0)
                {
                    MessageBox.Show("Molim odaberite vrstu artikla koju želite urediti");
                }

                else
                {

                    rowIndex = -1;
                    txtNaziv.Select();
                    string upit = "select * from public.uredi_vrstu_artikla('" + int.Parse(txtID.Text) + " ', CAST('" + txtNaziv.Text + "'AS CHARACTER VARYING) ,CAST('" + txtOpis.Text + "' AS CHARACTER VARYING)); ";

                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Vrsta artikla je uspješno uređena!");

                    txtID.Text = txtNaziv.Text = txtOpis.Text = null;
                    DohvatiVrsteArtikla();
                
                    btnSpremi.Enabled = true;
                }
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Molim odaberite vrstu artikla koju želite obrisati!");
            }

            else
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    rowIndex = -1;

                    string upit = "select * from public.izbrisi_vrstu_artikla('" + int.Parse(txtID.Text) + " ');";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Vrsta artikla je uspješno izbrisana!");

                    txtID.Text = txtNaziv.Text = txtOpis.Text = null;
                    DohvatiVrsteArtikla();
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
                     " or [opis] like '%" + txtPretrazi.Text + "%' ";
                dgvVrstaArtikla.DataSource = dv;
            }

            else
            {
                MessageBox.Show("Unesite pojam za pretraživanje!");
            }
        }
    }
}
