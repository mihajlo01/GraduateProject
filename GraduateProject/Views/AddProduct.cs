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
    public partial class AddProduct : Form
    {
        NumericUpDown numericUpDown;
        User user;

        public AddProduct(User user)
        {
            InitializeComponent();
            this.user = user;

            if (numberedProductSize.Checked == true)
            {
                productSize.Visible = false;
                numericUpDown = new NumericUpDown();
                numericUpDown.Location = new Point(111, 120);
                numericUpDown.Name = "productSize";
                numericUpDown.Size = new Size(121, 21);
                productSize.TabIndex = 22;
                this.Controls.Add(numericUpDown);
            }
        }

        private void textProductSize_CheckedChanged(object sender, EventArgs e)
        {
            if(textProductSize.Checked == true)
            {
                numericUpDown.Visible = false;
                productSize.Visible = true;
            }
        }

        private void numberedProductSize_CheckedChanged(object sender, EventArgs e)
        {
            if (numberedProductSize.Checked == true)
            {
                productSize.Visible = false;
                numericUpDown.Visible = true;
            }
        }

        private void backToDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(user);
            Hide();
            dashboard.ShowDialog();
            Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(user);
            Hide();
            addProduct.ShowDialog();
            Close();
        }
    }
}
