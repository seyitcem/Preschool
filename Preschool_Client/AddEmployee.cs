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
    public partial class AddEmployee : Form
    {
        List<List<object>> classes = new List<List<object>>();
        public AddEmployee()
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

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            object[] employeeTypes = { "Manager", "Teacher", "Worker" };
            EmployeeType_ComboBox.Items.AddRange(employeeTypes);
            EmployeeType_ComboBox.SelectedIndex = 0;
            object[] teacherTypes = { "Full-Time", "Part-Time" };
            TeacherType_ComboBox.Items.AddRange(teacherTypes);
            TeacherType_ComboBox.Enabled = false;
            Field_TextBox.Enabled = false;
        }

        private void EmployeeType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmployeeType_ComboBox.SelectedIndex == 1)
            {
                TeacherType_ComboBox.Enabled = true;
            }
            else
            {
                TeacherType_ComboBox.Enabled = false;
                TeacherType_ComboBox.SelectedIndex = -1;
                Field_TextBox.Enabled = false;
                Class_ComboBox.Enabled = false;
                Class_ComboBox.SelectedIndex = -1;
                Field_TextBox.Text = "";
            }
        }

        private void TeacherType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TeacherType_ComboBox.SelectedIndex == 1)
            {
                Field_TextBox.Enabled = true;
                Class_ComboBox.Enabled = false;
                Class_ComboBox.SelectedIndex = -1;
                Field_TextBox.Text = "";
            }
            else if (TeacherType_ComboBox.SelectedIndex == 0)
            {
                Field_TextBox.Enabled = false;
                Class_ComboBox.Enabled = true;
                Class_ComboBox.SelectedIndex = -1;
                Field_TextBox.Text = "";
                Class_ComboBox.Items.Clear();
                classes = new List<List<object>>();
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
                for (int i = 0; i < classes.Count; i++)
                {
                    Class_ComboBox.Items.Add(classes[i][1]);
                }
            }
            else
            {
                Field_TextBox.Enabled = false;
                Class_ComboBox.Enabled = false;
                Class_ComboBox.SelectedIndex = -1;
                Field_TextBox.Text = "";
            }
        }

        private void AddEmployee_Button_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Employee (name, surname, TCNo, salary, phone_number) VALUES (";
            query += "'" + Name_TextBox.Text + "', ";
            query += "'" + Surname_Textbox.Text + "', ";
            query += "'" + TCNo_TextBox.Text + "', ";
            query += Salary_TextBox.Text.Replace(',', '.') + ", ";
            query += "'" + PhoneNumber_TextBox.Text + "'";
            query += ')';
            SendNewMessage(query);
            query = "SELECT id FROM Employee WHERE TCNo = " + TCNo_TextBox.Text;
            SendNewMessage(query);
            string employee_id = (XElement.Parse(HexStringToString(message_received))).Descendants("id").First().Value.ToString();
            if (EmployeeType_ComboBox.SelectedIndex == 2)
            {
                query = "INSERT INTO Worker (employee_id) VALUES (" + employee_id + ")";
                SendNewMessage(query);
            }
            else if (EmployeeType_ComboBox.SelectedIndex == 0)
            {
                query = "INSERT INTO Manager (employee_id) VALUES (" + employee_id + ")";
                SendNewMessage(query);
            }
            else if (EmployeeType_ComboBox.SelectedIndex == 1)
            {
                if (TeacherType_ComboBox.SelectedIndex == 0)
                {
                    int class_id = 0;
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
                    query = "INSERT INTO Teacher (employee_id, full_time_flag, class_id) VALUES (";
                    query += employee_id + ", ";
                    query += "1, ";
                    query += class_id.ToString() + ")";
                    SendNewMessage(query);
                }
                else if (TeacherType_ComboBox.SelectedIndex == 1)
                {
                    query = "INSERT INTO Teacher (employee_id, part_time_flag, field) VALUES (";
                    query += employee_id + ", ";
                    query += "1, ";
                    query += "'" + Field_TextBox.Text + "')";
                    SendNewMessage(query);
                }
            }
        }
    }
}
