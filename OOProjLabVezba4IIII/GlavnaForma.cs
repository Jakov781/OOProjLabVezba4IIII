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

namespace OOProjLabVezba4IIII
{
    public partial class GlavnaForma : Form
    {
        ListaVozaca lista;

        public GlavnaForma()
        {
            InitializeComponent();
            lista = new ListaVozaca();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            timer1.Start();
            UpdateDGV();
        }

        #region methodes
        private void UpdateDGV()
        {
            dgvListaVozaca.DataSource = lista.Lista.ToList();

            if (dgvListaVozaca.RowCount > 0)
            {
                btnObrisi.Visible = true;
                btnIzmeni.Visible = true;
            }
            else
            {
                btnObrisi.Visible = false;
                btnIzmeni.Visible = false;
            }
        }

        #endregion

        #region events
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblVreme.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            if (lista.sort == null)
            {
                MessageBox.Show("Izaberite nesto u komboboxu");
                return;
            }
            lista.sort.Invoke();
            UpdateDGV();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvListaVozaca.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranu stavku?",
                                               "Obavestenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
                return;

            int selectedRow = dgvListaVozaca.SelectedRows[0].Index;
            string brojDozvole = (string)dgvListaVozaca[2, selectedRow].Value;

            if (lista.Obrisi(brojDozvole))
            {
                MessageBox.Show("Izabrana akcija je uspesno obavljena.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Izabrana akcija nije uspesno obavljena. Pokusajte ponovo.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            UpdateDGV();
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var frm = new DodajVozaca(ref lista);
            DialogResult dlg = frm.ShowDialog();

            if (dlg == DialogResult.OK)
                UpdateDGV();
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (dgvListaVozaca.SelectedRows.Count == 0)
                return;

            int selectedRow = dgvListaVozaca.SelectedRows[0].Index;
            string brojDozvole = (string)dgvListaVozaca[2, selectedRow].Value;

            Vozac v = lista.NadjiVozaca(brojDozvole);

            var frm = new DodajVozaca(ref lista, v);
            DialogResult dlg = frm.ShowDialog();

            if (dlg == DialogResult.OK)
                UpdateDGV();
        }

        private void GlavnaForma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Izadji iz aplikacije?", "Izlaz", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
        private void cbxSortiraj_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxSortiraj.SelectedIndex) {
                case 0:
                    lista.sort = lista.SortirajPremaBrojuVozackeDozvole;
                    break;
                case 1:
                    lista.sort = lista.SortirajPremaImenu;
                    break;
                case 2:
                    lista.sort = lista.SortirajPremaPrezimenu;
                    break;
                case 3:
                    lista.sort = lista.SortirajPremaDatumuRodjenja;
                    break;
                default:
                    lista.sort = null;
                    break;
            }
        }
        #endregion

        
    }
}
