using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysNotas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seepasswordcb_CheckedChanged(object sender, EventArgs e)
        {
            if (seepasswordcb.Checked)
            {
                passwordtb.UseSystemPasswordChar = false;

            }
            else
            {
                passwordtb.UseSystemPasswordChar = true;
            }
        }

        private void passwordtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
