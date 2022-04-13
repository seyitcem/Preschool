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
using static Preschool_Client.Transform;

namespace Preschool_Client
{
    public partial class AddClass : Form
    {
        public bool is_added = false;
        public string id;
        public string name;
        public AddClass()
        {
            InitializeComponent();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClass_Button_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Class (name) VALUES ('" + ClassName_TextBox.Text + "')";
            SendNewMessage(query);

            query = "SELECT id FROM Class WHERE name = '" + ClassName_TextBox.Text + "'";
            SendNewMessage(query);
            this.id = (XElement.Parse(HexStringToString(message_received))).Descendants("RESULT").First().Element("id").Value.ToString();
            this.name = ClassName_TextBox.Text;
            this.is_added = true;
            this.Close();
        }

        private void AddClass_Load(object sender, EventArgs e)
        {

        }
    }
}
