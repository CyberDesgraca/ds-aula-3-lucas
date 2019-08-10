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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbAbertura.Value < 100) 
            {
                pbAbertura.Value = pbAbertura.Value +10;

            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                Form1 f = new Form1();
                f.Show();


            }
        }

        private void pbAbertura_Click(object sender, EventArgs e)
        {

        }
    }
}
