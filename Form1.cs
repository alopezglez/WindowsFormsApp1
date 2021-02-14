using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MnuAcerca_Click(object sender, System.EventArgs e)
        {
            frmAbout  f2 = new frmAbout();
            f2.ShowDialog();
        }

        private void mnuSalir_Click(object sender, System.EventArgs e)
        {

            MessageBoxButtons button = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("¿Está seguro de querer salir?\n\n", "Salir",button);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

        }
    }
}
