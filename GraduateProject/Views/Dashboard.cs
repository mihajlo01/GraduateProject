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
    public partial class Dashboard : Form
    {
        User user;

        public Dashboard(User user)
        {
            InitializeComponent();
            this.user = user;
            if (!user.ProductDashboardPermission || !user.RemoveProductPermission)
                productsDashboardButton.Enabled = false;
            if (!user.AddProductPermission)
            {
                manuallyAddProductButton.Enabled = false;
                automaticallyAddProductButton.Enabled = false;
            }
            if (!user.EditUserPermission)
                editUserButton.Enabled = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text += user.Name + "!";
        }

        private void manuallyAddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(user);
            Hide();
            addProduct.ShowDialog();
            Close();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            EditAcount editAcount = new EditAcount(user);
            Hide();
            editAcount.ShowDialog();
            Close();
        }
    }
}
