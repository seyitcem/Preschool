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
    public partial class StudentInfo : Form
    {
        List<List<object>> classes = new List<List<object>>();
        DataGridViewRow dataGridViewRow;
        public bool is_changed = false;
        public string id;
        public string name;
        public string surname;
        public string tcNo;
        public string parentName;
        public string phoneNumber;
        public string class_id;
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
        public StudentInfo(DataGridViewRow dataGridViewRow)
        {
            InitializeComponent();
            classes.Add(new List<object> { "null", "null" });
            string query = "SELECT * FROM CLASS";
            SendNewMessage(query);
            XElement message = XElement.Parse(HexStringToString(message_received));
            foreach (XElement child in message.Descendants("RESULT"))
            {
                List<object> list = new List<object>();
                list.Add(child.Element("id").Value.ToString());
                list.Add(child.Element("name").Value.ToString());
                classes.Add(list);
            }
            for(int i=0;i<classes.Count; i++)
            {
                Class_ComboBox.Items.Add(classes[i][1]);
            }
            if(dataGridViewRow.Cells["class_id"].Value.ToString() != "")
            {
                query = "SELECT name FROM Class WHERE id = " + dataGridViewRow.Cells["class_id"].Value.ToString();
                SendNewMessage(query);
                message = XElement.Parse(HexStringToString(message_received));
                Class_ComboBox.SelectedItem = message.Descendants("RESULT").First().Element("name").Value.ToString();
            }
            else
            {
                Class_ComboBox.SelectedItem = "null";
            }
            this.dataGridViewRow = dataGridViewRow;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            TCNo_TextBox.Text = dataGridViewRow.Cells["TCno"].Value.ToString();
            Name_TextBox.Text = dataGridViewRow.Cells["name"].Value.ToString();
            Surname_Textbox.Text = dataGridViewRow.Cells["surname"].Value.ToString();
            ParentName_TextBox.Text = dataGridViewRow.Cells["parent_name"].Value.ToString();
            PhoneNumber_TextBox.Text = dataGridViewRow.Cells["phone_number"].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            int class_id = 0;
            string query = "UPDATE Student SET ";
            query += "name = '" + Name_TextBox.Text + "', ";
            query += "surname = '" + Surname_Textbox.Text + "', ";
            query += "parent_name = '" + ParentName_TextBox.Text + "', ";
            query += "phone_number = '" + PhoneNumber_TextBox.Text + "', ";
            query += "TCNo = '" + TCNo_TextBox.Text + "', ";

            if (Class_ComboBox.SelectedItem.ToString() != "null")
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
            query += "class_id = " + (class_id == 0 ? "null" : class_id.ToString());
            query += " WHERE id = " + dataGridViewRow.Cells["id"].Value.ToString();
            SendNewMessage(query);

            this.id = dataGridViewRow.Cells["id"].Value.ToString();
            this.name = Name_TextBox.Text;
            this.surname = Surname_Textbox.Text;
            this.tcNo = TCNo_TextBox.Text;
            this.parentName = ParentName_TextBox.Text;
            this.phoneNumber = PhoneNumber_TextBox.Text;
            this.class_id = Class_ComboBox.SelectedIndex == 0 ? "" : class_id.ToString();
            is_changed = true;
            this.Close();
        }

        private void PaymentInformation_Button_Click(object sender, EventArgs e)
        {
            PaymentInformation paymentInformation = new PaymentInformation(dataGridViewRow.Cells["id"].Value.ToString());
            paymentInformation.ShowDialog();
        }
    }
}
