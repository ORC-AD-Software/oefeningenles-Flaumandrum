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
    public partial class FrmTonen: Form
    {
        public FrmTonen()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTonen_Load(object sender, EventArgs e)
        {
            // vraag de gegevens op uit de business en toon de gegevens in de textbox.
            txtToon.Text = Program.ToonLijst();
        }
    }
}
