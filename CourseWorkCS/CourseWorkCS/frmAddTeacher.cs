using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWorkCS
{
    public partial class frmAddTeacher : Form
    {
        private List<Teacher> teachers;
        public frmAddTeacher(List<Teacher> teachers)
        {
            InitializeComponent();
            foreach(TeacherPosition position in Enum.GetValues(typeof(TeacherPosition)))
            {
                cmbxPositions.Items.Add(PositionToString(position));
            }
            this.teachers = teachers;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text;

                string lastName = txtLastName.Text;

                TeacherPosition teacherPosition = (TeacherPosition)cmbxPositions.SelectedIndex;

                Teacher newTeacher = new Teacher(firstName, lastName, teacherPosition);

                teachers.Add(newTeacher);

                MessageBox.Show($"Teacher {firstName} {lastName} added to list. ", "Congratulations", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error when filling out data.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string PositionToString(TeacherPosition position)
        {
            switch (position)
            {
                case TeacherPosition.Assistant:
                    return "Assistant";

                case TeacherPosition.Senior_Lecturer:
                    return "Senior Lecturer";

                case TeacherPosition.Docent:
                    return "Docent";

                case TeacherPosition.Professor:
                    return "Professor";

                default:
                    return "Unknown";
            }
        }
    }
}
