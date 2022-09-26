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
            string[] questions = GetQuestions(countQuestions);
            int[] answers = GetAnswers(countQuestions);
            string file = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/result.txt";
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes($"ФИО       Результат Диагноз   " + "\n");
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
                        string res = Encoding.Default.GetString(buffer);
                        Console.WriteLine(res);
                    }
                }
                if (choice == 1)
                {

                    while (true)
                    {
                        int rightAnswers = 0;
                        int i = 1;

                        Random random = new Random();
                        List<int> randRange = new List<int>();

                        while (randRange.Count < countQuestions)
                        {
                            int randNumber = random.Next(0, countQuestions);
                            if (!randRange.Contains(randNumber))
                            {
                                randRange.Add(randNumber);
                                Console.WriteLine($"Вопрос № {i}");
                                i++;
                                Console.WriteLine(questions[randNumber]);

                                int answer = -1;
                                try
                                {
                                    answer = Convert.ToInt32(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("Введите только число!");
                                }

                                if (answer == answers[randNumber])
                                {
                                    rightAnswers++;
                                }
                            }
                        }


                        Dictionary<int, string> result = new Dictionary<int, string>()
                        {
                            { 0, "Идиот"}, { 1, "Кретин"},{ 2, "Дурак"},{ 3, "Нормальный"},{ 4, "Талант"},{ 5, "Гений"}
                        };

                        Console.WriteLine($"{name}, ты - {result[rightAnswers * 5 / countQuestions]}!");

                        using (FileStream fs = new FileStream(file,FileMode.Append))
                        {
                            byte[] buffer = Encoding.Default.GetBytes($"{name, -10}{rightAnswers, -10}{result[rightAnswers * 5 / countQuestions], -10}" + "\n");
                            fs.Write(buffer, 0, buffer.Length);
                        }

                            Thread.Sleep(1000);

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

        private static int[] GetAnswers(int countQuestions)
        {
            int[] answers = new int[countQuestions];
            answers[0] = 6;
            answers[1] = 9;
            answers[2] = 25;
            answers[3] = 60;
            answers[4] = 2;
            return answers;
        }

        private static string[] GetQuestions(int countQuestions)
        {
            string[] questions = new string[countQuestions];
            questions[0] = "Сколько будет два плюс два умноженное на два?";
            questions[1] = "Бревно нужно распилить на 10 частей, сколько нужно сделать распилов?";
            questions[2] = "На двух руках 10 пальцев. Сколько пальцев на пяти руках?";
            questions[3] = "Укол делают каждые полчаса. Сколько нужно минут для трёх уколов?";
            questions[4] = "Пять свечей горело. Две потухли. Сколько осталось свечей?";
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
