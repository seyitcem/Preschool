namespace Preschool_Client
{
    partial class AddStudent
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
            this.Exit_Button = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TCNo_TextBox = new System.Windows.Forms.TextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.Surname_Textbox = new System.Windows.Forms.TextBox();
            this.PhoneNumber_TextBox = new System.Windows.Forms.TextBox();
            this.ParentName_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddStudent_Button = new System.Windows.Forms.Button();
            this.Class_ComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.Image = global::Preschool_Client.Properties.Resources.exit;
            this.Exit_Button.Location = new System.Drawing.Point(377, 9);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(50, 50);
            this.Exit_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Button.TabIndex = 2;
            this.Exit_Button.TabStop = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(97, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "TC No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parent Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone Number:";
            // 
            // TCNo_TextBox
            // 
            this.TCNo_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.TCNo_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TCNo_TextBox.ForeColor = System.Drawing.Color.White;
            this.TCNo_TextBox.Location = new System.Drawing.Point(179, 72);
            this.TCNo_TextBox.Name = "TCNo_TextBox";
            this.TCNo_TextBox.Size = new System.Drawing.Size(248, 38);
            this.TCNo_TextBox.TabIndex = 8;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Name_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name_TextBox.ForeColor = System.Drawing.Color.White;
            this.Name_TextBox.Location = new System.Drawing.Point(179, 117);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(248, 38);
            this.Name_TextBox.TabIndex = 9;
            // 
            // Surname_Textbox
            // 
            this.Surname_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Surname_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Surname_Textbox.ForeColor = System.Drawing.Color.White;
            this.Surname_Textbox.Location = new System.Drawing.Point(179, 161);
            this.Surname_Textbox.Name = "Surname_Textbox";
            this.Surname_Textbox.Size = new System.Drawing.Size(248, 38);
            this.Surname_Textbox.TabIndex = 10;
            // 
            // PhoneNumber_TextBox
            // 
            this.PhoneNumber_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.PhoneNumber_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PhoneNumber_TextBox.ForeColor = System.Drawing.Color.White;
            this.PhoneNumber_TextBox.Location = new System.Drawing.Point(179, 249);
            this.PhoneNumber_TextBox.Name = "PhoneNumber_TextBox";
            this.PhoneNumber_TextBox.Size = new System.Drawing.Size(248, 38);
            this.PhoneNumber_TextBox.TabIndex = 12;
            // 
            // ParentName_TextBox
            // 
            this.ParentName_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ParentName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParentName_TextBox.ForeColor = System.Drawing.Color.White;
            this.ParentName_TextBox.Location = new System.Drawing.Point(179, 205);
            this.ParentName_TextBox.Name = "ParentName_TextBox";
            this.ParentName_TextBox.Size = new System.Drawing.Size(248, 38);
            this.ParentName_TextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 42);
            this.label6.TabIndex = 13;
            this.label6.Text = "Add Student";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AddStudent_Button
            // 
            this.AddStudent_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.AddStudent_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddStudent_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddStudent_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddStudent_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AddStudent_Button.Location = new System.Drawing.Point(19, 336);
            this.AddStudent_Button.Name = "AddStudent_Button";
            this.AddStudent_Button.Size = new System.Drawing.Size(408, 56);
            this.AddStudent_Button.TabIndex = 14;
            this.AddStudent_Button.Text = "Add Student";
            this.AddStudent_Button.UseVisualStyleBackColor = false;
            this.AddStudent_Button.Click += new System.EventHandler(this.AddStudent_Button_Click);
            // 
            // Class_ComboBox
            // 
            this.Class_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Class_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Class_ComboBox.ForeColor = System.Drawing.Color.White;
            this.Class_ComboBox.FormattingEnabled = true;
            this.Class_ComboBox.Location = new System.Drawing.Point(179, 293);
            this.Class_ComboBox.Name = "Class_ComboBox";
            this.Class_ComboBox.Size = new System.Drawing.Size(248, 37);
            this.Class_ComboBox.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(105, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Class:";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(450, 409);
            this.Controls.Add(this.Class_ComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddStudent_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhoneNumber_TextBox);
            this.Controls.Add(this.ParentName_TextBox);
            this.Controls.Add(this.Surname_Textbox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.TCNo_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Exit_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TCNo_TextBox;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.TextBox Surname_Textbox;
        private System.Windows.Forms.TextBox PhoneNumber_TextBox;
        private System.Windows.Forms.TextBox ParentName_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddStudent_Button;
        private System.Windows.Forms.ComboBox Class_ComboBox;
        private System.Windows.Forms.Label label7;
    }
}