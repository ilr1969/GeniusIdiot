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
            foreach (var i in UserStorage.GetUsersResults())
            {
                showResultsRichTextBox.Text += $"{i.name, -10}{i.score, -10}{i.diagnose, -10}" + "\n";
            }
        }
    }
}
