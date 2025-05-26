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

        private void FrmVerwijderen_Load(object sender, EventArgs e)
        {
            VulCmb();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (cmbKiesLeerling.SelectedIndex != -1)
            {
                // haal de index van het geselecteerde item op
                int index = cmbKiesLeerling.SelectedIndex;

                // Stuur dit door naar de juiste functie
                 Program.Verwijderen(index);

                // Begeleid de gebruiker
                MessageBox.Show("Deze naam werd verwijderd.", "Great succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // reset het form
                VulCmb();
                cmbKiesLeerling.SelectedIndex = -1;
                cmbKiesLeerling.Text = "";

            }
            else 
            {
                // foutmelding
                MessageBox.Show("U selecteerde geen leerling.\nProbeer opnieuw.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
