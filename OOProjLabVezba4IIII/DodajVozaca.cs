using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vozaci;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace OOProjLabVezba4IIII
{
    public partial class DodajVozaca : Form
    {
        List<Kategorija> kategorije;
        List<Kategorija> zabrane;
        ListaVozaca vozaci;
        string put;
        bool dodaj;

        public DodajVozaca(ref ListaVozaca v)
        {
            InitializeComponent();
            kategorije = new List<Kategorija>();
            zabrane = new List<Kategorija>();
            vozaci = v;
            dodaj = true;
            put = null;
        }
        public DodajVozaca(ref ListaVozaca vp, Vozac v)
        {
            dodaj = false;
            vozaci = vp;
            InitializeComponent();
            txtBrojVozacke.Enabled = false;
            txtIme.Text = v.Ime;
            txtPrezime.Text = v.Prezime;
            if (v.DatumRodjenja != null)
                dtpDatumRodjenja.Value = v.DatumRodjenja;
            if (v.VazenjeDozvoleOd != null)
                dtpDozvolaVaziOd.Value = v.VazenjeDozvoleOd;
            if (v.VazenjeDozvoleDo != null)
                dtpDozvolaVaziDo.Value = v.VazenjeDozvoleDo;
            txtBrojVozacke.Text = v.BrojVozackeDozvole;
            txtMestoIzdavanja.Text = v.MestoIzdavanja;
            cmbPol.Text = v.Pol.ToString();
            kategorije = new List<Kategorija>(v.Kategorija);
            zabrane = new List<Kategorija>(v.Zabrane);
            put = v.PutanjaDoSlike;
            pcbSlika.Image = new Bitmap(put);
        }
        private void DodajVozaca_Load(object sender, EventArgs e)
        {
            Ucitaj();
        }
        public void Ucitaj()
        {
            dgvKategorije.DataSource = this.kategorije.ToList();
            dgvZabrane.DataSource = this.zabrane.ToList();

            if (dgvKategorije.RowCount > 0)
            {
                btnObrisiKategoriju.Visible = true;
            }
            else
            {
                btnObrisiKategoriju.Visible = false;
            }
            if (dgvZabrane.RowCount > 0)
            {
                btnObrisiZabranu.Visible = true;
            }
            else
            {
                btnObrisiZabranu.Visible = false;
            }
        }

        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtBrojVozacke_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            var frm = new FormKategorija(ref kategorije, "Kategorija");
            DialogResult dlg = frm.ShowDialog();

            if (dlg == DialogResult.OK)
                Ucitaj();
        }

        private void btnDodajZabranu_Click(object sender, EventArgs e)
        {
            var frm = new FormKategorija(ref zabrane, "Zabrana", kategorije);
            DialogResult dlg = frm.ShowDialog();

            if (dlg == DialogResult.OK)
            {
                foreach (var v in kategorije)
                {
                    if (zabrane[zabrane.Count - 1].Kat == v.Kat)
                    {
                        Ucitaj();
                        return;
                    }
                }
                zabrane.RemoveAt(zabrane.Count - 1);
                MessageBox.Show("Nije moguce dobiti zabranu za kategoriju koju vozac ne poseduje");
            }
        }
        private bool ProveriSvaPolja()
        {
            if (!String.IsNullOrEmpty(txtIme.Text) && !String.IsNullOrEmpty(txtPrezime.Text)
                && !String.IsNullOrEmpty(txtBrojVozacke.Text) && !String.IsNullOrEmpty(txtMestoIzdavanja.Text)
                && !String.IsNullOrEmpty(cmbPol.Text) && kategorije.Count > 0 && put!=null)
                return true;
            return false;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ProveriSvaPolja())
            {
                MessageBox.Show("Popunite sva polja");
                return;
            }
            Vozac v = new Vozac(txtIme.Text, txtPrezime.Text, dtpDatumRodjenja.Value,
                    dtpDozvolaVaziOd.Value, dtpDozvolaVaziDo.Value, txtBrojVozacke.Text,
                    txtMestoIzdavanja.Text, cmbPol.Text[0], kategorije, zabrane, put);
            this.DialogResult = DialogResult.OK;
            if (dodaj)
            {
                vozaci.Dodaj(v);
            }
            else
            {
                vozaci.Izmeni(v);
            }
            this.Close();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisiKategoriju_Click(object sender, EventArgs e)
        {
            if (dgvKategorije.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranu stavku?",
                                               "Obavestenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
                return;

            int selectedRow = dgvKategorije.SelectedRows[0].Index;
            for(int i = 0; i < zabrane.Count; i++)
            {
                if (zabrane[i].Kat == kategorije[selectedRow].Kat)
                    zabrane.RemoveAt(i);
            }
            kategorije.RemoveAt(selectedRow);
            Ucitaj();
        }

        private void btnObrisiZabranu_Click(object sender, EventArgs e)
        {
            if (dgvZabrane.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranu stavku?",
                                               "Obavestenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
                return;

            int selectedRow = dgvZabrane.SelectedRows[0].Index;
            zabrane.RemoveAt(selectedRow);

            Ucitaj();
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pcbSlika.Image = new Bitmap(open.FileName);
                put = open.FileName;
            }
        } 
    }
}
    

