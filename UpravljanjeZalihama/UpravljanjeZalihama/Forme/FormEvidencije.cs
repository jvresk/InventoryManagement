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
    public partial class FormEvidencije : Form
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


        public FormEvidencije()
        {
            InitializeComponent();
        }

        private DataTable dt;

        private void FormEvidencije_Load(object sender, EventArgs e)
        {
            PopuniPrimke();
            PopuniRacune();
            PopuniSkladiste();
        }

        private void PopuniSkladiste()
        {

            using (NpgsqlConnection con = GetConnection())
            {
                string query = @"select a.id_artikl, a.naziv, a.donja_granica_kolicine, a.gornja_granica_kolicine, s.kolicina_na_skladistu
                                 from artikl a, stanje_na_skladistu s where a.id_artikl=s.id_artikl order by 2 asc;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();


                dt = new DataTable();

                dt.Columns.Add("id_artikl", typeof(string));
                dt.Columns.Add("naziv", typeof(string));
                dt.Columns.Add("donja_granica_kolicine", typeof(string));
                dt.Columns.Add("gornja_granica_kolicine", typeof(string));
                dt.Columns.Add("kolicina_na_skladistu", typeof(string));
                //dt.Columns.Add("naruciti", typeof(string));
                dt.Load(cmd.ExecuteReader());

                /*for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int donja = int.Parse(dt.Rows[i]["donja_granica_kolicine"].ToString());
                    int gornja = int.Parse(dt.Rows[i]["gornja_granica_kolicine"].ToString());
                    int skladiste = int.Parse(dt.Rows[i]["kolicina_na_skladistu"].ToString());
                    int zaNaruciti = gornja - skladiste;

                    DataRow dr = dt.Rows[i];
                    dr["naruciti"] = zaNaruciti.ToString();

                }*/

                dgvSkladiste.DataSource = null;
                dgvSkladiste.DataSource = dt;
            }
        }

        private void PopuniRacune()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                string query = @"select a.id_artikl, a.naziv, r.ime as ime_radnika, r.prezime as prezime_radnika, rc.datum, sr.kolicina, sr.cijena
                                    from artikl a, radnik r, racun rc, stavke_racuna sr
                                    where a.id_artikl=sr.id_artikl and sr.id_racun=rc.id_racun and rc.id_radnik=r.id_radnik order by 2 asc;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvRacuni.DataSource = null;
                dgvRacuni.DataSource = dt;
            }
        }

        private void PopuniPrimke()
        {
            using (NpgsqlConnection con = GetConnection())
            {
                string query = @"select a.id_artikl, a.naziv, r.ime as ime_radnika, r.prezime as prezime_radnika, d.ime as dobavljac, p.datum, sp.kolicina
                                    from artikl a, radnik r, dobavljac d, dokument p, stavke_dokument sp
                                    where a.id_artikl=sp.id_artikl and sp.id_dokument=p.id_dokument and p.id_radnik=r.id_radnik and p.id_dobavljac=d.id_dobavljac and p.vrsta= 'false' order by 2 asc;";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();

                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvPrimke.DataSource = null;
                dgvPrimke.DataSource = dt;
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            if (txtPretrazi.Text != "")
            {
                dv.RowFilter = "naziv LIKE '" + txtPretrazi.Text + "%'";
                   
                dgvSkladiste.DataSource = dv;
            }

            else
            {
                MessageBox.Show("Unesite pojam za pretraživanje!");
            }
        }
    }
}
