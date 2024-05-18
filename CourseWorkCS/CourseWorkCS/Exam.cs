using System;

namespace CourseWorkCS
{
    [Serializable]
    public class Exam
    {
        private Teacher _examinator;
        private string _subject;
        private double _studyHours;
        private DateTime _examDate;
        private double _grade;

        #region constructors

        public Exam() { }

        public Exam(string firstName, 
                    string lastName, 
                    TeacherPosition newPosition, 
                    string newSubject, 
                    double newStudyHours, 
                    DateTime newExamDate, 
                    double newGrade)
        {
            _examinator = new Teacher(firstName, lastName, newPosition);
            _subject = newSubject;
            _studyHours = newStudyHours;
            _examDate = newExamDate;
            _grade = newGrade;
        }

        #endregion

        #region properties

        public Teacher Examinator
        {
            get => _examinator; 
            set => _examinator = value; 
        }

        public string Subject
        {
            get => _subject; 
            set => _subject = value; 
        }

        public double StudyHours
        {
            get => _studyHours; 
            set => _studyHours = value; 
        }

        public DateTime ExamDate
        {
            get => _examDate; 
            set => _examDate = value; 
        }

        public double Grade
        {
            get => _grade; 
            set => _grade = value;
        }

        #endregion

        public string ShowInfo()
        {
            return $"Subject: {_subject}  " +
                $"Grade: {_grade}\n";
        }

        #region overloading_operators

        public override string ToString()
        {
            return 
                $"Subject: {_subject}  " +
                $"Study hours: {_studyHours}  " +
                $"Exam date: {_examDate}  " +
                $"Examinator-> {_examinator}  " +
                $"Grade: {_grade} \n";
        }

        #endregion
    }
}
