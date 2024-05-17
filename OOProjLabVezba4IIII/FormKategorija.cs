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
    public partial class FormKategorija : Form
    {
        List<Kategorija> pom;
        public FormKategorija()
        {
            InitializeComponent();

        }
        public FormKategorija(ref List<Kategorija> p, string text)
        {
            InitializeComponent();
            this.Text = text;
            pom = p;
        }
        public FormKategorija(ref List<Kategorija> p, string text, List<Kategorija> Mogucnosti)
        {
            InitializeComponent();
            this.Text = text;
            cmbKategorije.Items.Clear();
            cmbKategorije.DataSource = Mogucnosti;
            
            pom = p;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbKategorije.Text))
            {
                MessageBox.Show("Ni jedno polje ne sme biti prazno");
                return;
            }
            pom.Add(new Kategorija(cmbKategorije.Text, dtpOd.Value, dtpDo.Value));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
