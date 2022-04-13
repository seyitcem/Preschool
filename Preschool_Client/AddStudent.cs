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
    public partial class AddStudent : Form
    {
        List<List<object>> classes = new List<List<object>>();
        public bool is_added = false;
        public string id;
        public string name;
        public string surname;
        public string tcNo;
        public string parentName;
        public string phoneNumber;
        public string class_id;
        public AddStudent()
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

        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            if (TCNo_TextBox.Text == "" || Name_TextBox.Text == "" || Surname_Textbox.Text == ""
                || ParentName_TextBox.Text == "" || PhoneNumber_TextBox.Text == "") return;
            int class_id = 0;
            if(Class_ComboBox.SelectedItem.ToString() != "null")
            {
                foreach (List<object> item in classes)
                {
                    if (item[1].ToString() == Class_ComboBox.SelectedItem.ToString())
                    {
                        class_id = Convert.ToInt32(item[0]);
                        break;
                    }
                }
            }

            string query = "INSERT INTO Student (TCNo,name,surname,parent_name,phone_number,class_id) VALUES (";
            query += "'" + TCNo_TextBox.Text + "', ";
            query += "'" + Name_TextBox.Text + "', ";
            query += "'" + Surname_Textbox.Text + "', ";
            query += "'" + ParentName_TextBox.Text + "', ";
            query += "'" + PhoneNumber_TextBox.Text + "', ";
            query += Class_ComboBox.SelectedIndex == 0 ? "null" : class_id.ToString();
            query += ")";
            SendNewMessage(query);

            query = "SELECT id FROM Student WHERE TCNo = '" + TCNo_TextBox.Text + "'";
            SendNewMessage(query);
            XElement message = XElement.Parse(HexStringToString(message_received));
            
            this.id = message.Descendants("RESULT").First().Element("id").Value.ToString();
            this.name = Name_TextBox.Text;
            this.surname = Surname_Textbox.Text;
            this.tcNo = TCNo_TextBox.Text;
            this.parentName = ParentName_TextBox.Text;
            this.phoneNumber = PhoneNumber_TextBox.Text;
            this.class_id = Class_ComboBox.SelectedIndex == 0 ? "" : class_id.ToString();
            is_added = true;
            this.Close();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CLASS";
            SendNewMessage(query);
            XElement message = XElement.Parse(HexStringToString(message_received));
            classes.Add(new List<object> { "null", "null" });
            foreach (XElement child in message.Descendants("RESULT"))
            {
                List<object> list = new List<object>();
                list.Add(child.Element("id").Value.ToString());
                list.Add(child.Element("name").Value.ToString());
                classes.Add(list);
            }
            for (int i = 0; i < classes.Count; i++)
            {
                Class_ComboBox.Items.Add(classes[i][1]);
            }
            Class_ComboBox.SelectedIndex = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
