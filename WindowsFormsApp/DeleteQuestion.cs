using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeniusIdiotClass;

namespace WindowsFormsApp
{
    public partial class DeleteQuestion : Form
    {
        public static string file = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/data.json";
        public static List<Questions> questionList = QuestionsStorage.GetAll();
        public DeleteQuestion()
        {
            InitializeComponent();
        }

        private void DeleteQuestion_Load(object sender, EventArgs e)
        {
/*            QuestionsStorage.GetAll();*/
            ShowResults();
        }

        private void ShowResults()
        {
            int num = 0;
            foreach (var i in questionList)
            {
                questionsDataGridView.Rows.Add();
                questionsDataGridView.Rows[num].Cells[0].Value = i.question;
                num++;
            }
        }

        private void delButton1_Click(object sender, EventArgs e)
        {
            int rowIndex = questionsDataGridView.CurrentRow.Index;
            questionList.RemoveAt(rowIndex);
            QuestionsStorage.SaveData(questionList);
            questionsDataGridView.Rows.RemoveAt(rowIndex);
            questionsDataGridView.Refresh();

            //QuestionsStorage.SaveData;

            //ShowResults();
            //this.Close();
        }
    }
}
