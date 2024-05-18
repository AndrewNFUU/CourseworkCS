using System.Drawing;
using System.Windows.Forms;

namespace CourseWorkCS
{
    public partial class frmOther : Form
    {
        public frmOther()
        {
            InitializeComponent();
            listBoxTask.Font = new Font("Century Gothic", 10);
            listBoxTask.Enabled = false;
            DisplayTask();
        }

        private void DisplayTask()
        {
            listBoxTask.Items.Clear();

            listBoxTask.Items.Add(" Polymorphic cluster:");

            Person person = new Person("Vladislave", "Master");
            Teacher teacher = new Teacher("Olekslave", "Moonlight", TeacherPosition.Professor);

            listBoxTask.Items.Add(person.ShowInfo());
            listBoxTask.Items.Add(teacher.ShowInfo());

            listBoxTask.Items.Add("");
            listBoxTask.Items.Add(" Late binding:");

            Person latePerson = new Person("Pes", "Patron");
            Person lateTeacher = new Teacher("Kit", "Patron");

            listBoxTask.Items.Add(latePerson.ShowInfo());
            listBoxTask.Items.Add(lateTeacher.ShowInfo());
        }
    }
}
