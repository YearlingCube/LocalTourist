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
        SearchChildForm Search = new SearchChildForm();
        ToursChildForm Tours = new ToursChildForm();
        RestaurantsChildForm Restaurants = new RestaurantsChildForm();
        HotelsChildForm Hotels = new HotelsChildForm();
        PreviousButton Plays = new PreviousButton();
        SightSeeingChildForm SightSeeingg = new SightSeeingChildForm();
        StoresChildForm Stores = new StoresChildForm();

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
            if (currentChildForm == ChildForm)
            {
                currentChildForm.Hide();
                currentChildForm = null;
                return;
            }
            else if(currentChildForm != null)
            {
                currentChildForm.Hide();
            }
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


        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Hide();
                currentChildForm = null;
            }
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        #region MenuButtons
        private void SearchMenuButton_Click(object sender, EventArgs e)
        {
            ShowChildform(Search);
        }
        private void ToursMenuButton_Click(object sender, EventArgs e)
        {
            ShowChildform(Tours);
        }
        private void RestaurantsButton_Click(object sender, EventArgs e)
        {
            ShowChildform(Restaurants);
        }
        private void HotelsButton_Click(object sender, EventArgs e)
        {
            ShowChildform(Hotels);
        }
        private void StoresButton_Click(object sender, EventArgs e)
        {
            ShowChildform(Stores);
        }
        private void PlaysButton_Click(object sender, EventArgs e)
        {
            ShowChildform(Plays);
        }
        private void SightSeeing_Click(object sender, EventArgs e)
        {
            ShowChildform(SightSeeingg);
        }
        #endregion
    }
}