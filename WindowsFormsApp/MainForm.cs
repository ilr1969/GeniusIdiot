using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using GeniusIdiotClass;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private static List<Questions> questions = QuestionsStorage.GetAll();
        private static List<User> userList = UserStorage.GetUsersResults();
        private static Questions currentQuestion;
        Auth auth = new Auth();
        private User user;
        private int countQuestions = 5;
        private int questionNum = 1;
        private int randNumber;
        TimeSpan totalTime = new TimeSpan(0, 0, 0, 10);

        public MainForm()
        {
            InitializeComponent();
            this.ActiveControl = answer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            auth.Owner = this;
            auth.ShowDialog();
            ShowNextQuestion();
            user = new User(auth.name, 0, "Неизвестный");
        }

        private void ShowNextQuestion()
        {
            Random random = new Random();
            randNumber = random.Next(0, questions.Count);
            currentQuestion = questions[randNumber];
            QuestionNumber.Text = "Вопрос № " + questionNum;
            questionNum++;
            questionBox.Text = questions[randNumber].question;
            totalTime = new TimeSpan(0, 0, 0, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckErrors.GetUserAnswer(answer.Text, out int num, out string exMesage))
            {
                if (Convert.ToInt32(answer.Text) == questions[randNumber].answer)
                {
                    user.AcceptRightAnswer();
                }
            }
            else
            {
                answer.Text = "";
                MessageBox.Show(exMesage);
                return;
            }
            answer.Text = "";
            this.ActiveControl = answer;
            questions.Remove(currentQuestion);
            if (questionNum - 1 == countQuestions)
            {
                var diagnose = Results.GetResults(user, countQuestions);
                userList.Add(new User(auth.name, user.score, diagnose));
                MessageBox.Show($"{auth.name}, ты - {diagnose}!");
                UserStorage.SaveUserResults(userList);
                questions = QuestionsStorage.GetAll();
                user.score = 0;
                timer.Stop();
            }
            ShowNextQuestion();
        }

        private void выходStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void показатьРезультатыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowResults showResult = new ShowResults();
            showResult.ShowDialog();
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addQuestion addquestion = new addQuestion();
            addquestion.ShowDialog();
        }

        private void удалитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteQuestion delQuestion = new DeleteQuestion();
            delQuestion.ShowDialog();
        }

        private void пройтиТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            questionNum = 1;
            questions = QuestionsStorage.GetAll();
            MessageBox.Show("На каждый ответ даётся 10 секунд, иначе ответ не будет засчитан!");
            timer.Start();
            ShowNextQuestion();
        }

        private void показатьОтветыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAnswers showAnswers = new ShowAnswers();
            showAnswers.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            totalTime = totalTime.Subtract(new TimeSpan(0, 0, 0, 1));
            timerLabel.Text = $"Оставшееся время: {totalTime.ToString()}";
            if (totalTime.Seconds == 0)
            {
                answer.Text = "0";
                NextButton.PerformClick();
            }
        }

        private void начатьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("На каждый ответ даётся 10 секунд, иначе ответ не будет засчитан!");
            totalTime = new TimeSpan(0, 0, 0, 10);
            timerLabel.Text = $"Оставшееся время: {totalTime.ToString()}";
            timer.Start();
            timer.Interval = 1000;
            ShowNextQuestion();
        }
    }
}
