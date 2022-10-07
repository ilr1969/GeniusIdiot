using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniusIdiotConsoleApp;

namespace WindowsFormsApp
{
    public partial class addQuestion : Form
    {
        public string question;
        public int answer;
        public addQuestion()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            question = questionTextBox.Text;
            answer = Convert.ToInt32(answerTextBox.Text);
            QuestionsStorage.AddQuestion(question, answer);
            QuestionsStorage.SaveData(new Questions(question, answer));
            this.Close();
        }
    }
}
