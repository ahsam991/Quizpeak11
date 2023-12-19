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
    public partial class Teacherlogin : Form
    {
        public Teacherlogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            Teacher teacherloginForm = new Teacher();
            teacherloginForm.Show();

            // Hide the current form
            this.Hide();
        }
    }
}
