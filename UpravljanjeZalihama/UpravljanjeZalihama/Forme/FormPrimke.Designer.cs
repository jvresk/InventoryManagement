namespace UpravljanjeZalihama.Forme
{
    partial class FormPrimke
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
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.cmbArtikl = new System.Windows.Forms.ComboBox();
            this.cmbRadnik = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnStvoriPrimku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDprimka = new System.Windows.Forms.TextBox();
            this.cmbDobavljac = new System.Windows.Forms.ComboBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(586, 390);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(61, 17);
            this.lblKolicina.TabIndex = 81;
            this.lblKolicina.Text = "Količina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(710, 390);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(333, 22);
            this.txtKolicina.TabIndex = 80;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPretrazi.Location = new System.Drawing.Point(944, 11);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(107, 37);
            this.btnPretrazi.TabIndex = 79;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(779, 20);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(156, 22);
            this.txtPretrazi.TabIndex = 78;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // lblStanjeZaliha
            // 
            this.lblStanjeZaliha.AutoSize = true;
            this.lblStanjeZaliha.Location = new System.Drawing.Point(967, 355);
            this.lblStanjeZaliha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanjeZaliha.Name = "lblStanjeZaliha";
            this.lblStanjeZaliha.Size = new System.Drawing.Size(0, 17);
            this.lblStanjeZaliha.TabIndex = 77;
            // 
            // lblRadnik
            // 
            this.lblRadnik.AutoSize = true;
            this.lblRadnik.Location = new System.Drawing.Point(16, 355);
            this.lblRadnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRadnik.Name = "lblRadnik";
            this.lblRadnik.Size = new System.Drawing.Size(67, 17);
            this.lblRadnik.TabIndex = 73;
            this.lblRadnik.Text = "Zaprimio:";
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.Location = new System.Drawing.Point(586, 358);
            this.lblArtikl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(43, 17);
            this.lblArtikl.TabIndex = 69;
            this.lblArtikl.Text = "Artikl:";
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUredi.Location = new System.Drawing.Point(832, 284);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(4);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(107, 37);
            this.btnUredi.TabIndex = 68;
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
            this.btnIzbrisi.Location = new System.Drawing.Point(947, 284);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(107, 37);
            this.btnIzbrisi.TabIndex = 67;
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
            this.btnSpremi.Location = new System.Drawing.Point(779, 420);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(225, 37);
            this.btnSpremi.TabIndex = 66;
            this.btnSpremi.Text = "Dodaj na stvorenu primku";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtikli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(16, 55);
            this.dgvArtikli.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.RowHeadersWidth = 51;
            this.dgvArtikli.Size = new System.Drawing.Size(1035, 224);
            this.dgvArtikli.TabIndex = 65;
            // 
            // cmbArtikl
            // 
            this.cmbArtikl.FormattingEnabled = true;
            this.cmbArtikl.Location = new System.Drawing.Point(710, 355);
            this.cmbArtikl.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArtikl.Name = "cmbArtikl";
            this.cmbArtikl.Size = new System.Drawing.Size(335, 24);
            this.cmbArtikl.TabIndex = 82;
            // 
            // cmbRadnik
            // 
            this.cmbRadnik.FormattingEnabled = true;
            this.cmbRadnik.Location = new System.Drawing.Point(146, 352);
            this.cmbRadnik.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRadnik.Name = "cmbRadnik";
            this.cmbRadnik.Size = new System.Drawing.Size(335, 24);
            this.cmbRadnik.TabIndex = 83;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(665, 355);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(38, 22);
            this.txtID.TabIndex = 84;
            this.txtID.Visible = false;
            // 
            // btnStvoriPrimku
            // 
            this.btnStvoriPrimku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnStvoriPrimku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStvoriPrimku.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStvoriPrimku.Location = new System.Drawing.Point(281, 449);
            this.btnStvoriPrimku.Margin = new System.Windows.Forms.Padding(4);
            this.btnStvoriPrimku.Name = "btnStvoriPrimku";
            this.btnStvoriPrimku.Size = new System.Drawing.Size(200, 37);
            this.btnStvoriPrimku.TabIndex = 85;
            this.btnStvoriPrimku.Text = "Stvori novu primku";
            this.btnStvoriPrimku.UseVisualStyleBackColor = false;
            this.btnStvoriPrimku.Click += new System.EventHandler(this.btnStvoriPrimku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 391);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 86;
            this.label1.Text = "Dobavio:";
            // 
            // txtIDprimka
            // 
            this.txtIDprimka.Enabled = false;
            this.txtIDprimka.Location = new System.Drawing.Point(101, 352);
            this.txtIDprimka.Name = "txtIDprimka";
            this.txtIDprimka.Size = new System.Drawing.Size(38, 22);
            this.txtIDprimka.TabIndex = 87;
            // 
            // cmbDobavljac
            // 
            this.cmbDobavljac.FormattingEnabled = true;
            this.cmbDobavljac.Location = new System.Drawing.Point(146, 387);
            this.cmbDobavljac.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDobavljac.Name = "cmbDobavljac";
            this.cmbDobavljac.Size = new System.Drawing.Size(335, 24);
            this.cmbDobavljac.TabIndex = 88;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(19, 420);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(53, 17);
            this.lblDatum.TabIndex = 89;
            this.lblDatum.Text = "Datum:";
            // 
            // txtDatum
            // 
            this.txtDatum.Enabled = false;
            this.txtDatum.Location = new System.Drawing.Point(146, 420);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(335, 22);
            this.txtDatum.TabIndex = 90;
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnOcisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcisti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOcisti.Location = new System.Drawing.Point(146, 449);
            this.btnOcisti.Margin = new System.Windows.Forms.Padding(4);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(107, 37);
            this.btnOcisti.TabIndex = 91;
            this.btnOcisti.Text = "Očisti polja";
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // FormPrimke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lblStanjeZaliha);
            this.Controls.Add(this.lblRadnik);
            this.Controls.Add(this.lblArtikl);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dgvArtikli);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrimke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos primke";
            this.Load += new System.EventHandler(this.FormPrimke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.ComboBox cmbArtikl;
        private System.Windows.Forms.ComboBox cmbRadnik;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnStvoriPrimku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDprimka;
        private System.Windows.Forms.ComboBox cmbDobavljac;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Button btnOcisti;
    }
}