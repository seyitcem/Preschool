
namespace Preschool_Client
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.Top_Right_Panel = new System.Windows.Forms.Panel();
            this.Minimize_Button = new System.Windows.Forms.PictureBox();
            this.Maximize_Normal_Button = new System.Windows.Forms.PictureBox();
            this.Exit_Button = new System.Windows.Forms.PictureBox();
            this.Top_Right_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize_Normal_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(667, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(887, 533);
            this.Controls.Add(this.Top_Right_Panel);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Top_Right_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize_Normal_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Exit_Button;
        private System.Windows.Forms.PictureBox Minimize_Button;
        private System.Windows.Forms.PictureBox Maximize_Normal_Button;
        private System.Windows.Forms.Panel Top_Right_Panel;
    }
}

