namespace GeniusIdiotClass
{
    public class User
    {
        public string name;
        public int score;
        public string diagnose;

        public User(string Name, int Score, string Diagnose)
        {
            name = Name;
            score = Score;
            diagnose = Diagnose;
        }

        public void AcceptRightAnswer()
        {
            score++;
        }
    }
}
