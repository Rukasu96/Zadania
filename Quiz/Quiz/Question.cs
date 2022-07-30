using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Question
    {
        private string text;
        private string[] answers;
        private int correctAnswerIndex;

        public string Text { get => text; set => text = value; }
        public int CorrectAnswerIndex { get => correctAnswerIndex; set => correctAnswerIndex = value; }
        public string Answers => string.Join(", ", answers);

        public Question(string text, string[] answers, int correctAnswerIndex)
        {
            Text = text;
            this.answers = answers;
            this.CorrectAnswerIndex = correctAnswerIndex;
        }


    }
}
