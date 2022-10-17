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
    public partial class ShowResults : Form
    {
        public static List<User> results = UserStorage.GetUsersResults();
        public ShowResults()
        {
            InitializeComponent();
        }

        private void showResultsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowResults_Load(object sender, EventArgs e)
        {
            int num = 0;
            foreach (var i in results)
            {
                showResultsDataGridView.Rows.Add();
                showResultsDataGridView.Rows[num].Cells[0].Value = i.name;
                showResultsDataGridView.Rows[num].Cells[1].Value = i.score;
                showResultsDataGridView.Rows[num].Cells[2].Value = i.diagnose;
                num++;
            }
        }
    }
}
