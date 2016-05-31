using System.Runtime.CompilerServices;

namespace WindowsFormsApplication1.Quests
{
    using System;

    public class Quest
    {
        public string Question { get; private set; }

        public string Answer { get; private set; }

        public QuestionType Type { get; private set; }

        //constructor
        public Quest(string question, string answer, QuestionType type)
        {
            this.Question = question;
            this.Answer = answer;
            this.Type = type;
        }

        public override string ToString()
        {
            return this.Question;
        }
    }
}
