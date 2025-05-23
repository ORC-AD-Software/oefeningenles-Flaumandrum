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
    public partial class FrmStart: Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            // nieuw form maken 
            FrmToevoegen nieuwFrm = new FrmToevoegen();

            // oud form hiden 
            Hide();

            // nieuw form tonen
            nieuwFrm.ShowDialog();

            // oud form tonen
            Show();

        }

        private void btnTonen_Click(object sender, EventArgs e)
        {
            // nieuw form maken 
            FrmTonen nieuwFrm = new FrmTonen();

            // oud form hiden 
            Hide();

            // nieuw form tonen
            nieuwFrm.ShowDialog();

            // oud form tonen
            Show();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            // nieuw form maken 
            FrmAanpassen nieuwFrm = new FrmAanpassen();

            // oud form hiden 
            Hide();

            // nieuw form tonen
            nieuwFrm.ShowDialog();

            // oud form tonen
            Show();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            // nieuw form maken 
            FrmVerwijderen nieuwFrm = new FrmVerwijderen();

            // oud form hiden 
            Hide();

            // nieuw form tonen
            nieuwFrm.ShowDialog();

            // oud form tonen
            Show();
        }
    }
}
