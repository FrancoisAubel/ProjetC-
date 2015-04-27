using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeCommercial
{
    public partial class BackOfficeCommercial : Form
    {
        public BackOfficeCommercial()
        {
            InitializeComponent();
        }

        private void btn_GestionCli_Click(object sender, EventArgs e)
        {
            Form FormGestionProd = new GestionProduit();
            FormGestionProd.ShowDialog();
        }

        private void btn_GestionProd_Click(object sender, EventArgs e)
        {
            Form FormGestionCli = new GestionClient();
            FormGestionCli.ShowDialog();
        }

        private void btn_GestionComm_Click(object sender, EventArgs e)
        {
            Form FormGestionComm = new GestionCommande();
            FormGestionComm.ShowDialog();
        }

    }
}
