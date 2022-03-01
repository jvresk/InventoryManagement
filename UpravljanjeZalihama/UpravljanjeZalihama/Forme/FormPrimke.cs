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
    public partial class FormPrimke : Form
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


        public FormPrimke()
        {
            InitializeComponent();
        }

        private DataTable dt;

        private void FormPrimke_Load(object sender, EventArgs e)
        {
            TestConnection();
            PopuniArtikle();
            PopuniRadnike();
            PopuniDobavljace();
            DohvatiPrimke();
            DohvatiZadnjuPrimku();

            
        }

        private void DohvatiZadnjuPrimku()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                NpgsqlCommand sc = new NpgsqlCommand("select p.id_dokument, p.id_radnik, p.id_dobavljac, p.datum,CONCAT(r.ime, ' ', r.prezime) as puno_ime, d.ime as dobavljac from radnik r, dobavljac d, dokument p " +
                    "where p.id_radnik = r.id_radnik and p.id_dobavljac = d.id_dobavljac and p.vrsta = 'false'" +
                    "order by p.id_dokument desc limit 1; ", con);

                NpgsqlDataReader reader;

                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("id_dokument", typeof(string));
                dt.Columns.Add("datum", typeof(string));
                dt.Columns.Add("id_radnik", typeof(string));
                dt.Columns.Add("id_dobavljac", typeof(string));
                dt.Columns.Add("puno_ime", typeof(string));
                dt.Columns.Add("dobavljac", typeof(string));
                dt.Load(reader);
                con.Close();

                cmbRadnik.Text = dt.Rows[0][4].ToString();
                cmbDobavljac.Text = dt.Rows[0][5].ToString();
                txtDatum.Text = dt.Rows[0][1].ToString();
                txtIDprimka.Text = dt.Rows[0][0].ToString();
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

                txtID.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = cmbDobavljac.Text= null;

            }
        }

        private void DohvatiPrimke()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                string query = @"select a.id_artikl, a.naziv, r.ime as ime_radnika, r.prezime as prezime_radnika, d.ime as dobavljac, p.datum, sp.kolicina, p.id_dokument
                                    from artikl a, radnik r, dobavljac d, dokument p, stavke_dokument sp
                                    where a.id_artikl=sp.id_artikl and sp.id_dokument=p.id_dokument and p.id_radnik=r.id_radnik and p.id_dobavljac=d.id_dobavljac and p.vrsta = 'false';";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvArtikli.DataSource = null;
                dgvArtikli.DataSource = dt;
            }
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

                txtID.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = cmbDobavljac.Text= null;

            }            
        }

        private void PopuniRadnike()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                NpgsqlCommand sc = new NpgsqlCommand("select id_radnik, CONCAT(ime, ' ', prezime) as puno_ime from radnik", con);
                NpgsqlDataReader reader;

                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("id_radnik", typeof(string));
                dt.Columns.Add("puno_ime", typeof(string));
                dt.Load(reader);

                cmbRadnik.ValueMember = "id_radnik";
                cmbRadnik.DisplayMember = "puno_ime";
                cmbRadnik.DataSource = dt;

                con.Close();

                txtID.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = cmbDobavljac.Text = null;

            }
        }

        private int rowIndex = -1;

        private void btnStvoriPrimku_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    rowIndex = -1;
                    txtDatum.Text = DateTime.Now.ToString();

                    int radnik = Convert.ToInt32(cmbRadnik.SelectedValue.ToString());
                    int dobavljac = Convert.ToInt32(cmbDobavljac.SelectedValue.ToString());

                    string upit = "select * from public.unos_dokumenta (CAST('" + txtDatum.Text + "' AS TIMESTAMP WITHOUT TIME ZONE), '" + radnik + "', '" + dobavljac + "', 'false'); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Nova primka je uspješno kreirana!");


                    DohvatiPrimke();
                    DohvatiZadnjuPrimku();
                }
            }
            catch (Exception er)
            {

                MessageBox.Show("Molim popunite sva polja! \n ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    con.Open();

                    int artikl = Convert.ToInt32(cmbArtikl.SelectedValue.ToString());

                    string upit = "select * from public.unos_stavke_dokumenta ('" + artikl + "', '" + int.Parse(txtIDprimka.Text.ToString()) + "', '" + txtKolicina.Text + "'); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);

                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Artikl je uspješno dodan na primku!");

                    DohvatiPrimke();
                    DohvatiZadnjuPrimku();

                    con.Close();

                    cmbArtikl.Text = txtKolicina.Text = null;

                }
            }
            catch (Exception er)
            {

                MessageBox.Show("Molim popunite sva polja ili provjerite je li unesena stavka već sadržana na primci! \n " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            txtID.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = cmbDobavljac.Text = txtDatum.Text= null;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Molim odaberite stavku primke koju želite obrisati");
            }

            else
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    rowIndex = -1;

                    string upit = "select * from public.izbrisi_stavku_primke('" + int.Parse(txtID.Text) + "', '" + int.Parse(txtIDprimka.Text) + " ');";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Stavka je uspješno izbrisan!");

                    //txtID.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = cmbDobavljac.Text = null;
                    DohvatiPrimke();
                    btnSpremi.Enabled = true;

                }
            }
        }

        private void dgvArtikli_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {

            using (NpgsqlConnection con = GetConnection())
            {
                if (rowIndex < 0)
                {
                    MessageBox.Show("Molim odaberite stavku primke koji čiju količinu želite ažurirati");
                }

                else
                {

                    rowIndex = -1;
                    string upit = "select * from public.uredi_stavku_primke('" + int.Parse(txtID.Text) + " ', '" + int.Parse(txtIDprimka.Text) + " ', '" + int.Parse(txtKolicina.Text) + " '); ";

                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Artikl na primci je uspješno uređen!");

                    txtID.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = cmbDobavljac.Text = null;
                    DohvatiPrimke();
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
                    " or [dobavljac] like '%" + txtPretrazi.Text + "%' " +
                    " or [ime_radnika] like '%" + txtPretrazi.Text + "%' " +
                    " or [prezime_radnika] like '%" + txtPretrazi.Text + "%' " ;
                dgvArtikli.DataSource = dv;
            }

            else
            {
                MessageBox.Show("Unesite pojam za pretraživanje!");
            }
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form narudzbe = new FormNarudzbe();
            narudzbe.Show();
        }
    }
}
