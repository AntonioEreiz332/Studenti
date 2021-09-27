using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radSaViseForma
{
    public partial class frmStudenti : Form
    {
        public frmStudenti()
        {
            InitializeComponent();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            frmUnosNovogStudenta student = new frmUnosNovogStudenta();
            student.Show();
        }


        string ime, prezime, brojindeksa, smjer;
        DateTime datumRodjenja;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Brojindeksa { get => brojindeksa; set => brojindeksa = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }

        public override string ToString()
        {
            return ime+" "+prezime+" "+brojindeksa + datumRodjenja.GetDateTimeFormats +" "+smjer+"\n";
        }

    }
}
