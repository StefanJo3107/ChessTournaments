using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#1a202c");
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
            btnStartServer.BackColor = Color.NavajoWhite;
            btnStopServer.BackColor = Color.Gray;

            Server.Instance.LogInfo = LogInfo;
            Server.Instance.LogTrace = LogTrace;
        }

        private void FrmServer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            Server.Instance.Start();
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
            btnStartServer.BackColor = Color.Gray;
            btnStopServer.BackColor = Color.NavajoWhite;
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            Server.Instance.Stop();
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
            btnStartServer.BackColor = Color.NavajoWhite;
            btnStopServer.BackColor = Color.Gray;
        }

        public void LogInfo(string message)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    lbLogs.Items.Add(DateTime.Now + " INFO: " + message);
                }));
            }
            catch
            {

            }
        }

        public void LogTrace(string message)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    lbLogs.Items.Add(DateTime.Now + " TRACE: " + message);
                }));
            }
            catch
            {

            }
        }

        private void FrmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Server.Instance.Stop();
        }
    }
}
