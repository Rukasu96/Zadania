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
        private int answer;

        public string Text { get => text; set => text = value; }
        public int Answer { get => answer; set => answer = value; }

        public Question(string text)
        {
            Text = text;
            
        }


    }
}
