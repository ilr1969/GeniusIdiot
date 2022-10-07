using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeniusIdiotClass;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private static List<Questions> questions;
        private static Questions currentQuestion;
        Results results = new Results();
        Auth auth = new Auth();
        private User user;
        int countQuestions = 5;
        private int questionNum = 1;

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
            if (CheckErrors.GetUserAnswer(answer.Text, out int num, out string exMesage))
            {
                user.AcceptRightAnswer();
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
            if (questions.Count == 0)
            {
                var diagnose = Results.GetResults(user, countQuestions);
                user = new User(auth.name, user.score, diagnose);
                MessageBox.Show($"{auth.name}, ты - {diagnose}!");
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
