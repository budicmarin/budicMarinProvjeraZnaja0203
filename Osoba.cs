using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinProvjeraZnaja0203
{
    class Osoba
    {
        string ime;
        string prezime;

        int oib;
        DateTime datumRod;

        public Osoba()
        {
        }

        public Osoba(string ime, string prezime, int oib, DateTime datumRod)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.oib = oib;
            this.datumRod = datumRod;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int Oib { get => oib; set => oib = value; }
        public DateTime DatumRod { get => datumRod; set => datumRod = value; }

        public override string ToString()
        {
            string osoba = "Ime :"+ime+" Prezime :"+prezime+" Datum Rođenja "+datumRod+" OIB "+oib;
            return osoba;
        }
    }
}
