using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace Adaptive_Security
{
    public partial class frmScanConnectedDevices : Form
    {
        public frmScanConnectedDevices()
        {
            InitializeComponent();
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo procStartInfo =
                new System.Diagnostics.ProcessStartInfo("cmd", "/c " + "arp -a");

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                int strlength = result.Length;
                //Now Extract Result Into A Table ..........So Latter we will bind it to a data grid
                DataTable dt = new DataTable();
                dt.TableName = "ActiveClients";
                dt.Columns.Add("SNo");
                dt.Columns.Add("IP Address");
                dt.Columns.Add("Physical Address");
                dt.Columns.Add("Type");
                string[] word = result.Split('\n');   // If there is any client then first 3 words will be garbage.........we don't need them
                int row = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    //Each word contains IP address  physical Address Type.........Seprate them
                    word[i] = word[i].Trim();
                    if (word[i] != "" && word[i]!="\r")  // If Line Contains any active client
                    {
                        if (word[i].Substring(0, 3).ToUpper() != "INT")  // if garbage
                        {
                            string[] line = word[i].Split(' ', '\r');
                            dt.Rows.Add();
                            dt.Rows[row][0] = row + 1; ;
                            int datacount = 0; // For determining IP add/ Physical /Type
                            for (int j = 0; j < line.Length; j++)
                            {
                                if (line[j] != "")
                                {

                                    if (datacount == 0) { dt.Rows[row][1] = line[j]; }
                                    if (datacount == 1) { dt.Rows[row][2] = line[j]; }
                                    if (datacount == 2) { dt.Rows[row][3] = line[j]; }
                                    datacount = datacount + 1;
                                }
                            }
                            row = row + 1;
                        }
                    }

                }
                gvActiveClients.DataSource = dt;
                
                //Console.WriteLine(result);
            }
            catch (Exception objException)
            {
                // Log the exception
            }
        }


    }
}
