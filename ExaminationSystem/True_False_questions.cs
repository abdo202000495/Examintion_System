using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class True_False_questions : Question
    {
        public bool CorrectAnswer { get; set; }
        public True_False_questions(string body,int mark ,bool correctAnsswer,string header) : base (mark , body ,header)
        {
            CorrectAnswer = correctAnsswer;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Body} (True or Fals)");
        }
		public override string GetCorrectAnswer()
		{
			return  CorrectAnswer ? "True" : "False";
		}
		public override bool CheckAnswer(string answer)
		{
			return bool.TryParse(answer, out bool userAnswer) && userAnswer == CorrectAnswer;
		}


	}
}
