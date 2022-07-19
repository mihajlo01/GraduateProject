using GraduateProject.Logic.Controllers;
using GraduateProject.Logic.Interfaces;
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
    public partial class ProductsDashboard : Form
    {
        IProductsInterface productsInterface;
        public ProductsDashboard()
        {
            InitializeComponent();
            productsInterface = new ProductsController();
        }

        private async void ProductsDashboard_Load(object sender, EventArgs e)
        {
            var products = await productsInterface.GetAllProducts();
            productsDataView.DataSource = products;
        }
    }
}
