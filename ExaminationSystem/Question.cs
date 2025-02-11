using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class  Question
    {
        public int Mark {  get; set; }
        public string Body { get; set; }
        public string Header { get; set; }
        protected Question(int mark , string body , string header)
        {
            Mark = mark;
            Body = body;
            Header = header;
        }
        public virtual void PrintQ()
        {
            Console.WriteLine($"{Header} \n {Body}");
        }
        public abstract void ShowQuestion();
		public abstract string GetCorrectAnswer();
        public abstract bool CheckAnswer(string answer);

	}
}

