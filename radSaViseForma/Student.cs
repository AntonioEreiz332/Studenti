using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radSaViseForma
{
    class Student
    {
        private string ime;
        private string prezime;
        private string brojIndeksa;
        private string smjer;
        private DateTime datumRodjenja;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }

        public Student(string ime, string prezime, string brojIndeksa, string smjer, DateTime datumRodjenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojIndeksa = brojIndeksa;
            this.smjer = smjer;
            this.datumRodjenja = datumRodjenja;
        }
        public override string ToString()
        {
            return ime + " " + prezime + " " +
            brojIndeksa + " " +
            datumRodjenja.ToShortDateString() + " " + smjer;
        }
    }
}
