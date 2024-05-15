using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkCS
{
    public partial class frmStudents : Form
    {
        private List<Student> students = new List<Student>();
        List<Student> selectedStudents = new List<Student>();
        public frmStudents()
        {
            InitializeComponent();
            StyleDataGrid();
            HardcodedStudents();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindStudents();
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindStudents();
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridStudents.Rows)
            {
                row.Selected = false;
            }

            if (!string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                foreach (DataGridViewRow row in dataGridStudents.Rows)
                {
                    for (int j = 0; j < dataGridStudents.ColumnCount; j++)
                    {
                        if (row.Cells[j].Value != null
                            && row.Cells[j].Value.ToString().Contains(txtLastName.Text))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            new frmAddStudent(students).ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSortTeachers_Click(object sender, EventArgs e)
        {
            try
            {
                students.Sort();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorting error: " + ex.Message);
            }
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Data file (.dat)|*.dat|Text documents (.txt)|*.txt";

                saveFileDialog.ShowDialog();
                using (Stream stream = File.Open(saveFileDialog.FileName,
                    FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, students);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Data file (.dat)|*.dat|Text documents (.txt)|*.txt";

                openFileDialog.ShowDialog();

                using (Stream stream = File.Open(openFileDialog.FileName,
                    FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    students = formatter.Deserialize(stream) as List<Student>;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ------------------ Methods -----------------

        private void StyleDataGrid()
        {
            dataGridStudents.Font = new Font("Century Gothic", 9);
            dataGridStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;


            dataGridStudents.EnableHeadersVisualStyles = false;
            dataGridStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSeaGreen;

            foreach (DataGridViewColumn column in dataGridStudents.Columns)
            {
                column.DefaultCellStyle.BackColor = Color.Cornsilk;
            }
        }

        private void HardcodedStudents()
        {
            #region exams
            Exam oopCpp = new Exam("Jane", "Smith", TeacherPosition.Professor,
                "OOP Cpp & C#", 70.5, new DateTime(2024, 4, 29), 90.0);

            Exam descreteMath = new Exam("Mike", "Johnson", TeacherPosition.Docent,
                "Discrete Math", 60.5, new DateTime(2024, 5, 13), 0.0);

            Exam machineLearn = new Exam("Stephe", "Kerr", TeacherPosition.Professor,
                "Machine Learning", 80.5, new DateTime(2024, 4, 29), 92.4);

            Exam algs = new Exam("Emmy", "Watson", TeacherPosition.Assistant,
                "Algorithms & Data Structures", 75.0, new DateTime(2024, 5, 1), 89.0);

            Exam probs = new Exam("Yury", "Procyk", TeacherPosition.Professor,
                "Probabilities", 75.5, new DateTime(2024, 5, 3), 97.0);

            Exam network = new Exam("Bill", "McTavish", TeacherPosition.Docent,
                "Computer Networking", 67.5, new DateTime(2024, 5, 17), 0.0);

            Exam compNetworking = new Exam("Bogdan", "Bekas", TeacherPosition.Docent,
                "Networking", 87.5, new DateTime(2024, 5, 12), 100.0);

            Exam database = new Exam("Ben", "Light", TeacherPosition.Senior_Lecturer,
                "Databases", 60.5, new DateTime(2024, 5, 7), 93.7);

            Exam database2 = new Exam("Ben", "Light", TeacherPosition.Senior_Lecturer,
                "Databases", 60.5, new DateTime(2024, 5, 12), 0.0);

            Exam database3 = new Exam("Mykhailo", "Dandyuk", TeacherPosition.Senior_Lecturer,
                "Databases", 85.5, new DateTime(2024, 5, 7), 95.5);

            Exam math_exam = new Exam("John", "Wick", TeacherPosition.Professor,
                "Differential Equations", 85.0, new DateTime(2023, 11, 12), 98.5);

            Exam math_exam2 = new Exam("Ostap", "Dumanskyy", TeacherPosition.Docent,
                "Discrete Math", 85.0, new DateTime(2023, 11, 12), 93.5);

            Exam oop = new Exam("Helen", "McCrory", TeacherPosition.Docent,
                "OOP Java", 90.5, new DateTime(2024, 4, 13), 94.4);

            Exam multithreading = new Exam("Mykola", "Salo", TeacherPosition.Docent,
                "Multithreading", 90.5, new DateTime(2024, 5, 17), 99.5);

            Exam modelling = new Exam("Miles", "Goat", TeacherPosition.Senior_Lecturer,
                "3D Modelling", 75.0, new DateTime(2024, 5, 8), 90.0);

            Exam cyberSecurity = new Exam("Sem", "Johnson", TeacherPosition.Professor,
                "Cyber Security", 90.0, new DateTime(2024, 5, 8), 98.0);

            Exam[] examsArr1 = new Exam[] { machineLearn, database2, oop, probs, oopCpp};
            Exam[] examsArr2 = new Exam[] { oopCpp, descreteMath, machineLearn, database, oop };
            Exam[] examsArr3 = new Exam[] { algs, probs, network, database2 };
            Exam[] examsArr4 = new Exam[] { machineLearn, database2, oop, probs };
            Exam[] examsArr5 = new Exam[] { descreteMath, network, math_exam, database };
            Exam[] examsArr6 = new Exam[] { database3, compNetworking, math_exam2, multithreading, modelling, cyberSecurity };

            List<Exam> exams1 = new List<Exam>();
            exams1.AddRange(examsArr1);

            List<Exam> exams2 = new List<Exam>();
            exams2.AddRange(examsArr2);

            List<Exam> exams3 = new List<Exam>();
            exams3.AddRange(examsArr3);

            List<Exam> exams4 = new List<Exam>();
            exams4.AddRange(examsArr4);

            List<Exam> exams5 = new List<Exam>();
            exams5.AddRange(examsArr5);

            List<Exam> exams6 = new List<Exam>();
            exams6.AddRange(examsArr6);
            #endregion

            #region students
            students.Add(new Student("John", "Doe", UniversityGroup.Computer_Science, exams1));
            students.Add(new Student("Andrii", "Kononenko", UniversityGroup.Computer_Science, exams6));
            students.Add(new Student("Jane", "Smith", UniversityGroup.Software_Engineering, exams2));
            students.Add(new Student("Mike", "Johnson", UniversityGroup.Information_Technology, exams3));
            students.Add(new Student("Emily", "Williams", UniversityGroup.Cybersecurity, exams4));
            students.Add(new Student("David", "Brown", UniversityGroup.Data_Science));
            students.Add(new Student("Sarah", "Miller", UniversityGroup.Computer_Science));
            students.Add(new Student("Chris", "Wilson", UniversityGroup.Software_Engineering, exams1));
            students.Add(new Student("Jessica", "Davis", UniversityGroup.Information_Technology));
            students.Add(new Student("Michael", "Taylor", UniversityGroup.Cybersecurity));
            students.Add(new Student("Laura", "Moore", UniversityGroup.Data_Science, exams5));
            students.Add(new Student("Alex", "Anderson", UniversityGroup.Computer_Science));
            students.Add(new Student("Rachel", "Clark", UniversityGroup.Software_Engineering, exams3));
            students.Add(new Student("Kevin", "Lee", UniversityGroup.Information_Technology));
            students.Add(new Student("Olivia", "White", UniversityGroup.Cybersecurity));
            students.Add(new Student("Daniel", "Martin", UniversityGroup.Data_Science, exams2));
            students.Add(new Student("Bill", "Martin", UniversityGroup.Software_Engineering, exams4));
            #endregion

            RefreshData();
        }

        private void RefreshData()
        {
            dataGridStudents.Rows.Clear();

            foreach (Student student in students)
            {
                dataGridStudents.Rows.Add(student.FirstName,
                                        student.LastName,
                                        student.GroupToString(), 
                                        student.Exams.Count);
            }

            selectedStudents.Clear();
            selectedStudents.AddRange(students);
        }

        private void FindStudents()
        {
            string lastName = txtLastName.Text;

            selectedStudents = GetStudentByLastName(lastName);

            dataGridStudents.Rows.Clear();

            if (selectedStudents.Count > 0)
            {
                foreach (Student student in selectedStudents)
                {
                    dataGridStudents.Rows.Add(student.FirstName,
                                               student.LastName,
                                               student.GroupToString());
                }
            }
            else
            {
                MessageBox.Show($@"There's no students with last name ""{lastName}""", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                RefreshData();
            }
        }

        private List<Student> GetStudentByLastName(string lastName)
        {
            List<Student> selectedStudents = new List<Student>();

            foreach (Student student in students)
            {
                if (student.LastName != null
                    && student.LastName.Contains(lastName))
                {
                    selectedStudents.Add(student);
                }
            }

            return selectedStudents;
        }

        private void dataGridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            new frmSelectedStudent(selectedStudents[e.RowIndex]).ShowDialog();
            // MessageBox.Show($"{selectedStudents[e.RowIndex].LastName} {selectedStudents[e.RowIndex].FirstName}");
        }

        private void labelFind_Click(object sender, EventArgs e)
        {

        }
    }
}
