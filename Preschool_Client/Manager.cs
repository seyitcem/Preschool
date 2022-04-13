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
    public partial class Manager : Form
    {
        List<List<object>> classes = new List<List<object>>();
        public Manager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Resizability needs
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //
            classes.Add(new List<object> { "0", "ALL STUDENTS" });
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
            Class_ComboBox.SelectedIndex = 0;
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

        private void AddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            if (addStudent.is_added)
            {
                if (Class_ComboBox.SelectedIndex != 0)
                {
                    Class_ComboBox.SelectedIndex = 0;
                }
                else
                {
                    Student.Rows.Add(addStudent.id, addStudent.name, addStudent.surname, addStudent.tcNo,
                    addStudent.parentName, addStudent.phoneNumber, addStudent.class_id);
                }
                
            }
        }

        private void DeleteStudent_Button_Click(object sender, EventArgs e)
        {
            string id = Student.SelectedRows[0].Cells[0].Value.ToString();
            Student.Rows.Remove(Student.SelectedRows[0]);
            string query = "DELETE FROM Student WHERE id = " + id;
            SendNewMessage(query);
        }

        private void Student_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentInfo studentInfo = new StudentInfo(Student.SelectedRows[0]);
            studentInfo.ShowDialog();
            if (studentInfo.is_changed)
            {
                Student.SelectedRows[0].Cells["name"].Value = studentInfo.name;
                Student.SelectedRows[0].Cells["surname"].Value = studentInfo.surname;
                Student.SelectedRows[0].Cells["TCno"].Value = studentInfo.tcNo;
                Student.SelectedRows[0].Cells["parent_name"].Value = studentInfo.parentName;
                Student.SelectedRows[0].Cells["phone_number"].Value = studentInfo.phoneNumber;
                Student.SelectedRows[0].Cells["class_id"].Value = studentInfo.class_id;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Class_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student.Rows.Clear();
            string query = "SELECT * FROM STUDENT";
            if (Class_ComboBox.SelectedIndex != 0)
            {
                int class_id = 0;
                foreach (List<object> item in classes)
                {
                    if (item[1].ToString() == Class_ComboBox.SelectedItem.ToString())
                    {
                        class_id = Convert.ToInt32(item[0]);
                        break;
                    }
                }
                query += " WHERE class_id = " + class_id.ToString();
            }
            SendNewMessage(query);
            XElement message = XElement.Parse(HexStringToString(message_received));
            foreach (XElement child in message.Descendants("RESULT"))
            {
                List<object> list = new List<object>();
                foreach (XElement child2 in child.Descendants())
                {
                    list.Add(child2.Value);
                }
                Student.Rows.Add(list[0], list[1], list[2], list[3], list[4], list[5], list[6]);
            }
        }

        private void AddClass_Button_Click(object sender, EventArgs e)
        {
            AddClass addClasss = new AddClass();
            addClasss.ShowDialog();
            if (addClasss.is_added)
            {
                List<object> list = new List<object>();
                list.Add(addClasss.id);
                list.Add(addClasss.name);
                classes.Add(list);
                Class_ComboBox.Items.Add(list[1]);
            }
        }

        private void DeleteClass_Button_Click(object sender, EventArgs e)
        {
            DeleteClass deleteClass = new DeleteClass();
            deleteClass.ShowDialog();
            if (deleteClass.is_deleted)
            {
                classes = new List<List<object>>();
                classes.Add(new List<object> { "0", "ALL STUDENTS" });
                Class_ComboBox.Items.Clear();
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
                Class_ComboBox.SelectedIndex = 0;
            }
        }

        private void UpdateClass_Button_Click(object sender, EventArgs e)
        {

        }

        private void Student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddEmployee_Button_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
        }
    }
}
