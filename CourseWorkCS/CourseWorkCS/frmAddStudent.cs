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
    public partial class frmAddStudent : Form
    {
        private List<Student> students;
        public frmAddStudent(List<Student> students)
        {
            InitializeComponent();
            foreach(UniversityGroup group in Enum.GetValues(typeof(UniversityGroup)))
            {
                cmbxGroups.Items.Add(ConvertToString(group));
            }
            this.students = students;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text;

                string lastName = txtLastName.Text;

                UniversityGroup group = (UniversityGroup)cmbxGroups.SelectedIndex;

                Student newStudent = new Student(firstName, lastName, group);

                students.Add(newStudent);

                MessageBox.Show($"Student {firstName} {lastName} added to list. ", "Congratulations",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error when filling out data.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string ConvertToString(UniversityGroup group)
        {
            switch (group)
            {
                case UniversityGroup.Underfiend:
                    return "Underfiend";

                case UniversityGroup.Computer_Science:
                    return "Computer Science";

                case UniversityGroup.Software_Engineering:
                    return "Software Engineering";

                case UniversityGroup.Information_Technology:
                    return "Information Technology";

                case UniversityGroup.Cybersecurity:
                    return "Cybersecurity";

                case UniversityGroup.Data_Science:
                    return "Data Science";

                default:
                    return "Unknown";
            }
        }
    }
}
