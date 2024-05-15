using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkCS
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            new frmTeachers().ShowDialog();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            new frmStudents().ShowDialog();
        }

        private void btnCoursework_Click(object sender, EventArgs e)
        {
            new frmOther().ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }
    }
}
