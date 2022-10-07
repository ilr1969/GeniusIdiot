using System;

namespace GeniusIdiotClass
{
    public class Questions
    {
        public string question;
        public int answer;

        public Questions(string q, int a)
        {
            question = q;
            answer = a;
        }

        public void PrintQuestion()
        {
            Console.WriteLine(question);
        }
    }
}
