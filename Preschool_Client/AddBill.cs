using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Preschool_Client.Connection;
using static Preschool_Client.Transform;

namespace Preschool_Client
{
    public partial class AddBill : Form
    {
        private string student_id;
        public AddBill(string student_id)
        {
            InitializeComponent();
            object[] periods = {"SEP-21","OCT-21","NOV-21","DEC-21","JAN-22","FEB-22",
                                "MAR-22","APR-22","MAY-22","JUN-22"};
            Period_ComboBox.Items.AddRange(periods);
            Date_TextBox.Text = DateTime.Today.ToString("yyyy-MM-dd");
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

        private void AddBill_Button_Click(object sender, EventArgs e)
        {
            if (Period_ComboBox.SelectedIndex == -1) return;
            string query = "INSERT INTO Bill (bill_id, date, amount, period, student_id) VALUES (";
            query += "'" + BillId_TextBox.Text + "', ";
            query += "'" + Date_TextBox.Text + "', ";
            query += Amount_Textbox.Text.Replace(',','.') + ", ";
            query += "'" + Period_ComboBox.SelectedItem.ToString() + "', ";
            query += this.student_id + ")";
            SendNewMessage(query);
        }

        private void Date_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBill_Load(object sender, EventArgs e)
        {

        }
    }
}
