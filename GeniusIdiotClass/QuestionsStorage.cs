using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeniusIdiotClass
{
    public class QuestionsStorage
    {
        public static List<Questions> questions = new List<Questions>();
        public static string file = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/data.json";

        public static List<Questions> GetAll()
        {
            if (FileSystem.Exists(file))
            {
                questions = FileSystem.ReadData(file);
                return questions;
            }
            else
            {
                questions.Add(new Questions("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Questions("Бревно нужно распилить на 10 частей, сколько нужно сделать распилов?", 9));
                questions.Add(new Questions("На двух руках 10 пальцев. Сколько пальцев на пяти руках?", 25));
                questions.Add(new Questions("Укол делают каждые полчаса. Сколько нужно минут для трёх уколов?", 60));
                questions.Add(new Questions("Пять свечей горело. Две потухли. Сколько осталось свечей?", 2));
                var data = JsonConvert.SerializeObject(questions);
                FileSystem.AppendToFile(file, data);
                return questions;
            }
        }

        public static void RemoveData()
        {
            FileSystem.EraseData(file);
        }

        public static void SaveData(List<Questions> questions)
        {
            RemoveData();
            string text = JsonConvert.SerializeObject(questions); 
            FileSystem.AppendToFile(file, text);
        }

        public static void AddQuestion(string question, int answer)
        {
            questions.Add(new Questions(question, answer));
            SaveData(questions);
        }

        public static void GetQuestions()
        {
            int num = 1;
            foreach (var i in QuestionsStorage.GetAll())
            {
                Console.WriteLine($"{num} {i.question}");
                num++;
            }
        }
    }
}
