using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkCS
{
    public enum UniversityGroup
    {
        Underfiend = 0,
        Computer_Science = 1,
        Software_Engineering,
        Information_Technology,
        Cybersecurity,
        Data_Science
    }

    [Serializable]
    public class Student : Person, IComparable
    {
        private UniversityGroup _group = UniversityGroup.Underfiend;
        private List<Exam> _exams = new List<Exam>();

        #region constructors

        public Student() { }

        public Student(string firstName, 
                        string lastName, 
                        UniversityGroup newGroup) : 
                        base(firstName, lastName) 
        {
            Group = newGroup;
        }

        public Student(string firstName, 
                        string lastName,
                        UniversityGroup newGroup,
                        List<Exam> newExams) :
                        base(firstName, lastName)
        {
            Group = newGroup;
            Exams = newExams;
        }

        #endregion

        #region properties

        public UniversityGroup Group
        {
            get => _group; 
            set => _group = value; 
        }

        public List<Exam> Exams
        {
            get => _exams; 
            set => _exams = value; 
        }

        #endregion

        public void AddExam(Exam exam)
        {
            if (exam !=  null)
            {
                Exams.Add(exam);
            }
            else
            {
                throw new ArgumentException(nameof(exam), "Exam cannot be null");
            }
        }

        public override string ShowInfo()
        {
            string info = $"Group: {GroupToString()}\n";

            if (Exams.Count <= 0)
            {
                info += "Number of exams: -\n";
            } 
            else
            {
                info += $"Number of exams: {Exams.Count}\n";
            }

            return base.ShowInfo() + info;
        }

        public string GroupToString()
        {
            switch (_group)
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

        public override string ToString()
        {
            string info = $"\t{Group}";

            if (Exams.Count <= 0)
            {
                info += "\n";
            }
            else
            {
                info += $"\t{Exams.Count}\n";
            }

            return base.ToString() + info;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Student other = obj as Student;

            if (other != null)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else
            {
                throw new ArgumentException("Object is not a Student");
            }
        }
    }
}
