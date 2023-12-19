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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homepage_Click(object sender, EventArgs e)
        {
            // Create an instance of the Teacher form and show it
            Homepage teacherForm2 = new Homepage();
            teacherForm2.Show();

            // Hide the current form
            this.Hide();
        }

        private void qsubmission_Click(object sender, EventArgs e)
        {

            Question_set QuestionsetForm = new Question_set();
            QuestionsetForm.Show();

            // Hide the current form
           
            this.Hide();


        }
    }
}
