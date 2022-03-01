namespace UpravljanjeZalihama.Forme
{
    partial class FormRacuni
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
            this.txtIDRacun = new System.Windows.Forms.TextBox();
            this.btnStvoriRacun = new System.Windows.Forms.Button();
            this.txtIDArtikla = new System.Windows.Forms.TextBox();
            this.cmbRadnik = new System.Windows.Forms.ComboBox();
            this.cmbArtikl = new System.Windows.Forms.ComboBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.lblStanjeZaliha = new System.Windows.Forms.Label();
            this.lblRadnik = new System.Windows.Forms.Label();
            this.lblArtikl = new System.Windows.Forms.Label();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnOcisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcisti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOcisti.Location = new System.Drawing.Point(149, 424);
            this.btnOcisti.Margin = new System.Windows.Forms.Padding(4);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(107, 37);
            this.btnOcisti.TabIndex = 112;
            this.btnOcisti.Text = "Očisti polja";
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // txtDatum
            // 
            this.txtDatum.Enabled = false;
            this.txtDatum.Location = new System.Drawing.Point(149, 395);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(335, 22);
            this.txtDatum.TabIndex = 111;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(19, 395);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(53, 17);
            this.lblDatum.TabIndex = 110;
            this.lblDatum.Text = "Datum:";
            // 
            // txtIDRacun
            // 
            this.txtIDRacun.Enabled = false;
            this.txtIDRacun.Location = new System.Drawing.Point(104, 360);
            this.txtIDRacun.Name = "txtIDRacun";
            this.txtIDRacun.Size = new System.Drawing.Size(38, 22);
            this.txtIDRacun.TabIndex = 108;
            this.txtIDRacun.Visible = false;
            // 
            // btnStvoriRacun
            // 
            this.btnStvoriRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnStvoriRacun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStvoriRacun.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStvoriRacun.Location = new System.Drawing.Point(284, 424);
            this.btnStvoriRacun.Margin = new System.Windows.Forms.Padding(4);
            this.btnStvoriRacun.Name = "btnStvoriRacun";
            this.btnStvoriRacun.Size = new System.Drawing.Size(200, 37);
            this.btnStvoriRacun.TabIndex = 106;
            this.btnStvoriRacun.Text = "Stvori novi račun";
            this.btnStvoriRacun.UseVisualStyleBackColor = false;
            this.btnStvoriRacun.Click += new System.EventHandler(this.btnStvoriRacun_Click);
            // 
            // txtIDArtikla
            // 
            this.txtIDArtikla.Enabled = false;
            this.txtIDArtikla.Location = new System.Drawing.Point(668, 363);
            this.txtIDArtikla.Name = "txtIDArtikla";
            this.txtIDArtikla.Size = new System.Drawing.Size(38, 22);
            this.txtIDArtikla.TabIndex = 105;
            this.txtIDArtikla.Visible = false;
            // 
            // cmbRadnik
            // 
            this.cmbRadnik.FormattingEnabled = true;
            this.cmbRadnik.Location = new System.Drawing.Point(149, 360);
            this.cmbRadnik.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRadnik.Name = "cmbRadnik";
            this.cmbRadnik.Size = new System.Drawing.Size(335, 24);
            this.cmbRadnik.TabIndex = 104;
            // 
            // cmbArtikl
            // 
            this.cmbArtikl.FormattingEnabled = true;
            this.cmbArtikl.Location = new System.Drawing.Point(713, 363);
            this.cmbArtikl.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArtikl.Name = "cmbArtikl";
            this.cmbArtikl.Size = new System.Drawing.Size(335, 24);
            this.cmbArtikl.TabIndex = 103;
            this.cmbArtikl.DropDownClosed += new System.EventHandler(this.cmbArtikl_DropDownClosed);
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(589, 424);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(61, 17);
            this.lblKolicina.TabIndex = 102;
            this.lblKolicina.Text = "Količina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(713, 424);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(335, 22);
            this.txtKolicina.TabIndex = 101;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPretrazi.Location = new System.Drawing.Point(947, 19);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(107, 37);
            this.btnPretrazi.TabIndex = 100;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(782, 28);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(156, 22);
            this.txtPretrazi.TabIndex = 99;
            // 
            // lblStanjeZaliha
            // 
            this.lblStanjeZaliha.AutoSize = true;
            this.lblStanjeZaliha.Location = new System.Drawing.Point(970, 363);
            this.lblStanjeZaliha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanjeZaliha.Name = "lblStanjeZaliha";
            this.lblStanjeZaliha.Size = new System.Drawing.Size(0, 17);
            this.lblStanjeZaliha.TabIndex = 98;
            // 
            // lblRadnik
            // 
            this.lblRadnik.AutoSize = true;
            this.lblRadnik.Location = new System.Drawing.Point(19, 363);
            this.lblRadnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRadnik.Name = "lblRadnik";
            this.lblRadnik.Size = new System.Drawing.Size(46, 17);
            this.lblRadnik.TabIndex = 97;
            this.lblRadnik.Text = "Izdao:";
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.Location = new System.Drawing.Point(589, 366);
            this.lblArtikl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(43, 17);
            this.lblArtikl.TabIndex = 96;
            this.lblArtikl.Text = "Artikl:";
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUredi.Location = new System.Drawing.Point(835, 292);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(4);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(107, 37);
            this.btnUredi.TabIndex = 95;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Visible = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.DarkRed;
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIzbrisi.Location = new System.Drawing.Point(950, 292);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(107, 37);
            this.btnIzbrisi.TabIndex = 94;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Visible = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Green;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSpremi.Location = new System.Drawing.Point(758, 454);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(239, 37);
            this.btnSpremi.TabIndex = 93;
            this.btnSpremi.Text = "Dodaj na stvoreni račun";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Location = new System.Drawing.Point(19, 63);
            this.dgvRacuni.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.RowHeadersWidth = 51;
            this.dgvRacuni.Size = new System.Drawing.Size(1035, 224);
            this.dgvRacuni.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(589, 525);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 113;
            this.label1.Text = "Ukupna cijena:";
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Enabled = false;
            this.txtUkupnaCijena.Location = new System.Drawing.Point(713, 523);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(335, 22);
            this.txtUkupnaCijena.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 115;
            this.label2.Text = "Cijena po jedinici:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(713, 395);
            this.txtCijena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(335, 22);
            this.txtCijena.TabIndex = 116;
            // 
            // FormRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUkupnaCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.txtIDRacun);
            this.Controls.Add(this.btnStvoriRacun);
            this.Controls.Add(this.txtIDArtikla);
            this.Controls.Add(this.cmbRadnik);
            this.Controls.Add(this.cmbArtikl);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lblStanjeZaliha);
            this.Controls.Add(this.lblRadnik);
            this.Controls.Add(this.lblArtikl);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dgvRacuni);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRacuni";
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.FormRacuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtIDRacun;
        private System.Windows.Forms.Button btnStvoriRacun;
        private System.Windows.Forms.TextBox txtIDArtikla;
        private System.Windows.Forms.ComboBox cmbRadnik;
        private System.Windows.Forms.ComboBox cmbArtikl;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label lblStanjeZaliha;
        private System.Windows.Forms.Label lblRadnik;
        private System.Windows.Forms.Label lblArtikl;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCijena;
    }
}