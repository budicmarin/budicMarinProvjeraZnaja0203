using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace budicMarinProvjeraZnaja0203
{
    public partial class Form1 : Form
    {
        public void upis()
        {
            foreach (Osoba covjek in Program.ljudi)
            {
                richTextBoxTablica.AppendText( covjek.ToString());

            }
            richTextBoxTablica.Refresh();
        }
        public Form1()
        {
            InitializeComponent();
            upis();
        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            UnosOsobe unos = new UnosOsobe();
            unos.Show();

            upis();
        }
        
        private void richTextBoxTablica_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            richTextBoxTablica.Text = "";
            Program.ljudi.Clear();
        }
    }
}
