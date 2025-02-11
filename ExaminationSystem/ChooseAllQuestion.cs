using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class ChooseAllQuestion : Question
    {
        public List<string> CorrectChoices { get; set; }
        public List<string> Choices { get; set; }

        public ChooseAllQuestion( string body, string header, int marks, List<string> choices, List<string> correctIndices) : base(marks, body, header)
        {
            CorrectChoices = correctIndices;
            Choices = choices;
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
			return string.Join(", ", CorrectChoices);
		}
		
		public override bool CheckAnswer(string answer)
		{
			var answers = answer.Split(',')
								.Select(a => a.Trim())
								.ToList();

			return !CorrectChoices.Except(answers).Any() && !answers.Except(CorrectChoices).Any();
		}



	}
}
