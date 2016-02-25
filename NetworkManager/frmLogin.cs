using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adaptive_Security
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "" || txtUserId.Text.Length == 0)
            {
                MessageBox.Show("Please enter user id", "User Id Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPassword.Text == "" || txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter password", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmMain.userLogged = true;
                this.Close();
               
            }
        }
    }
}
