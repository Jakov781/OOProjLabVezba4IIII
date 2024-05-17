using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozaci
{
    public class Vozac
    {
        #region properties
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime VazenjeDozvoleOd { get; set; }
        public DateTime VazenjeDozvoleDo { get; set; }
        public string BrojVozackeDozvole { get; set; }
        public string MestoIzdavanja { get; set; }
        public char Pol { get; set; }
        public string PutanjaDoSlike { get; set; }
        private List<Kategorija> kate;
        public List<Kategorija> Kategorija { get { return kate; } set { kate = value; } }
        public List<Kategorija> Zabrane { get; set; }
        #endregion

        public Vozac(string ime, string prezime, DateTime datumRodjenja,
                    DateTime vazenjeDozvoleOd, DateTime vazenjeDozvoleDo,
                    string brojVD, string mesto, char pol)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.VazenjeDozvoleOd = vazenjeDozvoleOd;
            this.VazenjeDozvoleDo = vazenjeDozvoleDo;
            this.BrojVozackeDozvole = brojVD;
            this.MestoIzdavanja = mesto;
            this.Pol = pol;
            this.Kategorija = new List<Kategorija>();
            this.Zabrane = new List<Kategorija>();
        }

        public Vozac(string ime, string prezime, DateTime datumRodjenja,
                   DateTime vazenjeDozvoleOd, DateTime vazenjeDozvoleDo,
                   string brojVD, string mesto, char pol, List<Kategorija> katego, List<Kategorija> zabrane,
                   string putanjaDoSlike)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.VazenjeDozvoleOd = vazenjeDozvoleOd;
            this.VazenjeDozvoleDo = vazenjeDozvoleDo;
            this.BrojVozackeDozvole = brojVD;
            this.MestoIzdavanja = mesto;
            this.Pol = pol;
            this.Kategorija = katego;
            this.Zabrane = zabrane;
            this.PutanjaDoSlike = putanjaDoSlike;
        }

        public void DodajKategoriju(Kategorija k)
        {
            this.Kategorija.Add(k);
        }
        public void DodajZabranu(Kategorija z)
        {
            this.Zabrane.Add(z);
        }
    }
}
