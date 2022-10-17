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
    public partial class ShowAnswers : Form
    {
        
        public ShowAnswers()
        {
            InitializeComponent();
        }

        private void ShowAnswers_Load(object sender, EventArgs e)
        {
            List<Questions> questions = QuestionsStorage.GetAll();
            int num = 0;
            foreach (var i in questions)
            {
                showAnswersDataGridView.Rows.Add();
                showAnswersDataGridView.Rows[num].Cells[0].Value = i.question;
                showAnswersDataGridView.Rows[num].Cells[1].Value = i.answer;
                num++;
            }
        }
    }
}
