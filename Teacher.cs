using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamifyClassLibrary
{
    internal class Teacher : User
    {
        private readonly List<Subject> _subjects = new List<Subject>();

        public List<Subject> Subjects { get { return _subjects; } }

        public Teacher (string name, string email, Subject subject, int id)
            : base(name, email, id)
        {
            _subjects.Add(subject);
        }


    }
}
