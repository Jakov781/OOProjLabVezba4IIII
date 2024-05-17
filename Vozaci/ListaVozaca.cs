using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozaci
{
    public class ListaVozaca
    {
        public delegate void Sortiraj();

        public Sortiraj sort { get; set; }
        List<Vozac> lista;

        public ListaVozaca()
        {
            lista = new List<Vozac>();
            sort = null;
        }

        public Vozac this[int index]
        {
            get { return lista[index]; }
            set { lista[index] = value; }
        }
        public List<Vozac> Lista
        {
            get { return lista; }
            set { lista = value; }
        }


        #region metode

        public bool Dodaj(Vozac v)
        {
            foreach (Vozac p in lista)
            {
                if (p.BrojVozackeDozvole == v.BrojVozackeDozvole)
                {
                    return false;
                }
            }
            lista.Add(v);
            return true;
        }
        public bool Obrisi(string brojDozvole)
        {
            foreach (Vozac p in lista)
            {
                if (p.BrojVozackeDozvole == brojDozvole)
                {
                    lista.Remove(p);
                    return true;
                }
            }
            return false;
        }
        public bool Izmeni(Vozac pom)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (pom.BrojVozackeDozvole == lista[i].BrojVozackeDozvole)
                {
                    lista[i] = pom;
                    return true;
                }
            }
            return false;
        }
        public Vozac NadjiVozaca(string br)
        {
            foreach (Vozac v in lista)
            {
                if (v.BrojVozackeDozvole == br)
                    return v;
            }
            return null;
        }

        #region sortiranje

        public void SortirajPremaBrojuVozackeDozvole()
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (String.Compare(lista[i].BrojVozackeDozvole, lista[j].BrojVozackeDozvole) >= 1)
                    {
                        Vozac pom = lista[i];
                        lista[i] = lista[j];
                        lista[j] = pom;
                    }
                }
            }
        }
        public void SortirajPremaImenu()
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (String.Compare(lista[i].Ime, lista[j].Ime) >= 1)
                    {
                        Vozac pom = lista[i];
                        lista[i] = lista[j];
                        lista[j] = pom;
                    }
                }
            }
        }
        public void SortirajPremaPrezimenu()
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (String.Compare(lista[i].Prezime, lista[j].Prezime) >= 1)
                    {
                        Vozac pom = lista[i];
                        lista[i] = lista[j];
                        lista[j] = pom;
                    }
                }
            }
        }
        public void SortirajPremaDatumuRodjenja()
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i].DatumRodjenja >= lista[j].DatumRodjenja)
                    {
                        Vozac pom = lista[i];
                        lista[i] = lista[j];
                        lista[j] = pom;
                    }
                }
            }
        }
        #endregion


        #endregion

    }
}
