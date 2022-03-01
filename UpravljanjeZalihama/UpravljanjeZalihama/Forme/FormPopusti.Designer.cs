namespace UpravljanjeZalihama.Forme
{
    partial class FormPopusti
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
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.lblStanjeZaliha = new System.Windows.Forms.Label();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.dgvPopusti = new System.Windows.Forms.DataGridView();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.txtAkcijskaCijena = new System.Windows.Forms.TextBox();
            this.lblPocetak = new System.Windows.Forms.Label();
            this.lblZavrsetak = new System.Windows.Forms.Label();
            this.lblAkcijska = new System.Windows.Forms.Label();
            this.cmbArtikl = new System.Windows.Forms.ComboBox();
            this.lblArtikl = new System.Windows.Forms.Label();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rbSvi = new System.Windows.Forms.RadioButton();
            this.rbProsli = new System.Windows.Forms.RadioButton();
            this.rbAktualni = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDanasnji = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopusti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(-118, 349);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(41, 17);
            this.lblOpis.TabIndex = 121;
            this.lblOpis.Text = "Opis:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(-118, 317);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(47, 17);
            this.lblNaziv.TabIndex = 119;
            this.lblNaziv.Text = "Naziv:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPretrazi.Location = new System.Drawing.Point(952, 13);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(107, 37);
            this.btnPretrazi.TabIndex = 118;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(787, 22);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(156, 22);
            this.txtPretrazi.TabIndex = 117;
            // 
            // lblStanjeZaliha
            // 
            this.lblStanjeZaliha.AutoSize = true;
            this.lblStanjeZaliha.Location = new System.Drawing.Point(954, 331);
            this.lblStanjeZaliha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanjeZaliha.Name = "lblStanjeZaliha";
            this.lblStanjeZaliha.Size = new System.Drawing.Size(0, 17);
            this.lblStanjeZaliha.TabIndex = 116;
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUredi.Location = new System.Drawing.Point(302, 421);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(4);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(107, 37);
            this.btnUredi.TabIndex = 115;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.DarkRed;
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIzbrisi.Location = new System.Drawing.Point(416, 421);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(107, 37);
            this.btnIzbrisi.TabIndex = 114;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Green;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSpremi.Location = new System.Drawing.Point(187, 421);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(107, 37);
            this.btnSpremi.TabIndex = 113;
            this.btnSpremi.Text = "Dodaj";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // dgvPopusti
            // 
            this.dgvPopusti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopusti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.dgvPopusti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopusti.Location = new System.Drawing.Point(24, 57);
            this.dgvPopusti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPopusti.Name = "dgvPopusti";
            this.dgvPopusti.RowHeadersWidth = 51;
            this.dgvPopusti.Size = new System.Drawing.Size(1035, 224);
            this.dgvPopusti.TabIndex = 112;
            this.dgvPopusti.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopusti_CellClick);
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPocetak.Location = new System.Drawing.Point(187, 327);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(336, 22);
            this.dtpPocetak.TabIndex = 123;
            // 
            // dtpZavrsetak
            // 
            this.dtpZavrsetak.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpZavrsetak.Location = new System.Drawing.Point(187, 356);
            this.dtpZavrsetak.Name = "dtpZavrsetak";
            this.dtpZavrsetak.Size = new System.Drawing.Size(336, 22);
            this.dtpZavrsetak.TabIndex = 124;
            // 
            // txtAkcijskaCijena
            // 
            this.txtAkcijskaCijena.Location = new System.Drawing.Point(187, 385);
            this.txtAkcijskaCijena.Name = "txtAkcijskaCijena";
            this.txtAkcijskaCijena.Size = new System.Drawing.Size(336, 22);
            this.txtAkcijskaCijena.TabIndex = 125;
            // 
            // lblPocetak
            // 
            this.lblPocetak.AutoSize = true;
            this.lblPocetak.Location = new System.Drawing.Point(24, 330);
            this.lblPocetak.Name = "lblPocetak";
            this.lblPocetak.Size = new System.Drawing.Size(107, 17);
            this.lblPocetak.TabIndex = 126;
            this.lblPocetak.Text = "Datum početka:";
            // 
            // lblZavrsetak
            // 
            this.lblZavrsetak.AutoSize = true;
            this.lblZavrsetak.Location = new System.Drawing.Point(24, 361);
            this.lblZavrsetak.Name = "lblZavrsetak";
            this.lblZavrsetak.Size = new System.Drawing.Size(120, 17);
            this.lblZavrsetak.TabIndex = 127;
            this.lblZavrsetak.Text = "Datum Završetka:";
            // 
            // lblAkcijska
            // 
            this.lblAkcijska.AutoSize = true;
            this.lblAkcijska.Location = new System.Drawing.Point(24, 390);
            this.lblAkcijska.Name = "lblAkcijska";
            this.lblAkcijska.Size = new System.Drawing.Size(104, 17);
            this.lblAkcijska.TabIndex = 128;
            this.lblAkcijska.Text = "Akcijska cijena:";
            // 
            // cmbArtikl
            // 
            this.cmbArtikl.FormattingEnabled = true;
            this.cmbArtikl.Location = new System.Drawing.Point(187, 296);
            this.cmbArtikl.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArtikl.Name = "cmbArtikl";
            this.cmbArtikl.Size = new System.Drawing.Size(335, 24);
            this.cmbArtikl.TabIndex = 130;
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.Location = new System.Drawing.Point(25, 300);
            this.lblArtikl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(43, 17);
            this.lblArtikl.TabIndex = 129;
            this.lblArtikl.Text = "Artikl:";
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnOcisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcisti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOcisti.Location = new System.Drawing.Point(547, 331);
            this.btnOcisti.Margin = new System.Windows.Forms.Padding(4);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(107, 37);
            this.btnOcisti.TabIndex = 131;
            this.btnOcisti.Text = "Očisti polja";
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(143, 296);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(37, 22);
            this.txtID.TabIndex = 132;
            this.txtID.Visible = false;
            // 
            // rbSvi
            // 
            this.rbSvi.AutoSize = true;
            this.rbSvi.Checked = true;
            this.rbSvi.Location = new System.Drawing.Point(928, 296);
            this.rbSvi.Name = "rbSvi";
            this.rbSvi.Size = new System.Drawing.Size(98, 21);
            this.rbSvi.TabIndex = 133;
            this.rbSvi.TabStop = true;
            this.rbSvi.Text = "Svi popusti";
            this.rbSvi.UseVisualStyleBackColor = true;
            this.rbSvi.CheckedChanged += new System.EventHandler(this.rbSvi_CheckedChanged);
            // 
            // rbProsli
            // 
            this.rbProsli.AutoSize = true;
            this.rbProsli.Location = new System.Drawing.Point(928, 327);
            this.rbProsli.Name = "rbProsli";
            this.rbProsli.Size = new System.Drawing.Size(114, 21);
            this.rbProsli.TabIndex = 134;
            this.rbProsli.Text = "Prošli popusti";
            this.rbProsli.UseVisualStyleBackColor = true;
            this.rbProsli.CheckedChanged += new System.EventHandler(this.rbProsli_CheckedChanged);
            // 
            // rbAktualni
            // 
            this.rbAktualni.AutoSize = true;
            this.rbAktualni.Location = new System.Drawing.Point(928, 355);
            this.rbAktualni.Name = "rbAktualni";
            this.rbAktualni.Size = new System.Drawing.Size(129, 21);
            this.rbAktualni.TabIndex = 135;
            this.rbAktualni.Text = "Aktualni popusti";
            this.rbAktualni.UseVisualStyleBackColor = true;
            this.rbAktualni.CheckedChanged += new System.EventHandler(this.rbAktualni_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(858, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 136;
            this.label1.Text = "Prikaži:";
            // 
            // txtDanasnji
            // 
            this.txtDanasnji.Enabled = false;
            this.txtDanasnji.Location = new System.Drawing.Point(94, 28);
            this.txtDanasnji.Name = "txtDanasnji";
            this.txtDanasnji.Size = new System.Drawing.Size(156, 22);
            this.txtDanasnji.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 138;
            this.label2.Text = "Datum:";
            // 
            // FormPopusti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDanasnji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbAktualni);
            this.Controls.Add(this.rbProsli);
            this.Controls.Add(this.rbSvi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.cmbArtikl);
            this.Controls.Add(this.lblArtikl);
            this.Controls.Add(this.lblAkcijska);
            this.Controls.Add(this.lblZavrsetak);
            this.Controls.Add(this.lblPocetak);
            this.Controls.Add(this.txtAkcijskaCijena);
            this.Controls.Add(this.dtpZavrsetak);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lblStanjeZaliha);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dgvPopusti);
            this.Name = "FormPopusti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popusti";
            this.Load += new System.EventHandler(this.FormPopusti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopusti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label lblStanjeZaliha;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.DataGridView dgvPopusti;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.DateTimePicker dtpZavrsetak;
        private System.Windows.Forms.TextBox txtAkcijskaCijena;
        private System.Windows.Forms.Label lblPocetak;
        private System.Windows.Forms.Label lblZavrsetak;
        private System.Windows.Forms.Label lblAkcijska;
        private System.Windows.Forms.ComboBox cmbArtikl;
        private System.Windows.Forms.Label lblArtikl;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RadioButton rbSvi;
        private System.Windows.Forms.RadioButton rbProsli;
        private System.Windows.Forms.RadioButton rbAktualni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDanasnji;
        private System.Windows.Forms.Label label2;
    }
}