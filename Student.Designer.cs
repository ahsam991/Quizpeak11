namespace Quizpeak11
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.gradecheck = new System.Windows.Forms.Button();
            this.previewquiz = new System.Windows.Forms.Button();
            this.takenewquiz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.gradecheck);
            this.panel1.Controls.Add(this.previewquiz);
            this.panel1.Controls.Add(this.takenewquiz);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 666);
            this.panel1.TabIndex = 0;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(64, 558);
            this.logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(122, 36);
            this.logout.TabIndex = 3;
            this.logout.Text = "Log out";
            this.logout.UseVisualStyleBackColor = true;
            // 
            // gradecheck
            // 
            this.gradecheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradecheck.Location = new System.Drawing.Point(64, 286);
            this.gradecheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gradecheck.Name = "gradecheck";
            this.gradecheck.Size = new System.Drawing.Size(191, 60);
            this.gradecheck.TabIndex = 2;
            this.gradecheck.Text = "Grade Check";
            this.gradecheck.UseVisualStyleBackColor = true;
            this.gradecheck.Click += new System.EventHandler(this.gradecheck_Click);
            // 
            // previewquiz
            // 
            this.previewquiz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewquiz.Location = new System.Drawing.Point(64, 186);
            this.previewquiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.previewquiz.Name = "previewquiz";
            this.previewquiz.Size = new System.Drawing.Size(191, 60);
            this.previewquiz.TabIndex = 1;
            this.previewquiz.Text = "Preview Quiz";
            this.previewquiz.UseVisualStyleBackColor = true;
            // 
            // takenewquiz
            // 
            this.takenewquiz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takenewquiz.Location = new System.Drawing.Point(64, 95);
            this.takenewquiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.takenewquiz.Name = "takenewquiz";
            this.takenewquiz.Size = new System.Drawing.Size(191, 60);
            this.takenewquiz.TabIndex = 0;
            this.takenewquiz.Text = "Take New Quiz";
            this.takenewquiz.UseVisualStyleBackColor = true;
            this.takenewquiz.Click += new System.EventHandler(this.takenewquiz_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button gradecheck;
        private System.Windows.Forms.Button previewquiz;
        private System.Windows.Forms.Button takenewquiz;
    }
}