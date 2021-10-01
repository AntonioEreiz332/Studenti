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
    public partial class frmUnosNovogStudenta : Form
    {
        private List<Student> ListStudenti;
        public frmUnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            Student Student1 = new Student(textBoxIme.Text, textBoxPrezime.Text, textBoxBrojIndeksa.Text, comboBoxSmjer.Text, dateTimePickerDatumRodjenja.Value);
            ListStudenti.Add(Student1);
            this.Close();

        }
    }
}
