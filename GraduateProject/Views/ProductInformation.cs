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
    public partial class ProductInformation : Form
    {
        User user;
        Product product;
        public ProductInformation(Product product, User user)
        {
            InitializeComponent();
            this.user = user;
            this.product = product;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsDashboard productsDashboard = new ProductsDashboard(user);
            Hide();
            productsDashboard.ShowDialog();
            Close();
        }

        private void ProductInformation_Load(object sender, EventArgs e)
        {
            productTypeLabel.Text += product.ProductType;
            providerLabel.Text += product.Provider;
            productSizeLabel.Text += product.ProductSize.ToString();
            quantityLabel.Text += product.Quantity.ToString();
            colorLabel.Text += product.Color;
            productCodeLabel.Text += product.ProductCode.ToString();
            priceLabel.Text += product.Price.ToString();
            isProductAvailableLabel.Text += product.IsProductAvailable.ToString();
        }
    }
}
