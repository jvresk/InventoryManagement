using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpravljanjeZalihama
{
    public partial class FormPocetna : Form
    {
        private Button trenutniGumb;
        private Form aktivnaForma;
        public FormPocetna()
        {
            InitializeComponent();
        }

        private void AktiviraniGumb(object btnakt)
        {
            if (btnakt != null)
            {
                if(trenutniGumb != (Button)btnakt)
                {
                    trenutniGumb = (Button)btnakt;
                }
            }
        }

        private void OtvaranjeFormeDijeteta(Form FormaDijete, object btnakt)
        {
            if (aktivnaForma != null)
            {
                aktivnaForma.Close();
            }
            AktiviraniGumb(btnakt);
            aktivnaForma = FormaDijete;
            FormaDijete.TopLevel = false;
            FormaDijete.FormBorderStyle = FormBorderStyle.None;
            FormaDijete.Dock = DockStyle.Fill;
            this.panelTemeljni.Controls.Add(FormaDijete);
            this.panelTemeljni.Tag = FormaDijete;
            FormaDijete.BringToFront();
            FormaDijete.Show();

            lblNaslov.Text = FormaDijete.Text;
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            OtvaranjeFormeDijeteta(new Forme.FormArtikli(), sender);
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            OtvaranjeFormeDijeteta(new Forme.FormRacuni(), sender);
        }

        private void btnDobavljaci_Click(object sender, EventArgs e)
        {
            OtvaranjeFormeDijeteta(new Forme.FormDobavljaci(), sender);
        }

        private void btnPrimke_Click(object sender, EventArgs e)
        {
            OtvaranjeFormeDijeteta(new Forme.FormNarudzbe(), sender);
        }

        private void btnRadnici_Click(object sender, EventArgs e)
        {
            OtvaranjeFormeDijeteta(new Forme.FormRadnici(), sender);
        }

        private void btnEvidencije_Click(object sender, EventArgs e)
        {
            OtvaranjeFormeDijeteta(new Forme.FormEvidencije(), sender);
        }
    }

}
