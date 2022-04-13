namespace Preschool_Client
{
    partial class AddClass
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
            this.label6 = new System.Windows.Forms.Label();
            this.AddClass_Button = new System.Windows.Forms.Button();
            this.ClassName_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.Image = global::Preschool_Client.Properties.Resources.exit;
            this.Exit_Button.Location = new System.Drawing.Point(383, 12);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(50, 50);
            this.Exit_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Button.TabIndex = 2;
            this.Exit_Button.TabStop = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 42);
            this.label6.TabIndex = 28;
            this.label6.Text = "Add Class";
            // 
            // AddClass_Button
            // 
            this.AddClass_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.AddClass_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddClass_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddClass_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddClass_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AddClass_Button.Location = new System.Drawing.Point(19, 134);
            this.AddClass_Button.Name = "AddClass_Button";
            this.AddClass_Button.Size = new System.Drawing.Size(407, 56);
            this.AddClass_Button.TabIndex = 29;
            this.AddClass_Button.Text = "Add Class";
            this.AddClass_Button.UseVisualStyleBackColor = false;
            this.AddClass_Button.Click += new System.EventHandler(this.AddClass_Button_Click);
            // 
            // ClassName_TextBox
            // 
            this.ClassName_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClassName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClassName_TextBox.ForeColor = System.Drawing.Color.White;
            this.ClassName_TextBox.Location = new System.Drawing.Point(145, 90);
            this.ClassName_TextBox.Name = "ClassName_TextBox";
            this.ClassName_TextBox.Size = new System.Drawing.Size(281, 38);
            this.ClassName_TextBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Class Name:";
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(455, 214);
            this.Controls.Add(this.ClassName_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddClass_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Exit_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddClass";
            this.Load += new System.EventHandler(this.AddClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Exit_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddClass_Button;
        private System.Windows.Forms.TextBox ClassName_TextBox;
        private System.Windows.Forms.Label label3;
    }
}