namespace Preschool_Client
{
    partial class AddBill
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
            this.Period_ComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddBill_Button = new System.Windows.Forms.Button();
            this.Amount_Textbox = new System.Windows.Forms.TextBox();
            this.Date_TextBox = new System.Windows.Forms.TextBox();
            this.BillId_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.Image = global::Preschool_Client.Properties.Resources.exit;
            this.Exit_Button.Location = new System.Drawing.Point(377, 4);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(50, 50);
            this.Exit_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Button.TabIndex = 4;
            this.Exit_Button.TabStop = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Period_ComboBox
            // 
            this.Period_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Period_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Period_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Period_ComboBox.ForeColor = System.Drawing.Color.White;
            this.Period_ComboBox.FormattingEnabled = true;
            this.Period_ComboBox.Location = new System.Drawing.Point(133, 214);
            this.Period_ComboBox.Name = "Period_ComboBox";
            this.Period_ComboBox.Size = new System.Drawing.Size(294, 37);
            this.Period_ComboBox.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(44, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Period:";
            // 
            // AddBill_Button
            // 
            this.AddBill_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.AddBill_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBill_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBill_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddBill_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AddBill_Button.Location = new System.Drawing.Point(19, 257);
            this.AddBill_Button.Name = "AddBill_Button";
            this.AddBill_Button.Size = new System.Drawing.Size(408, 56);
            this.AddBill_Button.TabIndex = 41;
            this.AddBill_Button.Text = "Add Bill";
            this.AddBill_Button.UseVisualStyleBackColor = false;
            this.AddBill_Button.Click += new System.EventHandler(this.AddBill_Button_Click);
            // 
            // Amount_Textbox
            // 
            this.Amount_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Amount_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Amount_Textbox.ForeColor = System.Drawing.Color.White;
            this.Amount_Textbox.Location = new System.Drawing.Point(133, 170);
            this.Amount_Textbox.Name = "Amount_Textbox";
            this.Amount_Textbox.Size = new System.Drawing.Size(294, 38);
            this.Amount_Textbox.TabIndex = 38;
            // 
            // Date_TextBox
            // 
            this.Date_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Date_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Date_TextBox.ForeColor = System.Drawing.Color.White;
            this.Date_TextBox.Location = new System.Drawing.Point(133, 123);
            this.Date_TextBox.Name = "Date_TextBox";
            this.Date_TextBox.Size = new System.Drawing.Size(294, 38);
            this.Date_TextBox.TabIndex = 37;
            this.Date_TextBox.TextChanged += new System.EventHandler(this.Date_TextBox_TextChanged);
            // 
            // BillId_TextBox
            // 
            this.BillId_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BillId_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BillId_TextBox.ForeColor = System.Drawing.Color.White;
            this.BillId_TextBox.Location = new System.Drawing.Point(133, 79);
            this.BillId_TextBox.Name = "BillId_TextBox";
            this.BillId_TextBox.Size = new System.Drawing.Size(294, 38);
            this.BillId_TextBox.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Bill ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 42);
            this.label6.TabIndex = 44;
            this.label6.Text = "Add Bill";
            // 
            // AddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(450, 336);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Period_ComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddBill_Button);
            this.Controls.Add(this.Amount_Textbox);
            this.Controls.Add(this.Date_TextBox);
            this.Controls.Add(this.BillId_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddBill";
            this.Load += new System.EventHandler(this.AddBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Exit_Button;
        private System.Windows.Forms.ComboBox Period_ComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddBill_Button;
        private System.Windows.Forms.TextBox Amount_Textbox;
        private System.Windows.Forms.TextBox Date_TextBox;
        private System.Windows.Forms.TextBox BillId_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}