using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozaci
{
    public class Kategorija
    {
        #region properties
        public string Kat { get; set; }
        public DateTime VaziOd { get; set; }
        public DateTime VaziDo { get; set; }
        #endregion
        public Kategorija(string k, DateTime od, DateTime dov)
        {
            this.Kat = k;
            this.VaziOd = od;
            this.VaziDo = dov;
        }
        public override string ToString()
        {
            return Kat;
        }
    }
}
