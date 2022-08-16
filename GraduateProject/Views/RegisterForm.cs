using GraduateProject.Logic.Controllers;
using GraduateProject.Logic.Interfaces;
using GraduateProject.Models;
using System;
using System.Collections.Generic;
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

        private void ValidateRegisterForm()
        {
            if (textBoxName.Text == string.Empty || textBoxUsername.Text == string.Empty || textBoxCompanyName.Text == string.Empty || textBoxPassword.Text == string.Empty)
                MessageBox.Show("Text fields must be filled!", "Failure!", MessageBoxButtons.OK);
            else
                return;
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            ValidateRegisterForm();

            User user = new User()
            {
                Name = textBoxName.Text,
                Username = textBoxUsername.Text,
                CompanyName = textBoxCompanyName.Text,
                Password = textBoxPassword.Text,
                EnteredProductCodes = new List<string>(),
                RemovedProductCodes = new List<string>(),
                SelledProductCodes = new List<string>(),
                EditUserPermission = editUserPermission.Checked,
                AddProductPermission = addProductsPermission.Checked,
                RemoveProductPermission = removeProductsPermission.Checked,
                ProductDashboardPermission = productDashboardPermission.Checked
            };


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
    }
}
