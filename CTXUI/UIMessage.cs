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
    public partial class UIMessage : Form
    {
        int Move;
        int Mouse_X;
        int Mouse_Y;
        public UIMessage(string message,string title)
        {
            try
            {
                InitializeComponent();
                UIHome_TITLE.Text = title;
                UIHome_MESSAGE.Text = message;
            }
            catch { }
        }

        private void UIMessage_Load(object sender, EventArgs e)
        {

        }

        private void UIHome_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UIHome_Panel6_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Move = 0;
            }
            catch { }
          
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
    }
}
