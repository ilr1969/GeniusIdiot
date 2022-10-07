using System;

namespace GeniusIdiotClass
{
    public class CheckErrors
    {
        public static int GetUserAnswer()
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
