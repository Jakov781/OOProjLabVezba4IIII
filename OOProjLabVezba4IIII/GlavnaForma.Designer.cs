namespace OOProjLabVezba4IIII
{
    partial class GlavnaForma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblVreme = new System.Windows.Forms.Label();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.cbxSortiraj = new System.Windows.Forms.ComboBox();
            this.grpLista = new System.Windows.Forms.GroupBox();
            this.dgvListaVozaca = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.vozacBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozacBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Location = new System.Drawing.Point(30, 20);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(82, 13);
            this.lblVreme.TabIndex = 0;
            this.lblVreme.Text = "Trenutno vreme";
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(431, 18);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSortiraj.TabIndex = 1;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // cbxSortiraj
            // 
            this.cbxSortiraj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSortiraj.FormattingEnabled = true;
            this.cbxSortiraj.Items.AddRange(new object[] {
            "Broj vozacke dozvole",
            "Ime",
            "Prezime",
            "Datum rodjenja"});
            this.cbxSortiraj.Location = new System.Drawing.Point(537, 20);
            this.cbxSortiraj.Name = "cbxSortiraj";
            this.cbxSortiraj.Size = new System.Drawing.Size(121, 21);
            this.cbxSortiraj.TabIndex = 2;
            this.cbxSortiraj.SelectedIndexChanged += new System.EventHandler(this.cbxSortiraj_SelectedIndexChanged);
            // 
            // grpLista
            // 
            this.grpLista.Controls.Add(this.btnObrisi);
            this.grpLista.Controls.Add(this.btnIzmeni);
            this.grpLista.Controls.Add(this.btnDodaj);
            this.grpLista.Controls.Add(this.dgvListaVozaca);
            this.grpLista.Location = new System.Drawing.Point(33, 55);
            this.grpLista.Name = "grpLista";
            this.grpLista.Size = new System.Drawing.Size(624, 334);
            this.grpLista.TabIndex = 3;
            this.grpLista.TabStop = false;
            this.grpLista.Text = "Lista vozaca";
            // 
            // dgvListaVozaca
            // 
            this.dgvListaVozaca.AllowUserToAddRows = false;
            this.dgvListaVozaca.AllowUserToDeleteRows = false;
            this.dgvListaVozaca.AutoGenerateColumns = false;
            this.dgvListaVozaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVozaca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DatumRodjenja});
            this.dgvListaVozaca.DataSource = this.vozacBindingSource1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaVozaca.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaVozaca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvListaVozaca.Location = new System.Drawing.Point(28, 19);
            this.dgvListaVozaca.Name = "dgvListaVozaca";
            this.dgvListaVozaca.ReadOnly = true;
            this.dgvListaVozaca.Size = new System.Drawing.Size(574, 237);
            this.dgvListaVozaca.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Image = global::OOProjLabVezba4IIII.Properties.Resources.Del;
            this.btnObrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisi.Location = new System.Drawing.Point(473, 270);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(129, 47);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi vozaca";
            this.btnObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Image = global::OOProjLabVezba4IIII.Properties.Resources.change;
            this.btnIzmeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzmeni.Location = new System.Drawing.Point(186, 270);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(129, 47);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni vozaca";
            this.btnIzmeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDodaj.Image = ((System.Drawing.Image)(resources.GetObject("btnDodaj.Image")));
            this.btnDodaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodaj.Location = new System.Drawing.Point(28, 270);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(129, 47);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj vozca";
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // vozacBindingSource1
            // 
            this.vozacBindingSource1.DataSource = typeof(Vozaci.Vozac);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BrojVozackeDozvole";
            this.dataGridViewTextBoxColumn3.HeaderText = "BrojVozackeDozvole";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.DatumRodjenja.DefaultCellStyle = dataGridViewCellStyle3;
            this.DatumRodjenja.HeaderText = "DatumRodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 413);
            this.Controls.Add(this.grpLista);
            this.Controls.Add(this.cbxSortiraj);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.lblVreme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlavnaForma";
            this.Text = "Lista vozaca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlavnaForma_FormClosing);
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.grpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVozaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozacBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.ComboBox cbxSortiraj;
        private System.Windows.Forms.GroupBox grpLista;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvListaVozaca;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojVozackeDozvoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vozacBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
    }
}

