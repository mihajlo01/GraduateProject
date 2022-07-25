using GraduateProject.Logic.Controllers;
using GraduateProject.Logic.Interfaces;
using GraduateProject.Models;
using System;
using System.Windows.Forms;

namespace GraduateProject.Views
{
    public partial class ProductsDashboard : Form
    {
        User user;
        IProductsInterface productsInterface;
        public ProductsDashboard(User user)
        {
            InitializeComponent();
            productsInterface = new ProductsController();
            this.user = user;
        }

        private async void ProductsDashboard_Load(object sender, EventArgs e)
        {
            var products = await productsInterface.GetAllProducts();
            productsDataView.DataSource = products;
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
                    if (productsInterface.RemoveProduct((MongoDB.Bson.ObjectId)row.Cells[0].Value))
                        continue;
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
    }
}
