using System;
using System.Collections.Generic;

namespace GeniusIdiotConsoleApp
{
    public class QuestionsStorage
    {
        public static List<Questions> questions = new List<Questions>();
        public static string file = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/data.txt";

        public static void GetAll()
        {
            if (FileSystem.Exists(file))
            {
                FileSystem.ReadData(questions, file);
            }
            else
            {
                questions.Add(new Questions("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Questions("Бревно нужно распилить на 10 частей, сколько нужно сделать распилов?", 9));
                questions.Add(new Questions("На двух руках 10 пальцев. Сколько пальцев на пяти руках?", 25));
                questions.Add(new Questions("Укол делают каждые полчаса. Сколько нужно минут для трёх уколов?", 60));
                questions.Add(new Questions("Пять свечей горело. Две потухли. Сколько осталось свечей?", 2));
                foreach (var i in questions)
                {
                    FileSystem.AppendToFile(file, $"{i.question};{i.answer}#");
                }
            }
        }

        public static void RemoveData()
        {
            FileSystem.EraseData(file);
            foreach (var i in questions)
            {
                FileSystem.AppendToFile(file, $"{i.question};{i.answer}#");
            }
        }

        public static void SaveData(Questions questions)
        {
            string text = $"{questions.question};{questions.answer}#";
            FileSystem.AppendToFile(file, text);
        }

        public static void AddQuestion(string question, int answer)
        {
            questions.Add(new Questions(question, answer));
        }

        public static void GetQuestions()
        {
            int num = 1;
            foreach (var i in QuestionsStorage.questions)
            {
                Console.WriteLine($"{num} {i.question}");
                num++;
            }
        }
    }
}
