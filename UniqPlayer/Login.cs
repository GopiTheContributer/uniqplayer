using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniqPlayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                ShowValidationMessage("All fields are mandatory");
                return;
            }

            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();

                Form form = new UniqPlayer(); 
                form.ShowDialog();
            }
            else
            {
                ShowValidationMessage("username and password is incorrect");
                return;
            }
        }

        private void ShowValidationMessage(string message)
        {
            MessageBox.Show(message, "UniqPlayer - Guvi", MessageBoxButtons.OK);
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtUsername.Focus();
        }
    }
}
