using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamifyClassLibrary
{
    public class Question
    {
        private string _description;
        private string _answer;
        private string _op1;
        private string _op2;
        private string _op3;
        private string _op4;
        private float _score;
        private string _chosenCheckBox;

        public int Id { get; private set; }
        public string Description { get { return _description; } private set { _description = value; } }
        public string Answer { get { return _answer; } private set { _answer = value; } }
        public string Op1 { get { return _op1; } private set { _op1 = value; } }
        public string Op2 { get { return _op2; } private set { _op2 = value; } }
        public string Op3 { get { return _op3; } private set { _op3 = value; } }
        public string Op4 { get { return _op4; } private set { _op4 = value; } }
        public float Score { get { return _score; } private set { _score = value; } }
        public string ChosenCheckBox { get { return _chosenCheckBox; } set { _chosenCheckBox = value; } }

        public Question(string description, string answer, string o1, string o2, string o3, string o4, float score)
        {
            //ALSO write into db

           
            Description = description;
            Answer = answer;
            Op1 = o1;
            Op2 = o2;
            Op3 = o3;
            Op4 = o4;
            Score = score;
            ChosenCheckBox = string.Empty;
        }

        //method to fetch question from db

        //method to edit question in db

        //method to delete question from db
    }
}
