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
    public partial class TeaSignup : Form
    {
        public TeaSignup()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
           
            Teacher teacherForm1 = new Teacher();
            teacherForm1.Show();

            // Hide the current form
            this.Hide();
        }
    }
}
