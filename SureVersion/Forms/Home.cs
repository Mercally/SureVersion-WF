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

namespace SureVersion.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        #region Functions

        private int Tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle SizeGripRectangle;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (SizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            SizeGripRectangle = new Rectangle(this.ClientRectangle.Width - Tolerance, this.ClientRectangle.Height - Tolerance, Tolerance, Tolerance);

            region.Exclude(SizeGripRectangle);
            this.Panel0.Region = region;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush BlueBrush = new SolidBrush(Color.FromArgb(64, 64, 64));
            e.Graphics.FillRectangle(BlueBrush, SizeGripRectangle);
        }

        private void LblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenForm<Forms>() where Forms : Form, new()
        {
            Form Form0 = Panel1.Controls.OfType<Forms>().FirstOrDefault();

            if (Form0 == null)
            {
                Form0 = new Forms
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                Panel1.Controls.Add(Form0);
                Panel1.Tag = Form0;

                try
                {
                    Form0.Show();
                }
                catch (Exception)
                {
                    Form0.Show();
                }

                Form0.BringToFront();
            }
            else
            {
                Form0.BringToFront();

                if (Form0.WindowState == FormWindowState.Minimized)
                {
                    Form0.WindowState = FormWindowState.Normal;
                }
            }
        }

        #endregion

        private void BtnProyects_Click(object sender, EventArgs e)
        {
            OpenForm<Proyects>();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            OpenForm<Tests>();
        }

        private void BtnExec_Click(object sender, EventArgs e)
        {
            OpenForm<Exec>();
        }

        private void LblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
