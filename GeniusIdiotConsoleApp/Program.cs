using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace GeniusIdiotConsoleApp
{
    class Program
    {
        public
        static void Main(string[] args)
        {
            int countQuestions = 5;
            var questions = GetQuestions();
            var answers = GetAnswers();
            string file = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/result.txt";
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes($"ФИО;Результат;Диагноз");
                fs.Write(buffer, 0, buffer.Length);
            }
            
            Console.WriteLine("Назови себя:");
            string name = Console.ReadLine();

            while (true)
            {

                Console.WriteLine("Что вы хотите сделать?");
                Console.WriteLine("1. Пройти тест.");
                Console.WriteLine("2. Показать результаты.");
                Console.WriteLine("3. Выйти.");


                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 2)
                {
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        byte[] buffer = new byte[fs.Length];
                        fs.Read(buffer, 0, buffer.Length);
                        foreach (string i in Encoding.Default.GetString(buffer).Split('\n'))
                        {
                            var t = i.Split(';');
                            Console.WriteLine($"{t[0],-10}{t[1],-10}{t[2],-10}");
                        }
                    }
                }
                if (choice == 1)
                {

                    while (true)
                    {
                        int rightAnswers = 0;
                        for (var i=1; i<=countQuestions; i++)
                        {
                            Random random = new Random();
                            int randNumber = random.Next(0, questions.Count);

                            Console.WriteLine($"Вопрос № {i}");
                            Console.WriteLine(questions[randNumber]);

                            if (GetUserAnswer() == answers[randNumber])
                            {
                                rightAnswers++;
                                questions.RemoveAt(randNumber);
                                answers.RemoveAt(randNumber);
                            }
                        }


                        Dictionary<int, string> result = new Dictionary<int, string>()
                        {
                            { 0, "Идиот"}, { 1, "Кретин"},{ 2, "Дурак"},{ 3, "Нормальный"},{ 4, "Талант"},{ 5, "Гений"}
                        };

                        Console.WriteLine($"{name}, ты - {result[rightAnswers * 5 / countQuestions]}!");

                        using (FileStream fs = new FileStream(file,FileMode.Append))
                        {
                            byte[] buffer = Encoding.Default.GetBytes("\n" + $"{name};{rightAnswers};{result[rightAnswers * 5 / countQuestions]}");
                            fs.Write(buffer, 0, buffer.Length);
                        }

                        bool userChoice = GetUserChoice();
                        if (userChoice == false)
                        {
                            break;
                        }
                    }
                }
                if (choice == 3)
                {

                    break;
                }
            }
        }

        private static int GetUserAnswer()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите корректное число!");
                }
            }
        }

        private static List<int> GetAnswers()
        {
            List<int> answers = new List<int>();
            answers.Add(6);
            answers.Add(9);
            answers.Add(25);
            answers.Add(60);
            answers.Add(2);
            return answers;
        }

        private static List<string> GetQuestions()
        {
            List<string> questions = new List<string>();
            questions.Add("Сколько будет два плюс два умноженное на два?");
            questions.Add("Бревно нужно распилить на 10 частей, сколько нужно сделать распилов?");
            questions.Add("На двух руках 10 пальцев. Сколько пальцев на пяти руках?");
            questions.Add("Укол делают каждые полчаса. Сколько нужно минут для трёх уколов?");
            questions.Add("Пять свечей горело. Две потухли. Сколько осталось свечей?");
            return questions;
        }

        public static bool GetUserChoice()
        {
            while (true)
            {
                Console.WriteLine("Желаете повторить тест? Введите Да или Нет");
                string userChoice = Console.ReadLine();
                if (userChoice.ToLower() == "нет")
                {
                    return false;
                }
                if (userChoice.ToLower() == "да")
                {
                    return true;
                }
            }
        }
    }
}
