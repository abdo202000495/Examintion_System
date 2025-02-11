using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class QuestionList : List<Question>
    {
        private string logFile;

        public QuestionList(string logFile)
        {
            this.logFile = logFile;
        }
       

        public new void Add(Question question)
        {
            base.Add(question);
            LogQuestion(question);
        }

        private void LogQuestion(Question question)
        {
            using (StreamWriter writer = new StreamWriter(logFile, true))
            {
                writer.WriteLine(question.Body);
            }
        }
    }


    public class Answer
    {
        public string Response { get; set; }

        public Answer(string response)
        {
            Response = response;
        }
       
    }
    public class AnswerList : List<Answer> { }

    // Subject Class
    public class Subject
    {
        public string Name { get; set; }

        public Subject(string name)
        {
            Name = name;
        }
    }
   

}
