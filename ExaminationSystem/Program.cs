using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
    
            static void Main(string[] args)
            {
            QuestionList TorFQuestions = new QuestionList("C:\\Users\\almanar\\source\\repos\\ExaminationSystem\\ExaminationSystem\\Math.txt");
            TorFQuestions.Add(new True_False_questions("The Sahara Desert is the largest desert in the world.", 1, true, "True/False"));
            TorFQuestions.Add(new True_False_questions("Mount Everest is located in the Andes Mountains.", 1, false, "True/False"));
            TorFQuestions.Add(new True_False_questions("The Amazon River is the longest river in the world.", 1, false, "True/False"));
            TorFQuestions.Add(new True_False_questions("Africa is the second-largest continent by area.", 1, true, "True/False"));
            TorFQuestions.Add(new True_False_questions("The equator passes through only three continents.", 1, true, "True/False"));
            TorFQuestions.Add(new True_False_questions("Antarctica has no permanent residents.", 1, true, "True/False"));
            TorFQuestions.Add(new True_False_questions("Australia is both a country and a continent.", 1, true, "True/False"));
            TorFQuestions.Add(new True_False_questions("The Great Wall of China is visible from space.", 1, false, "True/False"));
            TorFQuestions.Add(new True_False_questions("The Nile River flows northward.", 1, true, "True/False"));
            TorFQuestions.Add(new True_False_questions("There are five oceans in the world.", 1, true, "True/False"));

            QuestionList OneChoiceQ = new QuestionList("C:\\Users\\almanar\\source\\repos\\ExaminationSystem\\ExaminationSystem\\OnChoice.txt");

            OneChoiceQ.Add(new ChooseOneQuestion("Which country has the largest population in the world?", "Multiple Choice", 1,
                new List<string> { "United States", "India", "China", "Russia" }, "China"));

            OneChoiceQ.Add(new ChooseOneQuestion("What is the smallest continent by land area?", "Multiple Choice", 1,
                new List<string> { "Europe", "Australia", "South America", "Antarctica" }, "Australia"));

            OneChoiceQ.Add(new ChooseOneQuestion("What is the capital of Egypt?", "Multiple Choice", 1,
                new List<string> { "Alexandria", "Cairo", "Giza", "Luxor" }, "Cairo"));

            OneChoiceQ.Add(new ChooseOneQuestion("Which ocean is the largest?", "Multiple Choice", 1,
                new List<string> { "Indian", "Atlantic", "Pacific", "Arctic" }, "Pacific"));

            OneChoiceQ.Add(new ChooseOneQuestion("Which mountain range separates Europe from Asia?", "Multiple Choice", 1,
                new List<string> { "Himalayas", "Ural Mountains", "Alps", "Andes" }, "Ural Mountains"));

            OneChoiceQ.Add(new ChooseOneQuestion("Which is the longest mountain range in the world?", "Multiple Choice", 1,
                new List<string> { "Andes", "Rockies", "Alps", "Himalayas" }, "Andes"));

            OneChoiceQ.Add(new ChooseOneQuestion("What is the official language of Brazil?", "Multiple Choice", 1,
                new List<string> { "Spanish", "Portuguese", "English", "French" }, "Portuguese"));

            OneChoiceQ.Add(new ChooseOneQuestion("What is the currency used in Japan?", "Multiple Choice", 1,
                new List<string> { "Yen", "Dollar", "Won", "Euro" }, "Yen"));

            OneChoiceQ.Add(new ChooseOneQuestion("Which sea is the saltiest body of water on Earth?", "Multiple Choice", 1,
                new List<string> { "Dead Sea", "Red Sea", "Black Sea", "Caspian Sea" }, "Dead Sea"));

            OneChoiceQ.Add(new ChooseOneQuestion("What is the hottest desert in the world?", "Multiple Choice", 1,
                new List<string> { "Sahara Desert", "Kalahari Desert", "Gobi Desert", "Thar Desert" }, "Sahara Desert"));

            QuestionList AllChoicesQ = new QuestionList("C:\\Users\\almanar\\source\\repos\\ExaminationSystem\\ExaminationSystem\\AllChoice.txt");

            AllChoicesQ.Add(new ChooseAllQuestion(
                "Which of the following are prime numbers?", "Multiple Answers", 2,
                new List<string> { "2", "3", "4", "5" }, new List<string> { "2", "3", "5" }));

            AllChoicesQ.Add(new ChooseAllQuestion(
                "Which countries are in South America?", "Multiple Answers", 2,
                new List<string> { "Brazil", "Argentina", "Spain", "Colombia" }, new List<string> { "Brazil", "Argentina", "Colombia" }));

            AllChoicesQ.Add(new ChooseAllQuestion(
                "Which of these are renewable energy sources?", "Multiple Answers", 2,
                new List<string> { "Solar", "Wind", "Coal", "Hydropower" }, new List<string> { "Solar", "Wind", "Hydropower" }));

            AllChoicesQ.Add(new ChooseAllQuestion(
                "Which colors are in the RGB model?", "Multiple Answers", 2,
                new List<string> { "Red", "Blue", "Green", "Yellow" }, new List<string> { "Red", "Blue", "Green" }));

            AllChoicesQ.Add(new ChooseAllQuestion(
                "Which of these are continents?", "Multiple Answers", 2,
                new List<string> { "Africa", "Asia", "Amazon", "Europe" }, new List<string> { "Africa", "Asia", "Europe" }));

            AllChoicesQ.Add(new ChooseAllQuestion(
                "Which elements are noble gases?", "Multiple Answers", 2,
                new List<string> { "Helium", "Oxygen", "Neon", "Carbon" }, new List<string> { "Helium", "Neon" }));

            AllChoicesQ.Add(new ChooseAllQuestion(
                "Which planets are gas giants?", "Multiple Answers", 2,
                new List<string> { "Mercury", "Jupiter", "Saturn", "Mars" }, new List<string> { "Jupiter", "Saturn" }));

            AllChoicesQ.Add(new ChooseAllQuestion(
                "Which animals are mammals?", "Multiple Answers", 2,
                new List<string> { "Dog", "Shark", "Elephant", "Frog" }, new List<string> { "Dog", "Elephant" }));

            AllChoicesQ.Add(new ChooseAllQuestion(
                "Which of these are programming languages?", "Multiple Answers", 2,
                new List<string> { "Python", "JavaScript", "HTML", "CSS" }, new List<string> { "Python", "JavaScript" }));

            AllChoicesQ.Add(new ChooseAllQuestion(
                "Which countries are part of the European Union?", "Multiple Answers", 2,
                new List<string> { "Germany", "France", "Switzerland", "Italy" }, new List<string> { "Germany", "France", "Italy" }));


			Console.WriteLine("Welcome to the Examination System!");
			Console.Write("Enter your name: ");
			string studentName = Console.ReadLine();
			Console.WriteLine("Choose the exam type:");
			Console.WriteLine("1. Practice Exam");
			Console.WriteLine("2. Final Exam");
			string ExamType =Console.ReadLine();
            if (ExamType == "1")
            {
                PracticeExam Exam = new PracticeExam("Math",60,new Subject("Mathimatcal"));
                Exam.QuestionAnswerDictionary.Add(AllChoicesQ[0], new AnswerList());
				Exam.QuestionAnswerDictionary.Add(AllChoicesQ[1], new AnswerList());
				Exam.QuestionAnswerDictionary.Add(AllChoicesQ[2], new AnswerList());
				Exam.QuestionAnswerDictionary.Add(AllChoicesQ[3], new AnswerList());
				Exam.QuestionAnswerDictionary.Add(AllChoicesQ[4], new AnswerList());
                Exam.QuestionAnswerDictionary.Add(TorFQuestions[0], new AnswerList());
				Exam.QuestionAnswerDictionary.Add(TorFQuestions[1], new AnswerList());
				Exam.QuestionAnswerDictionary.Add(TorFQuestions[2], new AnswerList());
				Exam.QuestionAnswerDictionary.Add(TorFQuestions[3], new AnswerList());
				Exam.QuestionAnswerDictionary.Add(TorFQuestions[4], new AnswerList());
                Exam.QuestionAnswerDictionary.Add(OneChoiceQ[0], new AnswerList());
                Exam.QuestionAnswerDictionary.Add(OneChoiceQ[1], new AnswerList());
                Exam.QuestionAnswerDictionary.Add(OneChoiceQ[2], new AnswerList());
                Exam.QuestionAnswerDictionary.Add(OneChoiceQ[3], new AnswerList());
                Exam.QuestionAnswerDictionary.Add(OneChoiceQ[4], new AnswerList());
                Exam.ShowExam();
                Exam.ShowStudentAndCorrectAnswers();
                

                foreach (var item in Exam.QuestionAnswerDictionary)
                {
                    Question question = item.Key;
                    var  answer = item.Value[0].Response;
                    var correctAnswer = question.GetCorrectAnswer();
					Console.WriteLine($"Question: {question.Body}");
					Console.WriteLine($"Your Answer: {answer}");
					Console.WriteLine($"Correct Answer: {correctAnswer}\n");
				}
            }
            else if (ExamType =="2")
            {
                FinalExam finalExam = new FinalExam("Science", 120, new Subject("Science"));
				finalExam.QuestionAnswerDictionary.Add(AllChoicesQ[0], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(AllChoicesQ[1], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(AllChoicesQ[2], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(AllChoicesQ[3], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(AllChoicesQ[4], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(TorFQuestions[0], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(TorFQuestions[1], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(TorFQuestions[2], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(TorFQuestions[3], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(TorFQuestions[4], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(OneChoiceQ[0], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(OneChoiceQ[1], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(OneChoiceQ[2], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(OneChoiceQ[3], new AnswerList());
				finalExam.QuestionAnswerDictionary.Add(OneChoiceQ[4], new AnswerList());
				Console.WriteLine("\nStarting the exam...");
                finalExam.State = ExamState.Starting;
				finalExam.ShowExam();
                finalExam.State = ExamState.Finished;
				Console.WriteLine("\nExam completed.");

				int finalMarks = finalExam.GetFinalMarks();
				int totalMarks = finalExam.GetTotalMarks();
				double percentage = (double)finalMarks / totalMarks * 100;
				string grade = finalExam.GetGrade(percentage);

				Console.WriteLine($"\nYour Final Score: {finalMarks}/{totalMarks}");
				Console.WriteLine($"Percentage: {percentage:F2}%");
				Console.WriteLine($"Grade: {grade}");

			}

		}
        
    }
}
    

