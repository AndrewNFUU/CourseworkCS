using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkCS
{
    public partial class frmSelectedStudent : Form
    {
        private GradeBook gradebook = new GradeBook();

        public frmSelectedStudent(Student selectedStudent)
        {
            InitializeComponent();
            Text = $"{selectedStudent.FirstName} {selectedStudent.LastName}";
            
            gradebook.SetStudent(selectedStudent);
            
            StyleDataGrid();
            RefreshData();
            DisplayStats();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindExam();
        }

        private void txtSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindExam();
            }
        }

        private void StyleDataGrid()
        {
            dataGridExams.Font = new Font("Century Gothic", 8);
            dataGridExams.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;


            dataGridExams.EnableHeadersVisualStyles = false;
            dataGridExams.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSeaGreen;

            foreach (DataGridViewColumn column in dataGridExams.Columns)
            {
                column.DefaultCellStyle.BackColor = Color.Cornsilk;
            }
        }

        private void RefreshData()
        {
            dataGridExams.Rows.Clear();
            List<Exam> exams = gradebook.ExamList();

            foreach (var exam in exams)
            {
                dataGridExams.Rows.Add(exam.Subject, 
                                        exam.StudyHours, 
                                        exam.ExamDate,
                                        exam.Examinator.FirstName,
                                        exam.Examinator.LastName,
                                        exam.Examinator.PositionToString(),
                                        exam.Grade);
            }
        }

        private void DisplayStats()
        {
            listBoxStats.Items.Clear();

            List<Exam> exams = gradebook.ExamList();

            listBoxStats.Items.Add($"Max Grade: {gradebook.GetMaxGrade()}");
            listBoxStats.Items.Add($"Min Grade: {gradebook.GetMinGrade()}");
            listBoxStats.Items.Add($"Avg Grade: {gradebook.GetAvgGrade()}");

            listBoxStats.Items.Add("");

            foreach (var exam in exams)
            {
                listBoxStats.Items.Add(exam.ShowInfo());
            }
        }

        private void FindExam()
        {
            string subject = txtSubject.Text;

            List<Exam> exams = GetExam(subject);

            dataGridExams.Rows.Clear();

            if (exams.Count > 0)
            {
                foreach (var exam in exams)
                {
                    dataGridExams.Rows.Add(exam.Subject,
                                        exam.StudyHours,
                                        exam.ExamDate,
                                        exam.Examinator.FirstName,
                                        exam.Examinator.LastName,
                                        exam.Examinator.PositionToString(),
                                        exam.Grade);
                }
            }
            else
            {
                MessageBox.Show($@"There's no exam in ""{subject}""", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                RefreshData();
            }
        }

        private List<Exam> GetExam(string subject)
        {
            List<Exam> exams = gradebook.ExamList();
            List<Exam> matchingExams = new List<Exam>();

            foreach (var exam in exams)
            {
                if (exam.Subject != null && exam.Subject.Contains(subject))
                {
                    matchingExams.Add(exam);
                }
            }

            return matchingExams;
        }
    }
}
