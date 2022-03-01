namespace UpravljanjeZalihama.Forme
{
    partial class FormRucnaNarudzba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOcisti = new System.Windows.Forms.Button();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.cmbDobavljac = new System.Windows.Forms.ComboBox();
            this.txtIDprimka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStvoriPrimku = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbRadnik = new System.Windows.Forms.ComboBox();
            this.cmbArtikl = new System.Windows.Forms.ComboBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblStanjeZaliha = new System.Windows.Forms.Label();
            this.lblRadnik = new System.Windows.Forms.Label();
            this.lblArtikl = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnOcisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcisti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOcisti.Location = new System.Drawing.Point(139, 169);
            this.btnOcisti.Margin = new System.Windows.Forms.Padding(4);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(107, 37);
            this.btnOcisti.TabIndex = 107;
            this.btnOcisti.Text = "Očisti polja";
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click_1);
            // 
            // txtDatum
            // 
            this.txtDatum.Enabled = false;
            this.txtDatum.Location = new System.Drawing.Point(146, 140);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(335, 22);
            this.txtDatum.TabIndex = 106;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(19, 140);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(53, 17);
            this.lblDatum.TabIndex = 105;
            this.lblDatum.Text = "Datum:";
            // 
            // cmbDobavljac
            // 
            this.cmbDobavljac.FormattingEnabled = true;
            this.cmbDobavljac.Location = new System.Drawing.Point(146, 107);
            this.cmbDobavljac.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDobavljac.Name = "cmbDobavljac";
            this.cmbDobavljac.Size = new System.Drawing.Size(335, 24);
            this.cmbDobavljac.TabIndex = 104;
            // 
            // txtIDprimka
            // 
            this.txtIDprimka.Enabled = false;
            this.txtIDprimka.Location = new System.Drawing.Point(101, 72);
            this.txtIDprimka.Name = "txtIDprimka";
            this.txtIDprimka.Size = new System.Drawing.Size(38, 22);
            this.txtIDprimka.TabIndex = 103;
            this.txtIDprimka.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 102;
            this.label1.Text = "Dobavio:";
            // 
            // btnStvoriPrimku
            // 
            this.btnStvoriPrimku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnStvoriPrimku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStvoriPrimku.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStvoriPrimku.Location = new System.Drawing.Point(254, 169);
            this.btnStvoriPrimku.Margin = new System.Windows.Forms.Padding(4);
            this.btnStvoriPrimku.Name = "btnStvoriPrimku";
            this.btnStvoriPrimku.Size = new System.Drawing.Size(225, 37);
            this.btnStvoriPrimku.TabIndex = 101;
            this.btnStvoriPrimku.Text = "Stvori novu narudžbu";
            this.btnStvoriPrimku.UseVisualStyleBackColor = false;
            this.btnStvoriPrimku.Click += new System.EventHandler(this.btnStvoriPrimku_Click_1);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(101, 255);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(38, 22);
            this.txtID.TabIndex = 100;
            this.txtID.Visible = false;
            // 
            // cmbRadnik
            // 
            this.cmbRadnik.FormattingEnabled = true;
            this.cmbRadnik.Location = new System.Drawing.Point(146, 72);
            this.cmbRadnik.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRadnik.Name = "cmbRadnik";
            this.cmbRadnik.Size = new System.Drawing.Size(335, 24);
            this.cmbRadnik.TabIndex = 99;
            // 
            // cmbArtikl
            // 
            this.cmbArtikl.FormattingEnabled = true;
            this.cmbArtikl.Location = new System.Drawing.Point(146, 255);
            this.cmbArtikl.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArtikl.Name = "cmbArtikl";
            this.cmbArtikl.Size = new System.Drawing.Size(335, 24);
            this.cmbArtikl.TabIndex = 98;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(22, 290);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(61, 17);
            this.lblKolicina.TabIndex = 97;
            this.lblKolicina.Text = "Količina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(146, 290);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(333, 22);
            this.txtKolicina.TabIndex = 96;
            // 
            // lblStanjeZaliha
            // 
            this.lblStanjeZaliha.AutoSize = true;
            this.lblStanjeZaliha.Location = new System.Drawing.Point(403, 255);
            this.lblStanjeZaliha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanjeZaliha.Name = "lblStanjeZaliha";
            this.lblStanjeZaliha.Size = new System.Drawing.Size(0, 17);
            this.lblStanjeZaliha.TabIndex = 95;
            // 
            // lblRadnik
            // 
            this.lblRadnik.AutoSize = true;
            this.lblRadnik.Location = new System.Drawing.Point(16, 75);
            this.lblRadnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRadnik.Name = "lblRadnik";
            this.lblRadnik.Size = new System.Drawing.Size(67, 17);
            this.lblRadnik.TabIndex = 94;
            this.lblRadnik.Text = "Zaprimio:";
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.Location = new System.Drawing.Point(22, 258);
            this.lblArtikl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(43, 17);
            this.lblArtikl.TabIndex = 93;
            this.lblArtikl.Text = "Artikl:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Green;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSpremi.Location = new System.Drawing.Point(215, 320);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(225, 37);
            this.btnSpremi.TabIndex = 92;
            this.btnSpremi.Text = "Dodaj na stvorenu narudžbu";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click_1);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNatrag.Location = new System.Drawing.Point(13, 18);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(4);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(107, 37);
            this.btnNatrag.TabIndex = 108;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // FormRucnaNarudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 385);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.cmbDobavljac);
            this.Controls.Add(this.txtIDprimka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStvoriPrimku);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cmbRadnik);
            this.Controls.Add(this.cmbArtikl);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblStanjeZaliha);
            this.Controls.Add(this.lblRadnik);
            this.Controls.Add(this.lblArtikl);
            this.Controls.Add(this.btnSpremi);
            this.Name = "FormRucnaNarudzba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos narudžbe";
            this.Load += new System.EventHandler(this.FormRucnaNarudzba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.ComboBox cmbDobavljac;
        private System.Windows.Forms.TextBox txtIDprimka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStvoriPrimku;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbRadnik;
        private System.Windows.Forms.ComboBox cmbArtikl;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblStanjeZaliha;
        private System.Windows.Forms.Label lblRadnik;
        private System.Windows.Forms.Label lblArtikl;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnNatrag;
    }
}