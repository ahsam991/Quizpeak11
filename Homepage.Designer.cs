namespace Quizpeak11
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacher = new System.Windows.Forms.Button();
            this.studentbutton = new System.Windows.Forms.Button();
            this.mindgamebutton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.teacher);
            this.panel1.Controls.Add(this.studentbutton);
            this.panel1.Controls.Add(this.mindgamebutton);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 682);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // teacher
            // 
            this.teacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("teacher.BackgroundImage")));
            this.teacher.Location = new System.Drawing.Point(62, 285);
            this.teacher.Margin = new System.Windows.Forms.Padding(2);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(211, 70);
            this.teacher.TabIndex = 5;
            this.teacher.UseVisualStyleBackColor = true;
            this.teacher.Click += new System.EventHandler(this.teacher_Click);
            // 
            // studentbutton
            // 
            this.studentbutton.Image = ((System.Drawing.Image)(resources.GetObject("studentbutton.Image")));
            this.studentbutton.Location = new System.Drawing.Point(62, 379);
            this.studentbutton.Margin = new System.Windows.Forms.Padding(2);
            this.studentbutton.Name = "studentbutton";
            this.studentbutton.Size = new System.Drawing.Size(211, 74);
            this.studentbutton.TabIndex = 4;
            this.studentbutton.Text = "\r\n";
            this.studentbutton.UseVisualStyleBackColor = true;
            this.studentbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mindgamebutton
            // 
            this.mindgamebutton.Image = ((System.Drawing.Image)(resources.GetObject("mindgamebutton.Image")));
            this.mindgamebutton.Location = new System.Drawing.Point(62, 471);
            this.mindgamebutton.Margin = new System.Windows.Forms.Padding(2);
            this.mindgamebutton.Name = "mindgamebutton";
            this.mindgamebutton.Size = new System.Drawing.Size(211, 70);
            this.mindgamebutton.TabIndex = 3;
            this.mindgamebutton.UseVisualStyleBackColor = true;
            this.mindgamebutton.Click += new System.EventHandler(this.mindgamebutton_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Green;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(72, 584);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(129, 42);
            this.exit.TabIndex = 2;
            this.exit.Text = "Click to Exit ";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button mindgamebutton;
        private System.Windows.Forms.Button studentbutton;
        private System.Windows.Forms.Button teacher;
    }
}