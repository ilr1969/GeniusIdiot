using System;
using System.Collections.Generic;

namespace GeniusIdiotConsoleApp
{
    partial class Program
    {
        public static void Main(string[] args)
        {
            var userStorage = new List<User>();
            int countQuestions = 5;
            var questions = QuestionsStorage.questions;
            QuestionsStorage.GetAll();

            Console.WriteLine("Назови себя:");
            string name = Console.ReadLine();
            var user = new User(name, 0, "Неизвестен");

            while (true)
            {

                Console.WriteLine("Что вы хотите сделать?");
                Console.WriteLine("1. Пройти тест.");
                Console.WriteLine("2. Показать результаты.");
                Console.WriteLine("3. Добавить вопрос.");
                Console.WriteLine("4. Удалить вопрос.");
                Console.WriteLine("0. Выйти.");


                int choice = GetUserAnswer();

                if (choice == 1)
                {
                    while (true)
                    {
                        for (var i = 1; i <= countQuestions; i++)
                        {
                            Random random = new Random();
                            int randNumber = random.Next(0, questions.Count);

                            Console.WriteLine($"Вопрос № {i}");
                            Console.WriteLine(questions[randNumber].question);

                            if (GetUserAnswer() == questions[randNumber].answer)
                            {
                                user.AcceptRightAnswer();
                            }
                            questions.RemoveAt(randNumber);
                        }

                        Dictionary<int, string> result = new Dictionary<int, string>()
                        {
                            { 0, "Идиот"}, { 1, "Кретин"},{ 2, "Дурак"},{ 3, "Нормальный"},{ 4, "Талант"},{ 5, "Гений"}
                        };

                        Console.WriteLine($"{name}, ты - {result[user.score * 5 / countQuestions]}!");
                        user.diagnose = result[user.score * 5 / countQuestions];
                        userStorage.Add(new User(user.name, user.score, user.diagnose));

                        UserStorage.SaveUserResults(user);
                        QuestionsStorage.RemoveData();
                        QuestionsStorage.GetAll();

                        bool userChoice = GetUserChoice();
                        if (userChoice == false)
                        {
                            break;
                        }
                    }
                }

                if (choice == 2)
                {
                    PrintUsersResults();
                }

                if (choice == 3)
                {
                    Console.WriteLine("Введите вопрос:");
                    var question = Console.ReadLine();
                    Console.WriteLine("Введите ответ:");
                    var answer = GetUserAnswer();
                    QuestionsStorage.AddQuestion(question, answer);
                    QuestionsStorage.SaveData(new Questions(question, answer));
                }

                if (choice == 4)
                {
                    Console.WriteLine("Выберите номер вопроса для удаления:");
                    QuestionsStorage.GetQuestions();
                    var numToDel  = GetUserAnswer();
                    QuestionsStorage.questions.RemoveAt(numToDel-1);
                    QuestionsStorage.RemoveData();
                }

                if (choice == 0)
                {
                    break;
                }
            }
        }

        private static void PrintUsersResults()
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}", "Имя", "Баллы" , "Результат");
            var result = UserStorage.GetUsersResults();
            {
                foreach (var user in result)
                {
                    Console.WriteLine($"{user.name, -10}{user.score, -10}{user.diagnose, -10}");
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
