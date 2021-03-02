using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using budicMarinProvjeraZnaja0203;

namespace budicMarinProvjeraZnaja0203
{
    public partial class UnosOsobe : Form
    {
        Osoba temp = new Osoba();
            
        public UnosOsobe()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            temp.Ime = textBoxIme.Text;
            temp.Prezime = textBoxPrezime.Text;
            temp.Oib = Convert.ToInt32(textBoxOIB.Text);
            temp.DatumRod = dateTimePickerDatum.Value;

            Program.ljudi.Add(temp);
            Form1 frm = new Form1();
            frm.upis();
            this.Close();
        }

        private void UnosOsobe_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

