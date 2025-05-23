using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_TomLln
{
    public partial class FrmVerwijderen: Form
    {
        public FrmVerwijderen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VulCmb()
        { 
            // maak de cmb leeg
            cmbKiesLeerling.Items.Clear();

            // heel de lijst met items op
            List<String> ontvNamen = Program.StuurLijstNamenDoor();

            // voorloop de lijst en vuld de cmb
            foreach(string s in ontvNamen)
            {
                cmbKiesLeerling.Items.Add(s);
            }
        }
    }
}
