using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExamifyClassLibrary
{
    internal class Subject
    {
        private string _name = String.Empty;
        private int _numOfQuestions;
        private TimeSpan _TimerLimit = new TimeSpan();
        private List<Question> _questions = new List<Question>();
        private List<Student> _students = new List<Student>();

        public int Id { get; private set; }
        public string Name { get { return _name; } private set { _name = value; } }
        public int NumOfQuestions { get { return _numOfQuestions; } private set { _numOfQuestions = value; } }
        public TimeSpan TimerLimit { get { return _TimerLimit; } private set { _TimerLimit = value; } }
        public List<Question> Questions { get { return _questions; } private set { _questions = value; } }
        public List<Student> Students
        {
            get { return _students; }
            private set
            {
                _students = value;
            }
        }

        public Subject(string name, int num, TimeSpan timerLimit, int id)
        {
            Name = name;
            NumOfQuestions = num;
            TimerLimit = timerLimit;
            Questions = new List<Question>();
            Students = new List<Student>();
            Id = id;   
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void RemoveQuestion(Question question)
        {
            Questions.Remove(question);
        }


        // Fetch data for all subjects associated with a teacher
        //public static DataTable GetSubjectsByTeacherId(int teacherId)
        //{
        //    // Specify the stored procedure name and parameters
        //    string procedureName = "stSubjects_GetAll";
        //    SqlParameter[] parameters = new SqlParameter[]
        //    {
        //new SqlParameter("@TeacherId", teacherId)
        //    };

        //    // Call the GetData method from SqlConnector class
        //    DataTable dataTable = SqlConnector.GetData(procedureName, parameters);

        //    // Return the fetched data table
        //    return dataTable;
        //}

    }
}
