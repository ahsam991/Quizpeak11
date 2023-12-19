using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizpeak11
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the Student form and show it
            loginpage studentloginForm = new loginpage();
            studentloginForm.Show();
            // Hide the current form
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Create an instance of the Teacher form and show it
            loginpage teacherForm = new loginpage();
            teacherForm.Show();
            // Hide the current form
            this.Hide();

        }

        private void mindgamebutton_Click(object sender, EventArgs e)
        {
            //  Application.EnableVisualStyles();
            //  Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new frmPuzzleGame());

            // Create an instance of the PuzzleForm form and show it
            PuzzleForm pf = new PuzzleForm();
            pf.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teacher_Click(object sender, EventArgs e)
        {
            Teacherlogin teacherloginForm = new Teacherlogin();
            teacherloginForm.Show();

            // Hide the current form
            this.Hide();

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
