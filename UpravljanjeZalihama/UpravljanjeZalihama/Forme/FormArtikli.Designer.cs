namespace UpravljanjeZalihama.Forme
{
    partial class FormArtikli
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
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnPopusti = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtNabavnaCijena = new System.Windows.Forms.TextBox();
            this.lblNabavnaCijena = new System.Windows.Forms.Label();
            this.txtProdajnaCijena = new System.Windows.Forms.TextBox();
            this.lblProdajnaCijena = new System.Windows.Forms.Label();
            this.txtDonjaGranica = new System.Windows.Forms.TextBox();
            this.lblDonjaGranica = new System.Windows.Forms.Label();
            this.txtGornjaGranica = new System.Windows.Forms.TextBox();
            this.lblGronjaGranica = new System.Windows.Forms.Label();
            this.lblVrstaArtikla = new System.Windows.Forms.Label();
            this.cmbVrstaArtikla = new System.Windows.Forms.ComboBox();
            this.btnDodajVrstuArtikla = new System.Windows.Forms.Button();
            this.lblZaliha = new System.Windows.Forms.Label();
            this.lblStanjeZaliha = new System.Windows.Forms.Label();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtZalihe = new System.Windows.Forms.TextBox();
            this.cmbDobavljac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtikli.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(16, 52);
            this.dgvArtikli.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.RowHeadersWidth = 51;
            this.dgvArtikli.Size = new System.Drawing.Size(1035, 224);
            this.dgvArtikli.TabIndex = 0;
            this.dgvArtikli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikli_CellClick);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(779, 18);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(156, 22);
            this.txtPretrazi.TabIndex = 2;
            // 
            // btnPopusti
            // 
            this.btnPopusti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnPopusti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopusti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPopusti.Location = new System.Drawing.Point(16, 10);
            this.btnPopusti.Margin = new System.Windows.Forms.Padding(4);
            this.btnPopusti.Name = "btnPopusti";
            this.btnPopusti.Size = new System.Drawing.Size(107, 37);
            this.btnPopusti.TabIndex = 3;
            this.btnPopusti.Text = "Popusti";
            this.btnPopusti.UseVisualStyleBackColor = false;
            this.btnPopusti.Click += new System.EventHandler(this.btnPopusti_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Green;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSpremi.Location = new System.Drawing.Point(224, 541);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(107, 37);
            this.btnSpremi.TabIndex = 4;
            this.btnSpremi.Text = "Dodaj";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.DarkRed;
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIzbrisi.Location = new System.Drawing.Point(453, 541);
            this.btnIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(107, 37);
            this.btnIzbrisi.TabIndex = 5;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUredi.Location = new System.Drawing.Point(339, 541);
            this.btnUredi.Margin = new System.Windows.Forms.Padding(4);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(107, 37);
            this.btnUredi.TabIndex = 6;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPretrazi.Location = new System.Drawing.Point(944, 10);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(107, 37);
            this.btnPretrazi.TabIndex = 7;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(17, 288);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(47, 17);
            this.lblNaziv.TabIndex = 8;
            this.lblNaziv.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(225, 284);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(333, 22);
            this.txtNaziv.TabIndex = 9;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(225, 316);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(333, 22);
            this.txtOpis.TabIndex = 11;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(17, 320);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(41, 17);
            this.lblOpis.TabIndex = 10;
            this.lblOpis.Text = "Opis:";
            // 
            // txtNabavnaCijena
            // 
            this.txtNabavnaCijena.Location = new System.Drawing.Point(225, 348);
            this.txtNabavnaCijena.Margin = new System.Windows.Forms.Padding(4);
            this.txtNabavnaCijena.Name = "txtNabavnaCijena";
            this.txtNabavnaCijena.Size = new System.Drawing.Size(333, 22);
            this.txtNabavnaCijena.TabIndex = 13;
            // 
            // lblNabavnaCijena
            // 
            this.lblNabavnaCijena.AutoSize = true;
            this.lblNabavnaCijena.Location = new System.Drawing.Point(17, 352);
            this.lblNabavnaCijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNabavnaCijena.Name = "lblNabavnaCijena";
            this.lblNabavnaCijena.Size = new System.Drawing.Size(110, 17);
            this.lblNabavnaCijena.TabIndex = 12;
            this.lblNabavnaCijena.Text = "Nabavna cijena:";
            // 
            // txtProdajnaCijena
            // 
            this.txtProdajnaCijena.Location = new System.Drawing.Point(225, 380);
            this.txtProdajnaCijena.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdajnaCijena.Name = "txtProdajnaCijena";
            this.txtProdajnaCijena.Size = new System.Drawing.Size(333, 22);
            this.txtProdajnaCijena.TabIndex = 15;
            // 
            // lblProdajnaCijena
            // 
            this.lblProdajnaCijena.AutoSize = true;
            this.lblProdajnaCijena.Location = new System.Drawing.Point(17, 384);
            this.lblProdajnaCijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdajnaCijena.Name = "lblProdajnaCijena";
            this.lblProdajnaCijena.Size = new System.Drawing.Size(110, 17);
            this.lblProdajnaCijena.TabIndex = 14;
            this.lblProdajnaCijena.Text = "Prodajna cijena:";
            // 
            // txtDonjaGranica
            // 
            this.txtDonjaGranica.Location = new System.Drawing.Point(225, 412);
            this.txtDonjaGranica.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonjaGranica.Name = "txtDonjaGranica";
            this.txtDonjaGranica.Size = new System.Drawing.Size(333, 22);
            this.txtDonjaGranica.TabIndex = 17;
            // 
            // lblDonjaGranica
            // 
            this.lblDonjaGranica.AutoSize = true;
            this.lblDonjaGranica.Location = new System.Drawing.Point(17, 416);
            this.lblDonjaGranica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonjaGranica.Name = "lblDonjaGranica";
            this.lblDonjaGranica.Size = new System.Drawing.Size(151, 17);
            this.lblDonjaGranica.TabIndex = 16;
            this.lblDonjaGranica.Text = "Donja granica količine:";
            // 
            // txtGornjaGranica
            // 
            this.txtGornjaGranica.Location = new System.Drawing.Point(225, 444);
            this.txtGornjaGranica.Margin = new System.Windows.Forms.Padding(4);
            this.txtGornjaGranica.Name = "txtGornjaGranica";
            this.txtGornjaGranica.Size = new System.Drawing.Size(333, 22);
            this.txtGornjaGranica.TabIndex = 19;
            // 
            // lblGronjaGranica
            // 
            this.lblGronjaGranica.AutoSize = true;
            this.lblGronjaGranica.Location = new System.Drawing.Point(17, 448);
            this.lblGronjaGranica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGronjaGranica.Name = "lblGronjaGranica";
            this.lblGronjaGranica.Size = new System.Drawing.Size(157, 17);
            this.lblGronjaGranica.TabIndex = 18;
            this.lblGronjaGranica.Text = "Gornja granica količine:";
            // 
            // lblVrstaArtikla
            // 
            this.lblVrstaArtikla.AutoSize = true;
            this.lblVrstaArtikla.Location = new System.Drawing.Point(17, 511);
            this.lblVrstaArtikla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVrstaArtikla.Name = "lblVrstaArtikla";
            this.lblVrstaArtikla.Size = new System.Drawing.Size(87, 17);
            this.lblVrstaArtikla.TabIndex = 20;
            this.lblVrstaArtikla.Text = "Vrsta artikla:";
            // 
            // cmbVrstaArtikla
            // 
            this.cmbVrstaArtikla.FormattingEnabled = true;
            this.cmbVrstaArtikla.Location = new System.Drawing.Point(225, 509);
            this.cmbVrstaArtikla.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVrstaArtikla.Name = "cmbVrstaArtikla";
            this.cmbVrstaArtikla.Size = new System.Drawing.Size(333, 24);
            this.cmbVrstaArtikla.TabIndex = 21;
            // 
            // btnDodajVrstuArtikla
            // 
            this.btnDodajVrstuArtikla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnDodajVrstuArtikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVrstuArtikla.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDodajVrstuArtikla.Location = new System.Drawing.Point(16, 541);
            this.btnDodajVrstuArtikla.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajVrstuArtikla.Name = "btnDodajVrstuArtikla";
            this.btnDodajVrstuArtikla.Size = new System.Drawing.Size(200, 37);
            this.btnDodajVrstuArtikla.TabIndex = 22;
            this.btnDodajVrstuArtikla.Text = "Dodaj novu vrstu artikla";
            this.btnDodajVrstuArtikla.UseVisualStyleBackColor = false;
            this.btnDodajVrstuArtikla.Click += new System.EventHandler(this.btnDodajVrstuArtikla_Click);
            // 
            // lblZaliha
            // 
            this.lblZaliha.AutoSize = true;
            this.lblZaliha.Location = new System.Drawing.Point(841, 288);
            this.lblZaliha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZaliha.Name = "lblZaliha";
            this.lblZaliha.Size = new System.Drawing.Size(126, 17);
            this.lblZaliha.TabIndex = 23;
            this.lblZaliha.Text = "Trenutno na zalihi:";
            // 
            // lblStanjeZaliha
            // 
            this.lblStanjeZaliha.AutoSize = true;
            this.lblStanjeZaliha.Location = new System.Drawing.Point(967, 325);
            this.lblStanjeZaliha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanjeZaliha.Name = "lblStanjeZaliha";
            this.lblStanjeZaliha.Size = new System.Drawing.Size(0, 17);
            this.lblStanjeZaliha.TabIndex = 24;
            // 
            // btnOcisti
            // 
            this.btnOcisti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnOcisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcisti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOcisti.Location = new System.Drawing.Point(579, 372);
            this.btnOcisti.Margin = new System.Windows.Forms.Padding(4);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(107, 37);
            this.btnOcisti.TabIndex = 25;
            this.btnOcisti.Text = "Očisti polja";
            this.btnOcisti.UseVisualStyleBackColor = false;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(116, 284);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 26;
            // 
            // txtZalihe
            // 
            this.txtZalihe.Enabled = false;
            this.txtZalihe.Location = new System.Drawing.Point(970, 283);
            this.txtZalihe.Margin = new System.Windows.Forms.Padding(4);
            this.txtZalihe.Name = "txtZalihe";
            this.txtZalihe.Size = new System.Drawing.Size(81, 22);
            this.txtZalihe.TabIndex = 27;
            // 
            // cmbDobavljac
            // 
            this.cmbDobavljac.FormattingEnabled = true;
            this.cmbDobavljac.Location = new System.Drawing.Point(225, 474);
            this.cmbDobavljac.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDobavljac.Name = "cmbDobavljac";
            this.cmbDobavljac.Size = new System.Drawing.Size(333, 24);
            this.cmbDobavljac.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 476);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Dobavljač:";
            // 
            // FormArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 591);
            this.Controls.Add(this.cmbDobavljac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZalihe);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.lblStanjeZaliha);
            this.Controls.Add(this.lblZaliha);
            this.Controls.Add(this.btnDodajVrstuArtikla);
            this.Controls.Add(this.cmbVrstaArtikla);
            this.Controls.Add(this.lblVrstaArtikla);
            this.Controls.Add(this.txtGornjaGranica);
            this.Controls.Add(this.lblGronjaGranica);
            this.Controls.Add(this.txtDonjaGranica);
            this.Controls.Add(this.lblDonjaGranica);
            this.Controls.Add(this.txtProdajnaCijena);
            this.Controls.Add(this.lblProdajnaCijena);
            this.Controls.Add(this.txtNabavnaCijena);
            this.Controls.Add(this.lblNabavnaCijena);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnPopusti);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.dgvArtikli);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormArtikli";
            this.Text = "Artikli";
            this.Load += new System.EventHandler(this.FormArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnPopusti;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtNabavnaCijena;
        private System.Windows.Forms.Label lblNabavnaCijena;
        private System.Windows.Forms.TextBox txtProdajnaCijena;
        private System.Windows.Forms.Label lblProdajnaCijena;
        private System.Windows.Forms.TextBox txtDonjaGranica;
        private System.Windows.Forms.Label lblDonjaGranica;
        private System.Windows.Forms.TextBox txtGornjaGranica;
        private System.Windows.Forms.Label lblGronjaGranica;
        private System.Windows.Forms.Label lblVrstaArtikla;
        private System.Windows.Forms.ComboBox cmbVrstaArtikla;
        private System.Windows.Forms.Button btnDodajVrstuArtikla;
        private System.Windows.Forms.Label lblZaliha;
        private System.Windows.Forms.Label lblStanjeZaliha;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtZalihe;
        private System.Windows.Forms.ComboBox cmbDobavljac;
        private System.Windows.Forms.Label label1;
    }
}