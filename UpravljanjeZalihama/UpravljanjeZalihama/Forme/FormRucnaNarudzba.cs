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
    public partial class FormRucnaNarudzba : Form
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


        public FormRucnaNarudzba()
        {
            InitializeComponent();
        }



        private void FormRucnaNarudzba_Load(object sender, EventArgs e)
        {
            TestConnection();
            //PopuniArtikle();
            PopuniRadnike();
            PopuniDobavljace();
            DohvatiZadnjuPrimku();

            txtDatum.Text = txtID.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = cmbDobavljac.Text = null;
        }

        

        private void DohvatiZadnjuPrimku()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                NpgsqlCommand sc = new NpgsqlCommand("select p.id_dokument, p.id_radnik, p.id_dobavljac, p.datum,CONCAT(r.ime, ' ', r.prezime) as puno_ime, d.ime as dobavljac from radnik r, dobavljac d, dokument p " +
                    "where p.id_radnik = r.id_radnik and p.id_dobavljac = d.id_dobavljac and p.vrsta = 'true' and zaprimljeno='false'" +
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

               // txtID.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = cmbDobavljac.Text = null;

            }
        }

      
        private void PopuniArtikle()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                int dobavljac = Convert.ToInt32(cmbDobavljac.SelectedValue.ToString());

                con.Open();

                NpgsqlCommand sc = new NpgsqlCommand("select a.id_artikl, a.naziv from artikl a, dobavljac d where a.id_dobavljac = d.id_dobavljac and d.id_dobavljac= '" + dobavljac + "'", con);
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

                // txtID.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = cmbDobavljac.Text = null;

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

                //txtID.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = cmbDobavljac.Text = null;

            }
        }

    

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Form narudzbe = new FormNarudzbe();
            narudzbe.Show();
        }

        private void btnOcisti_Click_1(object sender, EventArgs e)
        {
            txtID.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = cmbDobavljac.Text = null;
        }

        private void btnStvoriPrimku_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    
                    txtDatum.Text = DateTime.Now.ToString();

                    int radnik = Convert.ToInt32(cmbRadnik.SelectedValue.ToString());
                    int dobavljac = Convert.ToInt32(cmbDobavljac.SelectedValue.ToString());

                    string upit = "select * from public.unos_dokumenta (CAST('" + txtDatum.Text + "' AS TIMESTAMP WITHOUT TIME ZONE), '" + radnik + "', '" + dobavljac + "', 'true', 'false'); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Nova narudžba je uspješno kreirana!");



                    DohvatiZadnjuPrimku();
                    PopuniArtikle();
                }
            }
            catch (Exception er)
            {

                MessageBox.Show("Molim popunite sva polja! \n ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpremi_Click_1(object sender, EventArgs e)
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

                    MessageBox.Show("Artikl je uspješno dodan na narudžbu!");


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
    }

}



