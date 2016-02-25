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
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;
        public static bool userLogged = false;
        public static string LoginId = null;
        public static DataSet dsUserLoggedInInfo = null;

        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin LoginForm = new frmLogin();
            dsUserLoggedInInfo = new DataSet();
            LoginForm.ShowDialog();
            if (userLogged == true)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.Close();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuScanNetworks_Click(object sender, EventArgs e)
        {
            frmScanConnectedDevices scanform = new frmScanConnectedDevices();
            scanform.Show();
        }
    }
}
