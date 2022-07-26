using GraduateProject.Logic.Controllers;
using GraduateProject.Logic.Interfaces;
using GraduateProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduateProject.Views
{
    public partial class EditAcount : Form
    {
        User user;
        IUsersInterface usersInterface;
        IPasswordInterface passwordInterface;

        public EditAcount(User user)
        {
            InitializeComponent();
            this.user = user;
            usersInterface = new UsersController();
            passwordInterface = new PasswordController();
        }

        private void EditAcount_Load(object sender, EventArgs e)
        {
            textBoxName.Text = user.Name;
            textBoxUsername.Text = user.Username;
            textBoxCompanyName.Text = user.CompanyName;
            editUserPermission.Checked = user.EditUserPermission;
            addProductsPermission.Checked = user.AddProductPermission;
            removeProductsPermission.Checked = user.RemoveProductPermission;
            productDashboardPermission.Checked = user.ProductDashboardPermission;
        }

        private void backToDashboardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(user);
            Hide();
            dashboard.ShowDialog();
            Close();
        }

        private async void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 1)
            {
                MessageBox.Show("Please enter your password in order to save the changes!", "Required password!", MessageBoxButtons.OK);
                EditAcount dashboard = new EditAcount(user);
                Hide();
                dashboard.ShowDialog();
                Close();
            }
            else
            {
                var oldUser = await usersInterface.ValidateUserLogin(user.Username, textBoxPassword.Text);
                if (oldUser != null)
                {
                    User userToUpdate = new User();
                    userToUpdate._id = oldUser._id;
                    userToUpdate.Name = textBoxName.Text;
                    userToUpdate.Username = textBoxUsername.Text;
                    userToUpdate.CompanyName = textBoxCompanyName.Text;
                    userToUpdate.EditUserPermission = editUserPermission.Checked;
                    userToUpdate.AddProductPermission = addProductsPermission.Checked;
                    userToUpdate.RemoveProductPermission = removeProductsPermission.Checked;
                    userToUpdate.ProductDashboardPermission = productDashboardPermission.Checked;
                    if (textBoxNewPassword.Text.Length > 0)
                        userToUpdate.Password = passwordInterface.CreatePassword(textBoxNewPassword.Text);
                    else
                        userToUpdate.Password = oldUser.Password;

                    var updatedUser = await usersInterface.UpdateUser(oldUser._id, userToUpdate);
                    if (updatedUser != null)
                    {
                        MessageBox.Show("Successfully updated user!", "Success!", MessageBoxButtons.OK);
                        Dashboard navWindow = new Dashboard(userToUpdate);
                        Hide();
                        navWindow.ShowDialog();
                        Close();
                    }
                    else
                        MessageBox.Show("Failed to update!", "Failure!", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("User is not found or the entered password is incorect!", "Failure!", MessageBoxButtons.OK);
            }
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

        private void textBoxNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private async void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length < 1)
            {
                MessageBox.Show("Please enter your password in order to save the changes!", "Required password!", MessageBoxButtons.OK);
                EditAcount dashboard = new EditAcount(user);
                Hide();
                dashboard.ShowDialog();
                Close();
            }
            else
            {
                var oldUser = await usersInterface.ValidateUserLogin(user.Username, textBoxPassword.Text);
                if (oldUser != null)
                {
                    DialogResult result = MessageBox.Show("Are you sure that you want to delete this user?", "Delete User", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (await usersInterface.DeleteUser(user._id))
                        {
                            MessageBox.Show("User has been deleted successfully!", "Success", MessageBoxButtons.OK);
                            Login login = new Login();
                            Hide();
                            login.ShowDialog();
                            Close();
                        }
                    }
                    else
                        return;
                }
                else
                    MessageBox.Show("User is not found or the entered password is incorect!", "Failure!", MessageBoxButtons.OK);
            }
        }
    }
}
