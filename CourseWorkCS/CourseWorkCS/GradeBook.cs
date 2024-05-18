using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseWorkCS
{
    public class GradeBook
    {
        private Student _stud;

        public GradeBook() { }

        public GradeBook(Student newStudent)
        {
            _stud = newStudent;   
        }

        public Student Stud
        {
            get => _stud;
            set => _stud = value; 
        }

        public void SetStudent(Student newStudent)
        {
            _stud = newStudent;
        }

        public void AddExam(Exam exam)
        {
            _stud.AddExam(exam);
        }

        public List<Exam> ExamList()
        {
            List<Exam> exams = _stud.Exams;

            return exams;
        }

        public double GetAvgGrade()
        {
            List<Exam> exams = _stud.Exams;

            if (exams.Count == 0)
            {
                return 0.0;
            }
            else
            {
                double totalGrade = 0.0;

                foreach (var exam in exams)
                {
                    totalGrade += exam.Grade;
                }
                double avgGrade = totalGrade / exams.Count;
                
                return Math.Round(avgGrade, 2);
            }
        }

        public double GetMaxGrade()
        {
            List<Exam> exams = _stud.Exams;

            if (exams.Count == 0)
            {
                return 0.0;
            }
            else
            {
                double maxGrade = exams.Max(exam => exam.Grade);
                return maxGrade;
            }
        }

        public double GetMinGrade()
        {
            List<Exam> exams = _stud.Exams;

            if (exams.Count == 0)
            {
                return 0.0;
            }
            else
            {
                double minGrade = exams.Min(exam => exam.Grade);
                return minGrade;
            }
        }
    }
}
