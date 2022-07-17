using GraduateProject.Logic.Controllers;
using GraduateProject.Logic.Interfaces;
using GraduateProject.Models;
using System;
using System.Windows.Forms;

namespace GraduateProject
{
    public partial class RegisterForm : Form
    {
        IUsersInterface usersInterface;

        public RegisterForm()
        {
            InitializeComponent();
            usersInterface = new UsersController();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = textBoxName.Text;
            user.Username = textBoxUsername.Text;
            user.CompanyName = textBoxCompanyName.Text;
            user.Password = textBoxPassword.Text;
            user.EditUserPermission = editUserPermission.Checked;
            user.AddProductPermission = addProductsPermission.Checked;
            user.RemoveProductPermission = removeProductsPermission.Checked;
            user.ProductDashboardPermission = productDashboardPermission.Checked;


            if (await usersInterface.InsertUser(user))
            {
                MessageBox.Show("Successfully created new user!", "Success!", MessageBoxButtons.OK);

                Login login = new Login();
                Hide();
                login.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Failed to create new user!\nUser already exists!", "Failure!", MessageBoxButtons.OK);
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.ShowDialog();
            Close();
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxCompanyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
