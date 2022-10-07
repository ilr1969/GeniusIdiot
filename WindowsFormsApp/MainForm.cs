using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeniusIdiotConsoleApp;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private static List<Questions> questions;
        private static Questions currentQuestion;
        Auth auth = new Auth();
        private User user;
        int countQuestions = 5;
        private int questionNum = 1;
        Dictionary<int, string> result = new Dictionary<int, string>()
        {
            { 0, "Идиот"}, { 1, "Кретин"},{ 2, "Дурак"},{ 3, "Нормальный"},{ 4, "Талант"},{ 5, "Гений"}
        };

        public MainForm()
        {
            InitializeComponent();
            this.ActiveControl = answer;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            auth.Owner = this;
            auth.ShowDialog();

            QuestionsStorage.GetAll();
            questions = QuestionsStorage.questions;
            ShowNextQuestion();

            user = new User(auth.name, 0, "");
        }

        private void ShowNextQuestion()
        {
            Random random = new Random();
            int randNumber = random.Next(0, questions.Count);
            currentQuestion = questions[randNumber];
            QuestionNumber.Text = "Вопрос № " + questionNum;
            questionNum++;
            questionBox.Text = questions[randNumber].question;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var answ = Convert.ToInt32(answer.Text);
            if (answ == currentQuestion.answer)
            {
                user.AcceptRightAnswer();
            }
            answer.Text = "";
            this.ActiveControl = answer;
            questions.Remove(currentQuestion);
            if (questions.Count == 0)
            {
                user = new User(auth.name, user.score, result[user.score * 5 / countQuestions]);
                MessageBox.Show($"{auth.name}, ты - {result[user.score * 5 / countQuestions]}!");
                UserStorage.SaveUserResults(user);
                QuestionsStorage.RemoveData();
                QuestionsStorage.GetAll();
                return;
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
            showResult.Show();
            showResult.BringToFront();
        }

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addQuestion addquestion = new addQuestion();
            addquestion.Owner = this;
            addquestion.Show();
            addquestion.BringToFront();
        }

        private void удалитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteQuestion delQuestion = new DeleteQuestion();
            delQuestion.Owner = this;
            delQuestion.Show();
            delQuestion.BringToFront();
        }

        private void пройтиТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            questionNum = 1;
            ShowNextQuestion();
        }
    }
}
