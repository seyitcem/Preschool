
namespace Preschool_Client
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Top_Right_Panel = new System.Windows.Forms.Panel();
            this.Minimize_Button = new System.Windows.Forms.PictureBox();
            this.Maximize_Normal_Button = new System.Windows.Forms.PictureBox();
            this.Exit_Button = new System.Windows.Forms.PictureBox();
            this.AddStudent_Button = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteStudent_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Class_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddClass_Button = new System.Windows.Forms.Button();
            this.DeleteClass_Button = new System.Windows.Forms.Button();
            this.UpdateClass_Button = new System.Windows.Forms.Button();
            this.AddEmployee_Button = new System.Windows.Forms.Button();
            this.Top_Right_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize_Normal_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_Right_Panel
            // 
            this.Top_Right_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Top_Right_Panel.Controls.Add(this.Minimize_Button);
            this.Top_Right_Panel.Controls.Add(this.Maximize_Normal_Button);
            this.Top_Right_Panel.Controls.Add(this.Exit_Button);
            this.Top_Right_Panel.Location = new System.Drawing.Point(704, 12);
            this.Top_Right_Panel.Name = "Top_Right_Panel";
            this.Top_Right_Panel.Size = new System.Drawing.Size(171, 58);
            this.Top_Right_Panel.TabIndex = 4;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_Button.Image")));
            this.Minimize_Button.Location = new System.Drawing.Point(3, 3);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(50, 50);
            this.Minimize_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize_Button.TabIndex = 2;
            this.Minimize_Button.TabStop = false;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Maximize_Normal_Button
            // 
            this.Maximize_Normal_Button.Image = ((System.Drawing.Image)(resources.GetObject("Maximize_Normal_Button.Image")));
            this.Maximize_Normal_Button.Location = new System.Drawing.Point(59, 3);
            this.Maximize_Normal_Button.Name = "Maximize_Normal_Button";
            this.Maximize_Normal_Button.Size = new System.Drawing.Size(50, 50);
            this.Maximize_Normal_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximize_Normal_Button.TabIndex = 3;
            this.Maximize_Normal_Button.TabStop = false;
            this.Maximize_Normal_Button.Click += new System.EventHandler(this.Maximize_Normal_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Image = global::Preschool_Client.Properties.Resources.exit;
            this.Exit_Button.Location = new System.Drawing.Point(115, 3);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(50, 50);
            this.Exit_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Button.TabIndex = 1;
            this.Exit_Button.TabStop = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // AddStudent_Button
            // 
            this.AddStudent_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddStudent_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.AddStudent_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddStudent_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddStudent_Button.Location = new System.Drawing.Point(667, 77);
            this.AddStudent_Button.Name = "AddStudent_Button";
            this.AddStudent_Button.Size = new System.Drawing.Size(208, 86);
            this.AddStudent_Button.TabIndex = 5;
            this.AddStudent_Button.Text = "Add Student";
            this.AddStudent_Button.UseVisualStyleBackColor = false;
            this.AddStudent_Button.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // Student
            // 
            this.Student.AllowUserToAddRows = false;
            this.Student.AllowUserToDeleteRows = false;
            this.Student.AllowUserToResizeColumns = false;
            this.Student.AllowUserToResizeRows = false;
            this.Student.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Student.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Student.ColumnHeadersHeight = 35;
            this.Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.TCno,
            this.parent_name,
            this.phone_number,
            this.class_id});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Student.DefaultCellStyle = dataGridViewCellStyle2;
            this.Student.EnableHeadersVisualStyles = false;
            this.Student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Student.Location = new System.Drawing.Point(31, 77);
            this.Student.MultiSelect = false;
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            this.Student.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Student.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Student.RowHeadersVisible = false;
            this.Student.RowHeadersWidth = 30;
            this.Student.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Student.RowTemplate.Height = 30;
            this.Student.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Student.Size = new System.Drawing.Size(528, 397);
            this.Student.TabIndex = 18;
            this.Student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Student_CellContentClick);
            this.Student.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Student_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 200;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 200;
            // 
            // TCno
            // 
            this.TCno.HeaderText = "TC No";
            this.TCno.MinimumWidth = 6;
            this.TCno.Name = "TCno";
            this.TCno.ReadOnly = true;
            this.TCno.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TCno.Visible = false;
            this.TCno.Width = 110;
            // 
            // parent_name
            // 
            this.parent_name.HeaderText = "parent_name";
            this.parent_name.MinimumWidth = 6;
            this.parent_name.Name = "parent_name";
            this.parent_name.ReadOnly = true;
            this.parent_name.Visible = false;
            this.parent_name.Width = 125;
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "phone_number";
            this.phone_number.MinimumWidth = 6;
            this.phone_number.Name = "phone_number";
            this.phone_number.ReadOnly = true;
            this.phone_number.Visible = false;
            this.phone_number.Width = 125;
            // 
            // class_id
            // 
            this.class_id.HeaderText = "class_id";
            this.class_id.MinimumWidth = 6;
            this.class_id.Name = "class_id";
            this.class_id.ReadOnly = true;
            this.class_id.Visible = false;
            this.class_id.Width = 125;
            // 
            // DeleteStudent_Button
            // 
            this.DeleteStudent_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteStudent_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.DeleteStudent_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteStudent_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteStudent_Button.Location = new System.Drawing.Point(667, 169);
            this.DeleteStudent_Button.Name = "DeleteStudent_Button";
            this.DeleteStudent_Button.Size = new System.Drawing.Size(208, 86);
            this.DeleteStudent_Button.TabIndex = 19;
            this.DeleteStudent_Button.Text = "Delete Student";
            this.DeleteStudent_Button.UseVisualStyleBackColor = false;
            this.DeleteStudent_Button.Click += new System.EventHandler(this.DeleteStudent_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(547, 42);
            this.label6.TabIndex = 27;
            this.label6.Text = "Preschool Management System";
            // 
            // Class_ComboBox
            // 
            this.Class_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Class_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Class_ComboBox.ForeColor = System.Drawing.Color.White;
            this.Class_ComboBox.FormattingEnabled = true;
            this.Class_ComboBox.Location = new System.Drawing.Point(260, 488);
            this.Class_ComboBox.Name = "Class_ComboBox";
            this.Class_ComboBox.Size = new System.Drawing.Size(242, 37);
            this.Class_ComboBox.TabIndex = 29;
            this.Class_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Class_ComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Selected Students From:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddClass_Button
            // 
            this.AddClass_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddClass_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.AddClass_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddClass_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddClass_Button.Location = new System.Drawing.Point(667, 261);
            this.AddClass_Button.Name = "AddClass_Button";
            this.AddClass_Button.Size = new System.Drawing.Size(208, 86);
            this.AddClass_Button.TabIndex = 31;
            this.AddClass_Button.Text = "Add Class";
            this.AddClass_Button.UseVisualStyleBackColor = false;
            this.AddClass_Button.Click += new System.EventHandler(this.AddClass_Button_Click);
            // 
            // DeleteClass_Button
            // 
            this.DeleteClass_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteClass_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.DeleteClass_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteClass_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteClass_Button.Location = new System.Drawing.Point(667, 353);
            this.DeleteClass_Button.Name = "DeleteClass_Button";
            this.DeleteClass_Button.Size = new System.Drawing.Size(208, 86);
            this.DeleteClass_Button.TabIndex = 32;
            this.DeleteClass_Button.Text = "Delete Class";
            this.DeleteClass_Button.UseVisualStyleBackColor = false;
            this.DeleteClass_Button.Click += new System.EventHandler(this.DeleteClass_Button_Click);
            // 
            // UpdateClass_Button
            // 
            this.UpdateClass_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateClass_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.UpdateClass_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateClass_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateClass_Button.Location = new System.Drawing.Point(667, 445);
            this.UpdateClass_Button.Name = "UpdateClass_Button";
            this.UpdateClass_Button.Size = new System.Drawing.Size(208, 86);
            this.UpdateClass_Button.TabIndex = 33;
            this.UpdateClass_Button.Text = "Update Class";
            this.UpdateClass_Button.UseVisualStyleBackColor = false;
            this.UpdateClass_Button.Click += new System.EventHandler(this.UpdateClass_Button_Click);
            // 
            // AddEmployee_Button
            // 
            this.AddEmployee_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployee_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.AddEmployee_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddEmployee_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddEmployee_Button.Location = new System.Drawing.Point(667, 537);
            this.AddEmployee_Button.Name = "AddEmployee_Button";
            this.AddEmployee_Button.Size = new System.Drawing.Size(208, 86);
            this.AddEmployee_Button.TabIndex = 34;
            this.AddEmployee_Button.Text = "Add Employee";
            this.AddEmployee_Button.UseVisualStyleBackColor = false;
            this.AddEmployee_Button.Click += new System.EventHandler(this.AddEmployee_Button_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(887, 661);
            this.Controls.Add(this.AddEmployee_Button);
            this.Controls.Add(this.UpdateClass_Button);
            this.Controls.Add(this.DeleteClass_Button);
            this.Controls.Add(this.AddClass_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Class_ComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeleteStudent_Button);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.AddStudent_Button);
            this.Controls.Add(this.Top_Right_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Top_Right_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize_Normal_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Exit_Button;
        private System.Windows.Forms.PictureBox Minimize_Button;
        private System.Windows.Forms.PictureBox Maximize_Normal_Button;
        private System.Windows.Forms.Panel Top_Right_Panel;
        private System.Windows.Forms.Button AddStudent_Button;
        private System.Windows.Forms.DataGridView Student;
        private System.Windows.Forms.Button DeleteStudent_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCno;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Class_ComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddClass_Button;
        private System.Windows.Forms.Button DeleteClass_Button;
        private System.Windows.Forms.Button UpdateClass_Button;
        private System.Windows.Forms.Button AddEmployee_Button;
    }
}

