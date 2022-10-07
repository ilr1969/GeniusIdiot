using System;
using System.Windows.Forms;

namespace GeniusIdiotClass
{
    public class CheckErrors
    {
        public static bool GetUserAnswer(string input, out int choice, out string exMessage)
        {
            try
            {
                choice = Convert.ToInt32(input);
                exMessage = "";
                return true;

            }
            catch
            {
                choice = 0;
                exMessage = "Введите корректное число!";
                return false;
            }
        }
    }
}
