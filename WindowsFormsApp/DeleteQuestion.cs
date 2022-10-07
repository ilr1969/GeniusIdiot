using System;
using System.Windows.Forms;
using GeniusIdiotConsoleApp;

namespace WindowsFormsApp
{
    public partial class DeleteQuestion : Form
    {
        public DeleteQuestion()
        {
            InitializeComponent();
        }

        private void DeleteQuestion_Load(object sender, EventArgs e)
        {
            int num = 1;
            foreach (var i in QuestionsStorage.questions)
            {
                questionsRichTextBox.AppendText(num + " " + i.question + "\n");
                num++;
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            QuestionsStorage.questions.RemoveAt(Convert.ToInt32(numToDelTextBox.Text) - 1);
            QuestionsStorage.RemoveData();
            this.Close();
        }
    }
}
