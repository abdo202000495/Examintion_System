using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Exam
    {
        public string Title { get; set; }
        public int TimeLimit { get; set; }
        public Dictionary<Question, AnswerList> QuestionAnswerDictionary { get; set; }
        public ExamState State { get; set; }
        public Subject Subject { get; set; }

        public Exam(string title, int timeLimit, Subject subject)
        {
            Title = title;
            TimeLimit = timeLimit;
            Subject = subject;
            QuestionAnswerDictionary = new Dictionary<Question, AnswerList>();
            State = ExamState.Queued;
        }
		public  string GetGrade(double percentage)
		{
			if (percentage >= 90) return "Excellent";
			if (percentage >= 75) return "Very Good";
			if (percentage >= 60) return "Good";
			if (percentage >= 50) return "Pass";
			return "Fail";
		}
		public  int GetFinalMarks()
		{
			int totalMarks = 0;

			foreach (var kvp in QuestionAnswerDictionary)
			{
				var question = kvp.Key;
				var userAnswer = kvp.Value.Count > 0 ? kvp.Value[0].Response : "";

				if (question.CheckAnswer(userAnswer))
				{
					totalMarks += question.Mark;
				}
			}

			return totalMarks;
		}

		public  int GetTotalMarks()
		{
			return QuestionAnswerDictionary.Keys.Sum(q => q.Mark);
		}
		public abstract void ShowExam();
        

	}

    public enum ExamState { Starting, Queued, Finished }
}
