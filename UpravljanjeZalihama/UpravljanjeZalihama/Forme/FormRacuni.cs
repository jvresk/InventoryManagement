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
    public partial class FormRacuni : Form
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

        public FormRacuni()
        {
            InitializeComponent();
        }

        private DataTable dt;

        private void FormRacuni_Load(object sender, EventArgs e)
        {
            TestConnection();
            PopuniArtikle();
            PopuniRadnike();
            DohvatiRacune();
            DohvatiZadnjiRacun();
        }

       

        private void DohvatiRacune()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                string query = @"select a.id_artikl, a.naziv, r.ime as ime_radnika, r.prezime as prezime_radnika, rc.datum, sr.kolicina, sr.cijena, rc.id_racun
                                    from artikl a, radnik r, racun rc, stavke_racuna sr
                                    where a.id_artikl=sr.id_artikl and sr.id_racun=rc.id_racun and rc.id_radnik=r.id_radnik;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvRacuni.DataSource = null;
                dgvRacuni.DataSource = dt;
            }
        }

        private void PopuniArtikle()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                NpgsqlCommand sc = new NpgsqlCommand("select id_artikl, CONCAT(naziv, ', ', prodajna_cijena) as artikl from artikl", con);
                NpgsqlDataReader reader;

                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("id_artikl", typeof(string));
                dt.Columns.Add("artikl", typeof(string));
                dt.Load(reader);

                cmbArtikl.ValueMember = "id_artikl";
                cmbArtikl.DisplayMember = "artikl";
                cmbArtikl.DataSource = dt;

                con.Close();

                txtIDArtikla.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = null;

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

                txtIDArtikla.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = null;

            }
        }

        private void DohvatiZadnjiRacun()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();
                NpgsqlCommand sc = new NpgsqlCommand("select rc.id_racun, rc.id_radnik, rc.datum, a.naziv,  CONCAT(r.ime, ' ', r.prezime) as puno_ime " +
                                                        "from artikl a, radnik r, racun rc " +
                                                        "where rc.id_radnik = r.id_radnik " +
                                                        "order by rc.id_racun desc limit 1; ", con);

                NpgsqlDataReader reader;

                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("id_racun", typeof(string));
                dt.Columns.Add("datum", typeof(string));
                dt.Columns.Add("id_radnik", typeof(string));
                dt.Columns.Add("puno_ime", typeof(string));
                dt.Load(reader);
                con.Close();

                txtIDRacun.Text = dt.Rows[0][0].ToString();
                cmbRadnik.Text = dt.Rows[0][3].ToString();
                txtDatum.Text = dt.Rows[0][1].ToString();
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    con.Open();

                    int id = Convert.ToInt32(cmbArtikl.SelectedValue.ToString());

                    double cijena = double.Parse(txtCijena.Text) * double.Parse(txtKolicina.Text);

                    string upit = "select * from public.unos_stavke_racuna ('" + id + "', '" + int.Parse(txtIDRacun.Text.ToString()) + "', CAST('" + cijena + "' AS MONEY), '" + txtKolicina.Text + "'); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);

                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Stavka računa je uspješno dodana!");

                    DohvatiRacune();

                    con.Close();

                    IzracunajUkupnuCijenu();

                    txtIDArtikla.Text = cmbArtikl.Text = txtKolicina.Text = txtCijena.Text = null;
                }
            }
            catch (Exception er)
            {

                MessageBox.Show("Molim popunite sva polja, provjerite je li odabrani artikl već sadržan na računu ili provjerite količinu na skladištu! \n " +er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void IzracunajUkupnuCijenu() //ak  nema unosa onda nula
        {
            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();

                int idRacuna = int.Parse(txtIDRacun.Text.ToString());

                NpgsqlCommand sc = new NpgsqlCommand("select id_racun, SUM(cijena) as cijena from stavke_racuna where id_racun= '" + idRacuna + "' group by 1; ", con);
            
                NpgsqlDataReader reader;

                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("id_racun", typeof(string));
                dt.Columns.Add("cijena", typeof(string));
                dt.Load(reader);

                
                con.Close();

                txtUkupnaCijena.Text = dt.Rows[0][1].ToString();

            }
        }

        private void cmbArtikl_DropDownClosed(object sender, EventArgs e)
        {

            using (NpgsqlConnection con = GetConnection())
            {
                con.Open();

                string datum = DateTime.Now.ToString();

                int id = Convert.ToInt32(cmbArtikl.SelectedValue.ToString());

                NpgsqlCommand sc = new NpgsqlCommand("select a.id_artikl, p.datum_pocetka, p.datum_zavrsetka, p.akcijska_cijena, a.prodajna_cijena " +
                    "from artikl a, popust p " +
                    "where a.id_artikl= '" + id + "' and '" + id + "'  = p.id_artikl and datum_pocetka <= '"+ datum + "' and datum_zavrsetka >= '" + datum + "' ; ", con);

                NpgsqlDataReader reader;

                reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("id_artikl", typeof(string));
                dt.Columns.Add("datum_pocetka", typeof(string));
                dt.Columns.Add("datum_zavrsetka", typeof(string));
                dt.Columns.Add("akcijska_cijena", typeof(string));
                dt.Columns.Add("prodajna_cijena", typeof(string));
                dt.Load(reader);

                if (dt.Rows.Count > 0)
                {
                    txtCijena.Text = dt.Rows[0][3].ToString();
                    con.Close();
                }

                else
                {
                    using (NpgsqlConnection con2 = GetConnection())
                    {
                        con2.Open();

                        int id2 = Convert.ToInt32(cmbArtikl.SelectedValue.ToString());

                        NpgsqlCommand sc2 = new NpgsqlCommand("select prodajna_cijena from artikl where '" + id2 + "' = id_artikl ; ", con2);

                        NpgsqlDataReader reader2;

                        reader2 = sc2.ExecuteReader();
                        DataTable dt2 = new DataTable();
                        dt2.Columns.Add("prodajna_cijena", typeof(string));
                        dt2.Load(reader2);
                        txtCijena.Text = dt2.Rows[0][0].ToString();
                        con2.Close();
                    }
                }
            }

             
        }

        private void btnStvoriRacun_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    txtDatum.Text = DateTime.Now.ToString();

                    int radnik = Convert.ToInt32(cmbRadnik.SelectedValue.ToString());


                    string upit = "select * from public.unos_racuna (CAST('" + txtDatum.Text + "' AS TIMESTAMP WITHOUT TIME ZONE), '" + radnik + "'); ";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Novi račun je uspješno kreiran!");

                    //txtID.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = cmbDobavljac.Text = null;
                    DohvatiRacune();
                    DohvatiZadnjiRacun();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Molim popunite sva polja! \n ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int rowIndex = -1;

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("Molim odaberite stavku računa koju želite obrisati");
            }

            else
            {
                using (NpgsqlConnection con = GetConnection())
                {
                    rowIndex = -1;

                    string upit = "select * from public.izbrisi_stavku_racuna('" + int.Parse(txtIDArtikla.Text) + "', '" + int.Parse(txtIDRacun.Text) + "');";
                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Stavka je uspješno izbrisan!");

                    cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = null;
                    DohvatiRacune();
                    btnSpremi.Enabled = true;
                }
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            txtIDRacun.Text = cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text = txtDatum.Text = null;
        }

        private void dgvRacuni_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    double cijena = double.Parse(txtCijena.Text) * double.Parse(txtKolicina.Text);

                    rowIndex = -1;
                    string upit = "select * from public.uredi_stavku_racuna('" + int.Parse(txtIDArtikla.Text) + " ', '" + int.Parse(txtIDRacun.Text) + " ', CAST('" + cijena + "' AS MONEY),  '" + int.Parse(txtKolicina.Text) + " '); ";

                    NpgsqlCommand cmd = new NpgsqlCommand(upit, con);
                    con.Open();
                    int n = cmd.ExecuteNonQuery();

                    MessageBox.Show("Stavka računa je uspješno uređena!");

                    cmbArtikl.Text = cmbRadnik.Text = txtKolicina.Text =  null;
                    DohvatiRacune();
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
                    " or [ime_radnika] like '%" + txtPretrazi.Text + "%' " +
                    " or [prezime_radnika] like '%" + txtPretrazi.Text + "%' ";
                dgvRacuni.DataSource = dv;
            }

            else
            {
                MessageBox.Show("Unesite pojam za pretraživanje!");
            }
        }
    }
}
