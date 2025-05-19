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
    public partial class FrmToevoegen: Form
    {
        public FrmToevoegen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            // Kijk of er tekst in de textbox staat
            if (txtNaam.Text != "")
            {
                // Zet de input van de textbox om naar een variabele
                String naam = txtNaam.Text;

                // stuur de variabele door naar de business
                Program.Toevoegen(naam);

                // begeleiden van gebruiker
                MessageBox.Show("Deze naam werd toegevoegd.", "Great succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // reset form
                txtNaam.Clear();
            }
            else 
            {
                // foutmelding
                MessageBox.Show("U gaf niets in.\nProbeer opnieuw.", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
