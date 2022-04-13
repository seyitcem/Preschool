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
    public partial class DeleteClass : Form
    {
        List<List<object>> classes = new List<List<object>>();
        public bool is_deleted = false;
        public string deleted_id;
        public DeleteClass()
        {
            InitializeComponent();
            string query = "SELECT * FROM Class";
            SendNewMessage(query);
            XElement message = XElement.Parse(HexStringToString(message_received));
            foreach (XElement child in message.Descendants("RESULT"))
            {
                List<object> list = new List<object>();
                list.Add(child.Element("id").Value.ToString());
                list.Add(child.Element("name").Value.ToString());
                classes.Add(list);
                Class.Rows.Add(list[0], list[1]);
            }
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

        private void DeleteClass_Button_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) count FROM Student WHERE class_id = " + Class.SelectedRows[0].Cells["id"].Value.ToString();
            SendNewMessage(query);
            XElement message = XElement.Parse(HexStringToString(message_received));
            if (Convert.ToInt32(message.Descendants("RESULT").First().Element("count").Value.ToString()) == 0)
            {
                query = "DELETE FROM Class WHERE id = ";
                this.deleted_id = Class.SelectedRows[0].Cells["id"].Value.ToString();
                query += deleted_id;
                SendNewMessage(query);
                is_deleted = true;
                this.Close();
            }
        }

        private void DeleteClass_Load(object sender, EventArgs e)
        {

        }
    }
}
