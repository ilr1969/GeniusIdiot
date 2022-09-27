using System.Collections.Generic;

namespace GeniusIdiotConsoleApp
{
    public class QuestionsStorage
    {
        public static List<Questions> GetAll()
        {
            var questions = new List<Questions>();
            questions.Add(new Questions("Сколько будет два плюс два умноженное на два?", 6));
            questions.Add(new Questions("Бревно нужно распилить на 10 частей, сколько нужно сделать распилов?", 9));
            questions.Add(new Questions("На двух руках 10 пальцев. Сколько пальцев на пяти руках?", 25));
            questions.Add(new Questions("Укол делают каждые полчаса. Сколько нужно минут для трёх уколов?", 60));
            questions.Add(new Questions("Пять свечей горело. Две потухли. Сколько осталось свечей?", 2));
            return questions;
        }
    }
}
