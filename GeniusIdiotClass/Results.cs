using System.Collections.Generic;

namespace GeniusIdiotClass
{
    public class Results
    {
        public static Dictionary<int, string> dictResults = new Dictionary<int, string>
        {
            { 0, "Идиот"}, { 1, "Кретин"},{ 2, "Дурак"},{ 3, "Нормальный"},{ 4, "Талант"},{ 5, "Гений"}
        };
        public static string GetResults(User user, int countQuestions)
        {
            return dictResults[user.score * 5 / countQuestions];
        }
    }
}
