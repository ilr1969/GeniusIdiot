using System;
using System.Collections.Generic;
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
            ShowNextQuestion();

            user = new User(auth.name, 0, "");
        }

        private void ShowNextQuestion()
        {
            Random random = new Random();
            randNumber = random.Next(0, questions.Count);
            currentQuestion = questions[randNumber];
            QuestionNumber.Text = "Вопрос № " + questionNum;
            questionNum++;
            questionBox.Text = questions[randNumber].question;
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
            ShowNextQuestion();
        }

        private void показатьОтветыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAnswers showAnswers = new ShowAnswers();
            showAnswers.ShowDialog();
        }
    }
}
