namespace OOProjLabVezba4IIII
{
    partial class DodajVozaca
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpPodaci = new System.Windows.Forms.GroupBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.pcbSlika = new System.Windows.Forms.PictureBox();
            this.cmbPol = new System.Windows.Forms.ComboBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.dtpDozvolaVaziDo = new System.Windows.Forms.DateTimePicker();
            this.dtpDozvolaVaziOd = new System.Windows.Forms.DateTimePicker();
            this.txtMestoIzdavanja = new System.Windows.Forms.TextBox();
            this.txtBrojVozacke = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpKategorija = new System.Windows.Forms.GroupBox();
            this.dgvKategorije = new System.Windows.Forms.DataGridView();
            this.katDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaziOdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaziDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnObrisiKategoriju = new System.Windows.Forms.Button();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.grpZabrane = new System.Windows.Forms.GroupBox();
            this.btnObrisiZabranu = new System.Windows.Forms.Button();
            this.btnDodajZabranu = new System.Windows.Forms.Button();
            this.dgvZabrane = new System.Windows.Forms.DataGridView();
            this.katDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaziOdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaziDoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).BeginInit();
            this.grpKategorija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).BeginInit();
            this.grpZabrane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrane)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPodaci
            // 
            this.grpPodaci.Controls.Add(this.btnDodajSliku);
            this.grpPodaci.Controls.Add(this.pcbSlika);
            this.grpPodaci.Controls.Add(this.cmbPol);
            this.grpPodaci.Controls.Add(this.dtpDatumRodjenja);
            this.grpPodaci.Controls.Add(this.dtpDozvolaVaziDo);
            this.grpPodaci.Controls.Add(this.dtpDozvolaVaziOd);
            this.grpPodaci.Controls.Add(this.txtMestoIzdavanja);
            this.grpPodaci.Controls.Add(this.txtBrojVozacke);
            this.grpPodaci.Controls.Add(this.txtPrezime);
            this.grpPodaci.Controls.Add(this.txtIme);
            this.grpPodaci.Controls.Add(this.label1);
            this.grpPodaci.Controls.Add(this.label2);
            this.grpPodaci.Controls.Add(this.label3);
            this.grpPodaci.Controls.Add(this.label4);
            this.grpPodaci.Controls.Add(this.label5);
            this.grpPodaci.Controls.Add(this.label6);
            this.grpPodaci.Controls.Add(this.label7);
            this.grpPodaci.Controls.Add(this.label8);
            this.grpPodaci.Location = new System.Drawing.Point(23, 12);
            this.grpPodaci.Name = "grpPodaci";
            this.grpPodaci.Size = new System.Drawing.Size(660, 287);
            this.grpPodaci.TabIndex = 0;
            this.grpPodaci.TabStop = false;
            this.grpPodaci.Text = "Osnovni podaci";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(485, 236);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSliku.TabIndex = 16;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // pcbSlika
            // 
            this.pcbSlika.Location = new System.Drawing.Point(417, 16);
            this.pcbSlika.Name = "pcbSlika";
            this.pcbSlika.Size = new System.Drawing.Size(213, 173);
            this.pcbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSlika.TabIndex = 16;
            this.pcbSlika.TabStop = false;
            // 
            // cmbPol
            // 
            this.cmbPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPol.FormattingEnabled = true;
            this.cmbPol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cmbPol.Location = new System.Drawing.Point(159, 238);
            this.cmbPol.Name = "cmbPol";
            this.cmbPol.Size = new System.Drawing.Size(121, 21);
            this.cmbPol.TabIndex = 15;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.CustomFormat = "dd.MM.yyyy";
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(159, 75);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumRodjenja.TabIndex = 5;
            // 
            // dtpDozvolaVaziDo
            // 
            this.dtpDozvolaVaziDo.CustomFormat = "dd.MM.yyyy";
            this.dtpDozvolaVaziDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDozvolaVaziDo.Location = new System.Drawing.Point(159, 140);
            this.dtpDozvolaVaziDo.Name = "dtpDozvolaVaziDo";
            this.dtpDozvolaVaziDo.Size = new System.Drawing.Size(121, 20);
            this.dtpDozvolaVaziDo.TabIndex = 9;
            // 
            // dtpDozvolaVaziOd
            // 
            this.dtpDozvolaVaziOd.CustomFormat = "dd.MM.yyyy";
            this.dtpDozvolaVaziOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDozvolaVaziOd.Location = new System.Drawing.Point(159, 109);
            this.dtpDozvolaVaziOd.Name = "dtpDozvolaVaziOd";
            this.dtpDozvolaVaziOd.Size = new System.Drawing.Size(121, 20);
            this.dtpDozvolaVaziOd.TabIndex = 7;
            // 
            // txtMestoIzdavanja
            // 
            this.txtMestoIzdavanja.Location = new System.Drawing.Point(159, 206);
            this.txtMestoIzdavanja.Name = "txtMestoIzdavanja";
            this.txtMestoIzdavanja.Size = new System.Drawing.Size(121, 20);
            this.txtMestoIzdavanja.TabIndex = 13;
            this.txtMestoIzdavanja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtBrojVozacke
            // 
            this.txtBrojVozacke.Location = new System.Drawing.Point(159, 169);
            this.txtBrojVozacke.Name = "txtBrojVozacke";
            this.txtBrojVozacke.Size = new System.Drawing.Size(121, 20);
            this.txtBrojVozacke.TabIndex = 11;
            this.txtBrojVozacke.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrojVozacke_KeyPress);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(159, 44);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(121, 20);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(159, 16);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(121, 20);
            this.txtIme.TabIndex = 1;
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum rodjenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vazenje dozvole od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "do";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Broj vozacke dozvole";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mesto izdavanja";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pol";
            // 
            // grpKategorija
            // 
            this.grpKategorija.Controls.Add(this.dgvKategorije);
            this.grpKategorija.Controls.Add(this.btnObrisiKategoriju);
            this.grpKategorija.Controls.Add(this.btnDodajKategoriju);
            this.grpKategorija.Location = new System.Drawing.Point(23, 305);
            this.grpKategorija.Name = "grpKategorija";
            this.grpKategorija.Size = new System.Drawing.Size(660, 184);
            this.grpKategorija.TabIndex = 1;
            this.grpKategorija.TabStop = false;
            this.grpKategorija.Text = "Kategorija";
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.AllowUserToAddRows = false;
            this.dgvKategorije.AllowUserToDeleteRows = false;
            this.dgvKategorije.AutoGenerateColumns = false;
            this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.katDataGridViewTextBoxColumn,
            this.vaziOdDataGridViewTextBoxColumn,
            this.vaziDoDataGridViewTextBoxColumn});
            this.dgvKategorije.DataSource = this.kategorijaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKategorije.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKategorije.Location = new System.Drawing.Point(27, 19);
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.ReadOnly = true;
            this.dgvKategorije.Size = new System.Drawing.Size(603, 113);
            this.dgvKategorije.TabIndex = 0;
            // 
            // katDataGridViewTextBoxColumn
            // 
            this.katDataGridViewTextBoxColumn.DataPropertyName = "Kat";
            dataGridViewCellStyle1.NullValue = null;
            this.katDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.katDataGridViewTextBoxColumn.HeaderText = "Kategorija";
            this.katDataGridViewTextBoxColumn.Name = "katDataGridViewTextBoxColumn";
            this.katDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaziOdDataGridViewTextBoxColumn
            // 
            this.vaziOdDataGridViewTextBoxColumn.DataPropertyName = "VaziOd";
            this.vaziOdDataGridViewTextBoxColumn.HeaderText = "VaziOd";
            this.vaziOdDataGridViewTextBoxColumn.Name = "vaziOdDataGridViewTextBoxColumn";
            this.vaziOdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vaziDoDataGridViewTextBoxColumn
            // 
            this.vaziDoDataGridViewTextBoxColumn.DataPropertyName = "VaziDo";
            this.vaziDoDataGridViewTextBoxColumn.HeaderText = "VaziDo";
            this.vaziDoDataGridViewTextBoxColumn.Name = "vaziDoDataGridViewTextBoxColumn";
            this.vaziDoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategorijaBindingSource
            // 
            this.kategorijaBindingSource.DataSource = typeof(Vozaci.Kategorija);
            // 
            // btnObrisiKategoriju
            // 
            this.btnObrisiKategoriju.Location = new System.Drawing.Point(555, 148);
            this.btnObrisiKategoriju.Name = "btnObrisiKategoriju";
            this.btnObrisiKategoriju.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiKategoriju.TabIndex = 2;
            this.btnObrisiKategoriju.Text = "Obrisi kategoriju";
            this.btnObrisiKategoriju.UseVisualStyleBackColor = true;
            this.btnObrisiKategoriju.Click += new System.EventHandler(this.btnObrisiKategoriju_Click);
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.Location = new System.Drawing.Point(27, 148);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(75, 23);
            this.btnDodajKategoriju.TabIndex = 1;
            this.btnDodajKategoriju.Text = "Dodaj kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = true;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // grpZabrane
            // 
            this.grpZabrane.Controls.Add(this.btnObrisiZabranu);
            this.grpZabrane.Controls.Add(this.btnDodajZabranu);
            this.grpZabrane.Controls.Add(this.dgvZabrane);
            this.grpZabrane.Location = new System.Drawing.Point(23, 495);
            this.grpZabrane.Name = "grpZabrane";
            this.grpZabrane.Size = new System.Drawing.Size(660, 161);
            this.grpZabrane.TabIndex = 2;
            this.grpZabrane.TabStop = false;
            this.grpZabrane.Text = "Zabrane";
            // 
            // btnObrisiZabranu
            // 
            this.btnObrisiZabranu.Location = new System.Drawing.Point(555, 115);
            this.btnObrisiZabranu.Name = "btnObrisiZabranu";
            this.btnObrisiZabranu.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiZabranu.TabIndex = 2;
            this.btnObrisiZabranu.Text = "Obrisi zabranu";
            this.btnObrisiZabranu.UseVisualStyleBackColor = true;
            this.btnObrisiZabranu.Click += new System.EventHandler(this.btnObrisiZabranu_Click);
            // 
            // btnDodajZabranu
            // 
            this.btnDodajZabranu.Location = new System.Drawing.Point(27, 115);
            this.btnDodajZabranu.Name = "btnDodajZabranu";
            this.btnDodajZabranu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajZabranu.TabIndex = 1;
            this.btnDodajZabranu.Text = "Dodaj zabranu";
            this.btnDodajZabranu.UseVisualStyleBackColor = true;
            this.btnDodajZabranu.Click += new System.EventHandler(this.btnDodajZabranu_Click);
            // 
            // dgvZabrane
            // 
            this.dgvZabrane.AllowUserToAddRows = false;
            this.dgvZabrane.AllowUserToDeleteRows = false;
            this.dgvZabrane.AutoGenerateColumns = false;
            this.dgvZabrane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZabrane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.katDataGridViewTextBoxColumn1,
            this.vaziOdDataGridViewTextBoxColumn1,
            this.vaziDoDataGridViewTextBoxColumn1});
            this.dgvZabrane.DataSource = this.kategorijaBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZabrane.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvZabrane.Location = new System.Drawing.Point(27, 19);
            this.dgvZabrane.Name = "dgvZabrane";
            this.dgvZabrane.ReadOnly = true;
            this.dgvZabrane.Size = new System.Drawing.Size(603, 90);
            this.dgvZabrane.TabIndex = 0;
            // 
            // katDataGridViewTextBoxColumn1
            // 
            this.katDataGridViewTextBoxColumn1.DataPropertyName = "Kat";
            this.katDataGridViewTextBoxColumn1.HeaderText = "Kategorija";
            this.katDataGridViewTextBoxColumn1.Name = "katDataGridViewTextBoxColumn1";
            this.katDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vaziOdDataGridViewTextBoxColumn1
            // 
            this.vaziOdDataGridViewTextBoxColumn1.DataPropertyName = "VaziOd";
            this.vaziOdDataGridViewTextBoxColumn1.HeaderText = "VaziOd";
            this.vaziOdDataGridViewTextBoxColumn1.Name = "vaziOdDataGridViewTextBoxColumn1";
            this.vaziOdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // vaziDoDataGridViewTextBoxColumn1
            // 
            this.vaziDoDataGridViewTextBoxColumn1.DataPropertyName = "VaziDo";
            this.vaziDoDataGridViewTextBoxColumn1.HeaderText = "VaziDo";
            this.vaziDoDataGridViewTextBoxColumn1.Name = "vaziDoDataGridViewTextBoxColumn1";
            this.vaziDoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(322, 670);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 4;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(228, 670);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Prosledi";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // DodajVozaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 705);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.grpZabrane);
            this.Controls.Add(this.grpKategorija);
            this.Controls.Add(this.grpPodaci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajVozaca";
            this.Text = "Vozac";
            this.Load += new System.EventHandler(this.DodajVozaca_Load);
            this.grpPodaci.ResumeLayout(false);
            this.grpPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).EndInit();
            this.grpKategorija.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorijaBindingSource)).EndInit();
            this.grpZabrane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabrane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPodaci;
        private System.Windows.Forms.GroupBox grpKategorija;
        private System.Windows.Forms.GroupBox grpZabrane;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMestoIzdavanja;
        private System.Windows.Forms.TextBox txtBrojVozacke;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.DateTimePicker dtpDozvolaVaziDo;
        private System.Windows.Forms.DateTimePicker dtpDozvolaVaziOd;
        private System.Windows.Forms.ComboBox cmbPol;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.PictureBox pcbSlika;
        private System.Windows.Forms.Button btnObrisiKategoriju;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.Button btnObrisiZabranu;
        private System.Windows.Forms.Button btnDodajZabranu;
        private System.Windows.Forms.DataGridView dgvZabrane;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvKategorije;
        private System.Windows.Forms.DataGridViewTextBoxColumn katDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaziOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaziDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaziOdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaziDoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource kategorijaBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}