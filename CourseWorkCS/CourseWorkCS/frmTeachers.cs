using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CourseWorkCS
{
    public partial class frmTeachers : Form
    {
        private List<Teacher> teachers = new List<Teacher>();
        public frmTeachers()
        {
            InitializeComponent();
            StyleDataGrid();
            HardcodedTeachers();
        }

        private bool findAvailable = true;
        private void btnFindTeacher_Click(object sender, EventArgs e)
        {
            if (findAvailable)
            {
                btnFind.Visible = true;
                txtLastName.Visible = true;
                labelFind.Visible = true;
            }
            else
            {
                btnFind.Visible = false;
                txtLastName.Visible = false;
                labelFind.Visible = false;
            }

            findAvailable = !findAvailable;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindTeacher();
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindTeacher();
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridTeachers.Rows)
            {
                row.Selected = false;
            }

            if (!string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                foreach (DataGridViewRow row in dataGridTeachers.Rows)
                {
                    for (int j = 0; j < dataGridTeachers.ColumnCount; j++)
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

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            new frmAddTeacher(teachers).ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSortTeachers_Click(object sender, EventArgs e)
        {
            try
            {
                teachers.Sort();
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
                    formatter.Serialize(stream, teachers);
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
                    teachers = formatter.Deserialize(stream) as List<Teacher>;
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
            dataGridTeachers.Font = new Font("Century Gothic", 9);
            dataGridTeachers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; 


            dataGridTeachers.EnableHeadersVisualStyles = false;
            dataGridTeachers.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSeaGreen;

            foreach (DataGridViewColumn column in dataGridTeachers.Columns)
            {
               column.DefaultCellStyle.BackColor = Color.Cornsilk;
            }
        }

        private void HardcodedTeachers()
        {
            teachers.Add(new Teacher("Svitlana", "Melnyk", TeacherPosition.Assistant));
            teachers.Add(new Teacher("Ivan", "Shelepeten", TeacherPosition.Senior_Lecturer));
            teachers.Add(new Teacher("Ostap", "Dymanskyy", TeacherPosition.Docent));
            teachers.Add(new Teacher("Emma", "Watson", TeacherPosition.Professor));
            teachers.Add(new Teacher("Danylo", "Markevych", TeacherPosition.Assistant));

            RefreshData();
        }

        private void RefreshData()
        {
            dataGridTeachers.Rows.Clear();

            foreach (Teacher teacher in teachers)
            {
                dataGridTeachers.Rows.Add(teacher.FirstName,
                                        teacher.LastName,
                                        teacher.PositionToString());
            }
        }

        private void FindTeacher()
        {
            string lastName = txtLastName.Text;

            List<Teacher> selectedTeacher = GetTeacherByLastName(lastName);

            dataGridTeachers.Rows.Clear();

            if (selectedTeacher.Count > 0)
            {
                foreach(Teacher teacher in selectedTeacher)
                {
                    dataGridTeachers.Rows.Add(teacher.FirstName, 
                                               teacher.LastName,
                                               teacher.PositionToString());
                }
            }
            else
            {
                MessageBox.Show($@"There's no teachers with last name ""{lastName}""", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                RefreshData();
            }
        }

        private List<Teacher> GetTeacherByLastName(string lastName)
        {
            List<Teacher> selectedTeacher = new List<Teacher>();

            foreach (Teacher teacher in teachers)
            {
                if (teacher.LastName != null
                    && teacher.LastName.Contains(lastName))
                {
                    selectedTeacher.Add(teacher);
                }
            }

            return selectedTeacher;
        }
    }
}
