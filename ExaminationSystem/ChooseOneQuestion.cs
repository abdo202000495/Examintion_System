using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class ChooseOneQuestion : Question
    {
        public List<string> Choices {  get; set; }
        public string CorrectChoice { get; set; }
        public ChooseOneQuestion( string body, string header, int marks, List<string> choices, string correctIndexy) : base (marks,body,header)                                  
        {
            Choices = choices;
			CorrectChoice = correctIndexy;
        }
        public override void ShowQuestion()
        {
            Console.WriteLine(Body);
            for (int i = 0; i < Choices.Count; i++)
            {
                Console.WriteLine($"{1 + i}. {Choices[i]}");
            }
        }
		public override string GetCorrectAnswer()
		{
			return CorrectChoice;
		}
		public override bool CheckAnswer(string answer)
		{
			return string.Equals(answer, CorrectChoice, StringComparison.OrdinalIgnoreCase);
		}

	}
}
