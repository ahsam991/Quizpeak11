﻿namespace Quizpeak11
{
    partial class Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.homepage = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.updatemark = new System.Windows.Forms.Button();
            this.qsubmission = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.homepage);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.updatemark);
            this.panel1.Controls.Add(this.qsubmission);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 661);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // homepage
            // 
            this.homepage.Location = new System.Drawing.Point(21, 592);
            this.homepage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homepage.Name = "homepage";
            this.homepage.Size = new System.Drawing.Size(95, 34);
            this.homepage.TabIndex = 4;
            this.homepage.Text = "Homepage";
            this.homepage.UseVisualStyleBackColor = true;
            this.homepage.Click += new System.EventHandler(this.homepage_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(21, 554);
            this.logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(95, 34);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 281);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Button 3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // updatemark
            // 
            this.updatemark.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatemark.Location = new System.Drawing.Point(47, 194);
            this.updatemark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updatemark.Name = "updatemark";
            this.updatemark.Size = new System.Drawing.Size(176, 50);
            this.updatemark.TabIndex = 1;
            this.updatemark.Text = "Update Marks";
            this.updatemark.UseVisualStyleBackColor = true;
            // 
            // qsubmission
            // 
            this.qsubmission.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qsubmission.Location = new System.Drawing.Point(47, 117);
            this.qsubmission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qsubmission.Name = "qsubmission";
            this.qsubmission.Size = new System.Drawing.Size(176, 50);
            this.qsubmission.TabIndex = 0;
            this.qsubmission.Text = "Question submission";
            this.qsubmission.UseVisualStyleBackColor = true;
            this.qsubmission.Click += new System.EventHandler(this.qsubmission_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button qsubmission;
        private System.Windows.Forms.Button homepage;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button updatemark;
    }
}