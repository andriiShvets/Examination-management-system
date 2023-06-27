using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamifyClassLibrary
{
    abstract class User
    {
        protected string _name;
        protected string _email;
        protected string _password;

        public string Name { get { return _name; } private set { _name = value; } }
        public string Email { get { return _email; } private set { _email = value; } }

        public int Id { get; private set; }

        protected User(string name, string email, int id)
        {
            Id = id;
            _name = name;
            _email = email;
            _password = GeneratePassword();
        }

        public string GeneratePassword()
        {
            Random random = new Random();
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder passwordBuilder = new StringBuilder();

            for (int i = 0; i < 6; i++)
            {
                int randomIndex = random.Next(0, allowedChars.Length);
                passwordBuilder.Append(allowedChars[randomIndex]);
            }

            return passwordBuilder.ToString();
        }

        public bool PasswordCheck(string password) => _password == password;
    }
}
