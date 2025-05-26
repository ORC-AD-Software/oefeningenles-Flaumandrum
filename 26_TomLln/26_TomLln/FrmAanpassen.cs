using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_TomLln
{
    public partial class FrmAanpassen: Form
    {
        public FrmAanpassen()
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
            foreach (string s in ontvNamen)
            {
                cmbKiesLeerling.Items.Add(s);
            }
        }

        private void FrmAanpassen_Load(object sender, EventArgs e)
        {
            VulCmb();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            // Kijk of er een leerling is geselecteerd
            if (cmbKiesLeerling.SelectedIndex != -1)
            {
                // Kijk of er tekst in de textbox staat
                if (txtNaam.Text != "")
                {
                    // haal de index van het geselecteerde item op
                    int index = cmbKiesLeerling.SelectedIndex;

                    // Zet de input van de textbox om naar een variabele
                    String naam = txtNaam.Text;

                    // Stuur dit door naar de juiste functie
                    Program.Aanpassen(index, naam);

                    // Begeleid de gebruiker
                    MessageBox.Show("Deze naam werd aangepast.", "Great succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // reset het form
                    VulCmb();
                    cmbKiesLeerling.SelectedIndex = -1;
                    cmbKiesLeerling.Text = "";
                    txtNaam.Clear();
                }
                else
                {
                    // foutmelding
                    MessageBox.Show("U gaf niets in.\nProbeer opnieuw.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                // foutmelding
                MessageBox.Show("U selecteerde geen leerling.\nProbeer opnieuw.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbKiesLeerling_SelectedIndexChanged(object sender, EventArgs e)
        {
            // heel de lijst met items op
            List<String> ontvNamen = Program.StuurLijstNamenDoor();

            // Vul het juiste gegeven in , in de textbox. Dit maakt het makkelijker voor de gebruiker.
            txtNaam.Text = ontvNamen[cmbKiesLeerling.SelectedIndex];
        }
    }
}
