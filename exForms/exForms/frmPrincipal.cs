using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exForms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void calcularMediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedia frmMedia = new frmMedia();
            frmMedia.MdiParent = this;
            frmMedia.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja sair do sistem ?", "messagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("obrigado por utilizar nosso sistema",
                    "!!! OBRIGADO !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Exit();
            }


        }
    }
}
