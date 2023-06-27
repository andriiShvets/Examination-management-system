using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamifyClassLibrary
{
    public class Result
    {
        private string _studentName;
        private float _studentGrade;
        private string _subject;
        private string _group;
        private DateTime _date;
        private TimeSpan _examTime;

        public int Id { get; private set; }

        public Result(int id, string studentName, float studentGrade, string subject, string group, DateTime date, TimeSpan examTime)
        {
            Id = id;
            _studentName = studentName;
            _studentGrade = studentGrade;
            _subject = subject;
            _group = group;
            _date = date;
            _examTime = examTime;
        }

        //save results

        //show results
    }
}
