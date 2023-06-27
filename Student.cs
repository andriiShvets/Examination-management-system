using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices.JavaScript;
using System.Windows.Forms;

namespace ExamifyClassLibrary
{
    internal class Student : User
    {
        private string _group;
       // private string _subject;
        public string Group { get => _group; private set { _group = value; } }
     //   public string Subject { get => _subject; private set { _subject = value; } }
        public float Score { get; private set; } = 0.0f;

        public bool ExamAccess { get; private set; } = true;

        public Student(string name, string email, string group, string subject, int id)
            : base(name, email, id)
        {
            //запис до БД
            _group = group;
       //     _subject = subject;

            SendEmail(email, _password, subject);//зробити це при записі в бд
        }

        public void ExamStart()
        {
            ExamAccess = false;
        }

        public void SetScore(float s)
        {
            Score = s;
        }

        protected void SendEmail(string sendTo, string password, string subject)
        {
            string senderEmail = "examify.smtp@gmail.com";
            string senderPassword = "dzcvmcwdhbwlbioe";

            MailMessage message = new MailMessage(senderEmail, sendTo);

            message.Subject = subject;
            message.Body = $"Dear Student,\n\nThis is a reminder that you have an exam.\n\nTo start the exam, open the Examify application and use the following credentials:\n\nUsername: your_email@example.com\nPassword: {password}\n\nDuring the exam, ensure that you do not open any other applications or click outside of the Examify window, as it may result in the exam being closed and your score being recorded as zero.\n\nBest of luck!\n\nExamify Team";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                //delete this student data from DB
                MessageBox.Show("An error occurred while sending the email: " + ex.Message);
            }
        }

        public bool UserCheck(string email, string password, string subject)
        {
            //для логін сторінки щоб запустити до екзамену
            return true;
        }
    }
}
