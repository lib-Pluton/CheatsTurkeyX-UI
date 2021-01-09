using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTXUI
{
    public partial class UIAbout : Form
    {
        int Move;
        int Mouse_X;
        int Mouse_Y;
        public UIAbout()
        {
            try
            {
                InitializeComponent();
                selecttab(1);
            }
            catch { }           
        }

        void selecttab(int key)
        {
            if (key == 1)
            {
                UIHome_UpButton2.BackColor = Color.FromArgb(25, 26, 28);
                UIHome_AboutButton2.BackColor = Color.FromArgb(35, 36, 38); 
                UIHome_Panel8.Visible = true;
                UIHome_Panel9.Visible = false;
                UIHome_tabc1.SelectedTab = UIHome_tabPage1;
            }

            if (key == 2)
            {
                UIHome_AboutButton2.BackColor = Color.FromArgb(25, 26, 28);
                UIHome_UpButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_Panel9.Visible = true;
                UIHome_Panel8.Visible = false;
                UIHome_tabc1.SelectedTab = UIHome_tabPage2;
            }
        }

        private void UIAbout_Load(object sender, EventArgs e)
        {
            UIHome_Combo1.SelectedIndex = 0;
        }

        private void UIHome_Panel6_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                Move = 1;
                Mouse_X = e.X;
                Mouse_Y = e.Y;
            }
            catch { }

        }

        private void UIHome_Panel6_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Move = 0;
            }
            catch { }
  
        }

        private void UIHome_Panel6_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (Move == 1)
                {
                    this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
                }
            }
            catch { }

        }

        private void UIHome_AboutButton2_Click(object sender, EventArgs e)
        {
            selecttab(2);
        }

        private void UIHome_UpButton2_Click(object sender, EventArgs e)
        {
            selecttab(1);
        }

        private void UIHome_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UIHome_Button1_Click(object sender, EventArgs e)
        {
        }
    }
}
