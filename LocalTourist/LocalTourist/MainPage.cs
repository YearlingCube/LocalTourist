using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalTourist
{
    public partial class HomePage : Form
    {
        Form currentChildForm;
        public HomePage()
        {
            InitializeComponent();
        }

        private void Mouse_Hover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(156, 3, 59);
        }
        private void Mouse_Leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(11,7,17);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ShowChildform(Form ChildForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm = null;
            } else
            {
                currentChildForm = ChildForm;
                ChildForm.TopLevel = false;
                ChildForm.FormBorderStyle = FormBorderStyle.None;
                ChildForm.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(ChildForm);
                MainPanel.Tag = ChildForm;
                ChildForm.Size = MainPanel.Size;
                ChildForm.BringToFront();
                ChildForm.Show();
            }
        }

        private void SearchMenuButton_Click(object sender, EventArgs e)
        {
            SearchChildForm Search = new SearchChildForm();
            ShowChildform(Search);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            currentChildForm = null;
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            XButton.BackgroundImage = System.Drawing.Image.FromFile("C:/Users\\matho347\\source\\repos\\LocalTourist\\LocalTourist\\Resources\\CancelIcon.png");
            MinMaxButton.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\matho347\\source\\repos\\LocalTourist\\LocalTourist\\Resources\\RectangleIcon.png");
        }
        private void ToursMenuButton_Click(object sender, EventArgs e)
        {
            SearchChildForm Search = new SearchChildForm();
            ShowChildform(Search);
        }

        private void MinMaxButton_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }else if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        int Mx;
        int My;
        int Sw;
        int Sh;

        bool mov;

        void SizerMouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }

        void SizerMouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                Width = MousePosition.X - Mx + Sw;
                Height = MousePosition.Y - My + Sh;
            }
        }

        void SizerMouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
        }
    }
}
