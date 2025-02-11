using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class PracticeExam : Exam
    {
        public PracticeExam(string title, int timeLimit, Subject subject) : base(title, timeLimit, subject) { }

        public override void ShowExam()
        {
            Console.WriteLine($"Practice Exam: {Title}");
            foreach (var question in QuestionAnswerDictionary.Keys)
            {
                question.ShowQuestion();
				Console.WriteLine("Enter your answer(s) (for multiple answers, separate by commas):");
				string answer = Console.ReadLine();
                QuestionAnswerDictionary[question].Add(new Answer(answer));
            }
            Console.WriteLine("Correct answers will be shown at the end.");
        }
		public void ShowStudentAndCorrectAnswers()
		{
			Console.WriteLine("\nReview of Your Answers:\n");
			foreach (var kvp in QuestionAnswerDictionary)
			{
				var question = kvp.Key;
				var userAnswer = kvp.Value[0].Response;
				var correctAnswer = question.GetCorrectAnswer();

				Console.WriteLine($"Question: {question.Body}");
				Console.WriteLine($"Your Answer: {userAnswer}");
				Console.WriteLine($"Correct Answer: {correctAnswer}\n");
			}
		}


		public void ShowAnswers ()
        {

        }
    }
    public class FinalExam : Exam
    {
        public FinalExam(string title, int timeLimit, Subject subject) : base(title, timeLimit, subject)
        {
            
        
        }

        public override void ShowExam()
        {
            Console.WriteLine($"Final Exam: {Title}");
            foreach (var question in QuestionAnswerDictionary.Keys)
            {
				question.ShowQuestion();
				Console.WriteLine("Enter your answer(s) (for multiple answers, separate by commas):");
				string answer = Console.ReadLine();
				QuestionAnswerDictionary[question].Add(new Answer(answer));
			}
            Console.WriteLine("No answers will be shown.");
        }
		
	}


}
