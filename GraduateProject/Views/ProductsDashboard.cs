using GraduateProject.Logic.Controllers;
using GraduateProject.Logic.Interfaces;
using GraduateProject.Logic.Models;
using GraduateProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GraduateProject.Views
{
    public partial class ProductsDashboard : Form
    {
        User user;
        IProductsInterface productsInterface;
        IUsersInterface usersInterface;
        public static string ProductCode = "0";
        public ProductsDashboard(User user)
        {
            InitializeComponent();
            productsInterface = new ProductsController();
            usersInterface = new UsersController();
            this.user = user;
        }

        private async void ProductsDashboard_Load(object sender, EventArgs e)
        {
            var products = await productsInterface.GetAllProducts();
            productsDataView.DataSource = products;
            userLabel.Text += user.Username;
            nameLabel.Text += user.Name;
            companyNameLabel.Text += user.CompanyName;
            enteredProductsLabel.Text += user.EnteredProductCodes.Count;
            selledProductsLabel.Text += user.SelledProductCodes.Count;
            removedProductsLabel.Text += user.RemovedProductCodes.Count;
        }

        private void backToDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(user);
            Hide();
            dashboard.ShowDialog();
            Close();
        }

        private async void removeSelectedProducts_Click(object sender, EventArgs e)
        {
            if (productsDataView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in productsDataView.SelectedRows)
                {
                    var removedProduct = await productsInterface.RemoveProduct((MongoDB.Bson.ObjectId)row.Cells[0].Value);
                    if (removedProduct != null)
                    {
                        var fetchedUser = await usersInterface.GetUserByUsername(user.Username);
                        fetchedUser.RemovedProductCodes.Add(removedProduct.ProductCode);
                        if (fetchedUser != null)
                        {
                            await usersInterface.UpdateUser(fetchedUser._id, fetchedUser);
                            user = await usersInterface.GetUserById(fetchedUser._id);
                            removedProductsLabel.Text = "Removed Products:  " + user.RemovedProductCodes.Count;
                        }
                    }
                    else
                        MessageBox.Show("Product removement has failed!", "Failure", MessageBoxButtons.OK);
                }
                productsDataView.Refresh();
                var products = await productsInterface.GetAllProducts();
                productsDataView.DataSource = products;
            }
            else
                MessageBox.Show("Please select products to remove!", "Failure", MessageBoxButtons.OK);
        }

        private void productInformationButton_Click(object sender, EventArgs e)
        {
            Scanner scanner = new Scanner();
            scanner.ShowDialog();
            ProductCode = Scanner.SetProductCode;
            Product product = productsInterface.GetProductByProductCode((long)Convert.ToInt64(ProductCode)).Result;
            if (product != null)
            {
                ProductInformation productInformation = new ProductInformation(product, user);
                Hide();
                productInformation.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Product could not be found!", "Failure!", MessageBoxButtons.OK);
            }
        }
    }
}
