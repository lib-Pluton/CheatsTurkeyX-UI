using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using InjectionLibrary;
using JLibrary.PortableExecutable;
namespace CTXUI
{
    //                   Developer/Coder : PlutonLib SepulTura Shaggy
    public partial class UIHome : Form
    {
        int Move;
        int Mouse_X;
        int Mouse_Y;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr zeroOnly, string lpWindowName);

        public UIHome()
        {
            try
            {
                InitializeComponent();
                selectab(1);
            }
            catch { }
        }

        public void manual(int pID, Byte[] dllbytes)
        {
            InjectionMethod method = InjectionMethod.Create(InjectionMethodType.ManualMap);
            IntPtr zero = IntPtr.Zero;
            using (PortableExecutable executable = new PortableExecutable(dllbytes))
            {
                zero = method.Inject(executable, pID);
            }
            if (zero != IntPtr.Zero)
            {
                //hata1
            }
            else if (method.GetLastError() != null)
            {
                //hata2
            }
        }


        public void native(int pID, Byte[] dllbytes)
        {
            InjectionMethod method = InjectionMethod.Create(InjectionMethodType.Standard);
            IntPtr zero = IntPtr.Zero;
            using (PortableExecutable executable = new PortableExecutable(dllbytes))
            {
                zero = method.Inject(executable, pID);
            }
            if (zero != IntPtr.Zero)
            {
                //hata1
            }
            else if (method.GetLastError() != null)
            {
                //hata2
            }
        }

        void msg(string message, string title, bool power)
        {
            UIMessage frm = new UIMessage(message, title);
            frm.ShowDialog();
            {
                if (power == true)
                {
                    Application.Exit();
                }
            }
        }
        public void selectab(int key)
        {
            if (key == 1)
            {
                UIHome_CheatsButton2.BackColor = Color.FromArgb(25, 26, 28);
                UIHome_Panel8.Visible = true;
                UIHome_CheatsButton1.BackColor = Color.FromArgb(42, 43, 45);
                UIHome_NewsButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_ChatButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_OnlineButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_ConfigButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_Panel9.Visible = false;
                UIHome_Panel10.Visible = false;
                UIHome_Panel11.Visible = false;
                UIHome_Panel12.Visible = false;
                UIHome_NewsButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_ChatButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_OnlineButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_ConfigButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_tabc1.SelectedTab = UIHome_tabPage1;
            }
            if (key == 2)
            {
                UIHome_NewsButton2.BackColor = Color.FromArgb(25, 26, 28); 
                UIHome_Panel9.Visible = true;
                UIHome_NewsButton1.BackColor = Color.FromArgb(42, 43, 45);
                UIHome_CheatsButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_ChatButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_OnlineButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_ConfigButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_Panel8.Visible = false; 
                UIHome_Panel10.Visible = false;
                UIHome_Panel11.Visible = false;
                UIHome_Panel12.Visible = false;
                UIHome_CheatsButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_ChatButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_OnlineButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_ConfigButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_tabc1.SelectedTab = UIHome_tabPage2;
            }
            if (key == 3)
            {
                UIHome_ChatButton2.BackColor = Color.FromArgb(25, 26, 28);
                UIHome_Panel10.Visible = true;
                UIHome_ChatButton1.BackColor = Color.FromArgb(42, 43, 45);
                UIHome_CheatsButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_NewsButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_OnlineButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_ConfigButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_Panel8.Visible = false;
                UIHome_Panel9.Visible = false;
                UIHome_Panel11.Visible = false;
                UIHome_Panel12.Visible = false;
                UIHome_CheatsButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_NewsButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_OnlineButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_ConfigButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_tabc1.SelectedTab = UIHome_tabPage3;
            }
            if (key == 4)
            {
                UIHome_OnlineButton2.BackColor = Color.FromArgb(25, 26, 28);
                UIHome_Panel11.Visible = true;
                UIHome_OnlineButton1.BackColor = Color.FromArgb(42, 43, 45);
                UIHome_CheatsButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_NewsButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_ChatButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_ConfigButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_Panel8.Visible = false;
                UIHome_Panel9.Visible = false;
                UIHome_Panel10.Visible = false;          
                UIHome_Panel12.Visible = false; 
                UIHome_CheatsButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_NewsButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_ChatButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_ConfigButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_tabc1.SelectedTab = UIHome_tabPage4;
            }
            if (key == 5)
            {
                UIHome_ConfigButton2.BackColor = Color.FromArgb(25, 26, 28);
                UIHome_Panel12.Visible = true;
                UIHome_ConfigButton1.BackColor = Color.FromArgb(42, 43, 45);
                UIHome_CheatsButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_NewsButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_ChatButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_OnlineButton2.BackColor = Color.FromArgb(35, 36, 38);
                UIHome_Panel8.Visible = false;
                UIHome_Panel9.Visible = false;
                UIHome_Panel10.Visible = false;
                UIHome_Panel11.Visible = false;
                UIHome_CheatsButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_NewsButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_ChatButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_OnlineButton1.BackColor = Color.FromArgb(21, 22, 24);
                UIHome_tabc1.SelectedTab = UIHome_tabPage5;
            }
        }

        private void UIHome1_Load(object sender, EventArgs e)
        {
        }

        private void UIHome1_Shown(object sender, EventArgs e)
        {

        }

        private void UIHome1_FormClosing(object sender, FormClosingEventArgs e)
        { 
            Application.Exit();
        }

        private void UIHome1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
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

        private void UIHome_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UIHome_BUP_MouseEnter(object sender, EventArgs e)
        {
            UIHome_BUP.Image = Properties.Resources.updating2;
        }

        private void UIHome_BUP_MouseLeave(object sender, EventArgs e)
        {
            UIHome_BUP.Image = Properties.Resources.updating1;
        }

        private void UIHome_BSET_MouseEnter(object sender, EventArgs e)
        {
            UIHome_BSET.Image = Properties.Resources.settings2;
        }

        private void UIHome_BSET_MouseLeave(object sender, EventArgs e)
        {
            UIHome_BSET.Image = Properties.Resources.settings1;
        }

        private void UIHome_CheatsButton2_Click(object sender, EventArgs e)
        {
          selectab(1);
        }

        private void UIHome_CheatsButton1_Click(object sender, EventArgs e)
        {
           selectab(1);
        }

        private void UIHome_NewsButton2_Click(object sender, EventArgs e)
        {
          selectab(2);
        }

        private void UIHome_NewsButton1_Click(object sender, EventArgs e)
        {
            selectab(2);
        }

        private void UIHome_ChatButton2_Click(object sender, EventArgs e)
        {
            selectab(3);
        }

        private void UIHome_ChatButton1_Click(object sender, EventArgs e)
        {
           selectab(3);
        }

        private void UIHome_OnlineButton2_Click(object sender, EventArgs e)
        {
            selectab(4);
        }

        private void UIHome_OnlineButton1_Click(object sender, EventArgs e)
        {
            selectab(4);
        }

        private void UIHome_ConfigButton2_Click(object sender, EventArgs e)
        {
           selectab(5);
        }

        private void UIHome_ConfigButton1_Click(object sender, EventArgs e)
        {
           selectab(5);
        }

        private void UIHome_BUP_Click(object sender, EventArgs e)
        {
            UIAbout frm = new UIAbout();
            frm.Show();
        }

        private void UIHome_BSET_Click(object sender, EventArgs e)
        {
            UISettings frm = new UISettings();
            frm.Show();
        }

        private void UIHome_List1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void UIHome_Load_Click(object sender, EventArgs e)
        {  
        }

        private void UIHome_About_Click(object sender, EventArgs e)
        {
        }

        private void UIHome_Topic_Click(object sender, EventArgs e)
        {
        }

        private void UIHome_TITLE_Click(object sender, EventArgs e)
        {

        }
    }
}
