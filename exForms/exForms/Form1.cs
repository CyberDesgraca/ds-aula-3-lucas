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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "etechoracio" && txtSenha.Text == "123456")
            {
                MessageBox.Show("Login corretos");
                this.Visible = false;
                frmPrincipal f = new frmPrincipal();
                f.Show();


            }
            else
            {
                MessageBox.Show("Senha ou Login incorretos");
            }
        }

        private void lblAcesso_Click(object sender, EventArgs e)
        {

        }
    }
}
