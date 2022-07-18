using GraduateProject.Logic.Controllers;
using GraduateProject.Logic.Interfaces;
using GraduateProject.Views;
using System;
using System.Windows.Forms;

namespace GraduateProject
{
    public partial class Login : Form
    {
        IUsersInterface usersInterface;

        public Login()
        {
            InitializeComponent();
            usersInterface = new UsersController();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private async void password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginUser();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            Hide();
            registerForm.ShowDialog();
            Close();
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginUser();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void LoginUser()
        {
            var user = await usersInterface.ValidateUserLogin(username.Text, password.Text);
            if (user != null)
            {
                Dashboard navWindow = new Dashboard(user);
                Hide();
                navWindow.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!", "Failed to login!", MessageBoxButtons.OK);
                username.Clear();
                password.Clear();
            }
        }
    }
}
