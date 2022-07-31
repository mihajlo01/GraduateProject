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
            enteredProductsLabel.Text += user.EnteredProductCodes != null ? user.EnteredProductCodes.Count : 0;
            selledProductsLabel.Text += user.SelledProductCodes != null ? user.SelledProductCodes.Count : 0;
            removedProductsLabel.Text += user.RemovedProductCodes != null ? user.RemovedProductCodes.Count : 0;
            if (!user.RemoveProductPermission)
            {
                removeSelectedProducts.Enabled = false;
                scanToRemoveButton.Enabled = false;
            }
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

        private async void productInformationButton_Click(object sender, EventArgs e)
        {
            Scanner scanner = new Scanner(true);
            scanner.ShowDialog();
            ProductCode = Scanner.SetProductCode;
            Product product = await productsInterface.GetProductByProductCode(ProductCode.ToUpper());
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

        private async void scanToRemoveButton_Click(object sender, EventArgs e)
        {
            Scanner scanner = new Scanner(true);
            scanner.ShowDialog();
            ProductCode = Scanner.SetProductCode;
            Product product = await productsInterface.GetProductByProductCode(ProductCode.ToUpper());
            if (product == null)
                MessageBox.Show("Product is not found!", "Failure", MessageBoxButtons.OK);
            else
            {
                RemoveScanned removeScanned = new RemoveScanned(product, user);
                Hide();
                removeScanned.ShowDialog();
                Close();
                user = await usersInterface.GetUserById(user._id);
                removedProductsLabel.Text = "Removed Products:  " + user.RemovedProductCodes.Count;
            }
        }
    }
}
