using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniusIdiotClass;

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
            if (CheckErrors.GetUserAnswer(answerTextBox.Text, out int choice, out string exMessage))
            {
                answer = choice;
            }
            else
            {
                MessageBox.Show(exMessage);
                return;
            }
            QuestionsStorage.AddQuestion(question, answer);
/*            QuestionsStorage.RemoveData();
            QuestionsStorage.SaveData();*/
            this.Close();
        }

        private void addQuestion_Load(object sender, EventArgs e)
        {
            
        }
    }
}
