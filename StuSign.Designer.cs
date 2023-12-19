namespace Quizpeak11
{
    partial class StuSign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuSign));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup = new System.Windows.Forms.Button();
            this.instName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.signup);
            this.panel1.Controls.Add(this.instName);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.FullName);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 670);
            this.panel1.TabIndex = 0;
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.signup.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.Location = new System.Drawing.Point(631, 533);
            this.signup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(164, 38);
            this.signup.TabIndex = 5;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // instName
            // 
            this.instName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.instName.Location = new System.Drawing.Point(595, 447);
            this.instName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.instName.Multiline = true;
            this.instName.Name = "instName";
            this.instName.Size = new System.Drawing.Size(407, 45);
            this.instName.TabIndex = 3;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.password.Location = new System.Drawing.Point(595, 369);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(407, 46);
            this.password.TabIndex = 2;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Email.Location = new System.Drawing.Point(595, 288);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(407, 44);
            this.Email.TabIndex = 1;
            this.Email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FullName
            // 
            this.FullName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FullName.Location = new System.Drawing.Point(595, 208);
            this.FullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FullName.Multiline = true;
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(407, 43);
            this.FullName.TabIndex = 0;
            this.FullName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StuSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StuSign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StuSign";
            this.Load += new System.EventHandler(this.StuSign_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox instName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Button signup;
    }
}