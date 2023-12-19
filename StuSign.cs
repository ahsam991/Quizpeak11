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
    public partial class StuSign : Form
    {
        public StuSign()
        {
            InitializeComponent();
        }

        private void StuSign_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            // Create an instance of the Teacher form and show it
            Student teacherForm3 = new Student();
            teacherForm3.Show();

            // Hide the current form
            this.Hide();
        }
    }
}
