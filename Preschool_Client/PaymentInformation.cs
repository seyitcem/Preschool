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
    public partial class PaymentInformation : Form
    {
        private string student_id;
        public PaymentInformation(string student_id)
        {
            InitializeComponent();
            string query = "SELECT name, surname FROM Student WHERE id = " + student_id;
            SendNewMessage(query);
            XElement message = XElement.Parse(HexStringToString(message_received));
            student_name.Text = message.Descendants("RESULT").First().Element("name").Value.ToString() + " ";
            student_name.Text += message.Descendants("RESULT").First().Element("surname").Value.ToString();
            query = "SELECT id, bill_id, FORMAT(date, 'dd/MM/yyyy') date, amount, period FROM Bill WHERE student_id = " + student_id;
            SendNewMessage(query);
            message = XElement.Parse(HexStringToString(message_received));
            foreach (XElement child in message.Descendants("RESULT"))
            {
                List<object> list = new List<object>();
                foreach (XElement child2 in child.Descendants())
                {
                    list.Add(child2.Value);
                }
                Bill.Rows.Add(list[0], list[1], list[2], list[3] + " TL", list[4]);
            }
            this.student_id = student_id;
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

        private void PaymentInformation_Load(object sender, EventArgs e)
        {

        }

        private void AddBill_Button_Click(object sender, EventArgs e)
        {
            AddBill addBill = new AddBill(student_id);
            addBill.ShowDialog();
        }
    }
}
