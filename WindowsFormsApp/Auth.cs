using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Auth : Form
    {
        public string name;
        public Auth()
        {
            InitializeComponent();
        }


        private void Logon_Click(object sender, EventArgs e)
        {
            name = userName.Text;
            Auth.ActiveForm.Close();
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }
    }
}
