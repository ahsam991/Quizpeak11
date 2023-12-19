namespace Quizpeak11
{
    partial class TeaSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeaSignup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.signup);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.fullname);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 526);
            this.panel1.TabIndex = 0;
            // 
            // signup
            // 
            this.signup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signup.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.signup.Location = new System.Drawing.Point(448, 424);
            this.signup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(123, 26);
            this.signup.TabIndex = 3;
            this.signup.Text = "Signup";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.password.Location = new System.Drawing.Point(448, 328);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(313, 32);
            this.password.TabIndex = 2;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.email.Location = new System.Drawing.Point(448, 258);
            this.email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(313, 32);
            this.email.TabIndex = 1;
            // 
            // fullname
            // 
            this.fullname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fullname.Location = new System.Drawing.Point(448, 188);
            this.fullname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullname.Multiline = true;
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(313, 32);
            this.fullname.TabIndex = 0;
            this.fullname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TeaSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 531);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeaSignup";
            this.Text = "Teacher Signup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Button signup;
    }
}