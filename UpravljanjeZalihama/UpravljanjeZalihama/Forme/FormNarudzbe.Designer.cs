namespace UpravljanjeZalihama.Forme
{
    partial class FormNarudzbe
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
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtIDDokument = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblStanjeZaliha = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtIDRadnik = new System.Windows.Forms.TextBox();
            this.txtIDDObavljac = new System.Windows.Forms.TextBox();
            this.rbUTijeku = new System.Windows.Forms.RadioButton();
            this.rbZaprimljene = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbrojdok = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzbe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Location = new System.Drawing.Point(13, 55);
            this.dgvNarudzbe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.RowHeadersWidth = 51;
            this.dgvNarudzbe.Size = new System.Drawing.Size(1035, 269);
            this.dgvNarudzbe.TabIndex = 66;
            this.dgvNarudzbe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbe_CellClick);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPretrazi.Location = new System.Drawing.Point(941, 10);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(107, 37);
            this.btnPretrazi.TabIndex = 81;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(776, 19);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(156, 22);
            this.txtPretrazi.TabIndex = 80;
            // 
            // txtDatum
            // 
            this.txtDatum.Enabled = false;
            this.txtDatum.Location = new System.Drawing.Point(717, 505);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(335, 22);
            this.txtDatum.TabIndex = 107;
            this.txtDatum.Visible = false;
            // 
            // txtIDDokument
            // 
            this.txtIDDokument.Enabled = false;
            this.txtIDDokument.Location = new System.Drawing.Point(717, 449);
            this.txtIDDokument.Name = "txtIDDokument";
            this.txtIDDokument.Size = new System.Drawing.Size(38, 22);
            this.txtIDDokument.TabIndex = 104;
            this.txtIDDokument.UseSystemPasswordChar = true;
            this.txtIDDokument.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(717, 477);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(38, 22);
            this.txtID.TabIndex = 101;
            this.txtID.Visible = false;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(717, 420);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(333, 22);
            this.txtKolicina.TabIndex = 97;
            this.txtKolicina.Visible = false;
            // 
            // lblStanjeZaliha
            // 
            this.lblStanjeZaliha.AutoSize = true;
            this.lblStanjeZaliha.Location = new System.Drawing.Point(970, 343);
            this.lblStanjeZaliha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanjeZaliha.Name = "lblStanjeZaliha";
            this.lblStanjeZaliha.Size = new System.Drawing.Size(0, 17);
            this.lblStanjeZaliha.TabIndex = 96;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Green;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSpremi.Location = new System.Drawing.Point(825, 332);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(225, 37);
            this.btnSpremi.TabIndex = 92;
            this.btnSpremi.Text = "Narudzba zaprimljena";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtIDRadnik
            // 
            this.txtIDRadnik.Enabled = false;
            this.txtIDRadnik.Location = new System.Drawing.Point(770, 449);
            this.txtIDRadnik.Name = "txtIDRadnik";
            this.txtIDRadnik.Size = new System.Drawing.Size(57, 22);
            this.txtIDRadnik.TabIndex = 112;
            this.txtIDRadnik.Visible = false;
            // 
            // txtIDDObavljac
            // 
            this.txtIDDObavljac.Enabled = false;
            this.txtIDDObavljac.Location = new System.Drawing.Point(770, 477);
            this.txtIDDObavljac.Name = "txtIDDObavljac";
            this.txtIDDObavljac.Size = new System.Drawing.Size(57, 22);
            this.txtIDDObavljac.TabIndex = 113;
            this.txtIDDObavljac.Visible = false;
            // 
            // rbUTijeku
            // 
            this.rbUTijeku.AutoSize = true;
            this.rbUTijeku.Checked = true;
            this.rbUTijeku.Location = new System.Drawing.Point(13, 332);
            this.rbUTijeku.Name = "rbUTijeku";
            this.rbUTijeku.Size = new System.Drawing.Size(140, 21);
            this.rbUTijeku.TabIndex = 114;
            this.rbUTijeku.TabStop = true;
            this.rbUTijeku.Text = "Narudzbe u tijeku";
            this.rbUTijeku.UseVisualStyleBackColor = true;
            this.rbUTijeku.CheckedChanged += new System.EventHandler(this.rbUTijeku_CheckedChanged);
            // 
            // rbZaprimljene
            // 
            this.rbZaprimljene.AutoSize = true;
            this.rbZaprimljene.Location = new System.Drawing.Point(159, 331);
            this.rbZaprimljene.Name = "rbZaprimljene";
            this.rbZaprimljene.Size = new System.Drawing.Size(167, 21);
            this.rbZaprimljene.TabIndex = 115;
            this.rbZaprimljene.Text = "Zaprimljene narudzbe";
            this.rbZaprimljene.UseVisualStyleBackColor = true;
            this.rbZaprimljene.CheckedChanged += new System.EventHandler(this.rbZaprimljene_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(13, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 37);
            this.button1.TabIndex = 116;
            this.button1.Text = "Ručni unos primke";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(202, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 37);
            this.button2.TabIndex = 117;
            this.button2.Text = "Ručni unos narudžbe";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbrojdok
            // 
            this.txtbrojdok.Enabled = false;
            this.txtbrojdok.Location = new System.Drawing.Point(717, 340);
            this.txtbrojdok.Name = "txtbrojdok";
            this.txtbrojdok.Size = new System.Drawing.Size(97, 22);
            this.txtbrojdok.TabIndex = 118;
            this.txtbrojdok.Visible = false;
            // 
            // FormNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 564);
            this.Controls.Add(this.txtbrojdok);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbZaprimljene);
            this.Controls.Add(this.rbUTijeku);
            this.Controls.Add(this.txtIDDObavljac);
            this.Controls.Add(this.txtIDRadnik);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtIDDokument);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblStanjeZaliha);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.dgvNarudzbe);
            this.Name = "FormNarudzbe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narudzbe";
            this.Load += new System.EventHandler(this.FormNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtIDDokument;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblStanjeZaliha;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtIDRadnik;
        private System.Windows.Forms.TextBox txtIDDObavljac;
        private System.Windows.Forms.RadioButton rbUTijeku;
        private System.Windows.Forms.RadioButton rbZaprimljene;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbrojdok;
    }
}