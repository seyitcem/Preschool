using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Preschool_Client.Connection;

namespace Preschool_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Resizability needs
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //
        }

        private const int cGrip = 16;      // Grip size

        protected override void OnPaint(PaintEventArgs e)   // Used for drawing resize mark.
        {
            if(WindowState != FormWindowState.Maximized)
            {
                Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
                ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            }
        }
        protected override void WndProc(ref Message m)  // It provides form resizability.
        {
            if (m.Msg == 0x84 && WindowState != FormWindowState.Maximized)
            {   
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
                else
                {
                    m.Result = (IntPtr)2;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XElement query = new XElement("GET",
                                    new XElement("SELECT",
                                        new XElement("Element", "id"),
                                        new XElement("Element", "name"),
                                        new XElement("Element", "price"),
                                        new XElement("Element", "amount")),
                                    new XElement("TABLE_NAME","Products"));
            /*
            XElement query = new XElement("UPDATE",
                                    new XElement("TABLE_NAME", "Products"),
                                    new XElement("SET",
                                        new XElement("name", "simit")),
                                    new XElement("WHERE",
                                        new XElement("id", "14")));
            */
            /*
            XElement query = new XElement("INSERT",
                                    new XElement("TABLE_NAME", "Products"),
                                    new XElement("VALUES",
                                        new XElement("name","Ahmet"),
                                        new XElement("price","19"),
                                        new XElement("amount","11")));
            */
            /*
            XElement query = new XElement("DELETE",
                                    new XElement("TABLE_NAME","Products"),
                                    new XElement("WHERE",
                                        new XElement("name","Ahmet")));
            */
            SendNewMessage(query);
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Normal_Button_Click(object sender, EventArgs e)
        {
            if(WindowState != FormWindowState.Maximized)
            {
                MaximizedBounds = Screen.FromHandle(Handle).WorkingArea; // Avoids covering of the taskbar.
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
