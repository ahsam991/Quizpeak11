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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            // Create an instance of the Teacher form and show it
            Homepage studentForm = new Homepage();
            studentForm.Show();

            // Hide the current form
            this.Hide();
        }

        private void gradecheck_Click(object sender, EventArgs e)
        {
            // Create an instance of the Teacher form and show it
            GradeChecker gf = new GradeChecker();
            gf.Show();

            // Hide the current form
            this.Hide();
        }

        private void takenewquiz_Click(object sender, EventArgs e)
        {
            Question_set QuestionForm = new Question_set();
            QuestionForm.Show();

            // Hide the current form
            this.Hide();
        }
    }
}
