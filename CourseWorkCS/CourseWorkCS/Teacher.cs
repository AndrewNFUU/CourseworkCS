using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CourseWorkCS
{
    public enum TeacherPosition
    {
        Assistant = 1,
        Senior_Lecturer,
        Docent,
        Professor
    }

    [Serializable]
    public class Teacher : Person, IComparable
    {
        private TeacherPosition _position;

        #region constructors

        public Teacher() { }

        public Teacher(string firstName, string lastName, TeacherPosition newPosition) :
            base(firstName, lastName)
        {
            Position = newPosition;
        }

        public Teacher(string firstName, string lastName) :
            base(firstName, lastName)
        {
            this.Position = TeacherPosition.Assistant;
        }

        #endregion

        public TeacherPosition Position
        {
            get => _position; 
            set => _position = value; 
        }

        public override string ShowInfo() // метод для реалізації поліморфічного кластера
        {
            return base.ShowInfo() + 
                $" Position: {PositionToString()}  ";
        }

        public string PositionToString()
        {
            switch (_position)
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


        public void SetNewFielsds(TeacherPosition newPosition)
        {
            this.Position = newPosition;
        }

        public override string ToString()
        {
            return base.ToString() + 
                $"Positiion: {PositionToString()}  \n";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Teacher other = obj as Teacher;

            if (other != null)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else
            {
                throw new ArgumentException("Object is not a Teacher");
            }
        }
    }
}
