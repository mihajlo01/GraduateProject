using GraduateProject.Logic.Controllers;
using GraduateProject.Logic.Interfaces;
using GraduateProject.Logic.Models;
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
    public partial class RemoveScanned : Form
    {
        IProductsInterface productsInterface;
        IUsersInterface usersInterface;
        Product product;
        User user;
        public RemoveScanned(Product product, User user)
        {
            InitializeComponent();
            productsInterface = new ProductsController();
            usersInterface = new UsersController();
            this.product = product;
            this.user = user;
        }

        private void RemoveScanned_Load(object sender, EventArgs e)
        {
            quantity.Maximum = Convert.ToDecimal(product.Quantity);
            productCodeLabel.Text += product.ProductCode;
            addedByLabel.Text += product.AddedBy;
            createdLabel.Text += product.TimeAdded.ToString();
            quantity.Value = Convert.ToDecimal(product.Quantity);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ProductsDashboard productsDashboard = new ProductsDashboard(user);
            Hide();
            productsDashboard.ShowDialog();
            Close();
        }

        private async void removeButton_Click(object sender, EventArgs e)
        {
            if(quantity.Value < product.Quantity && Convert.ToInt32(quantity.Value) != 0)
            {
                await productsInterface.UpdateProduct(product, Convert.ToInt32(quantity.Value));
                MessageBox.Show("Quantity updated!", "Success!", MessageBoxButtons.OK);
                backButton_Click(sender, e);
            }
            else
            {
                await productsInterface.RemoveProduct(product.Id);
                user.RemovedProductCodes = user.RemovedProductCodes != null ? user.RemovedProductCodes : new List<string>();
                user.RemovedProductCodes.Add(product.ProductCode);
                await usersInterface.UpdateUser(user._id, user);
                MessageBox.Show("Product removed successfully!", "Success!", MessageBoxButtons.OK);
                backButton_Click(sender, e);
            }
        }
    }
}
