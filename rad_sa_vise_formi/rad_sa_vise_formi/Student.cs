using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rad_sa_vise_formi
{
    internal class Student
    {
        private string ime, prezime, brojIndeksa, smjer;

        private DateTime datumRodjenja;

        public Student() { }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }

        public override string ToString()

        {

            return ime + " " + prezime + " " +
            brojIndeksa + " " +
            datumRodjenja.ToShortDateString() + " " + smjer;

        }
    }
}
