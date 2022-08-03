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
    public partial class Scanner : Form
    {
        User user;
        static bool IsRemove = false;
        public static string SetProductCode;
        public static bool IsClosed;
        public Scanner(User user, bool isRemoveProduct = false)
        {
            InitializeComponent();
            this.user = user;
            IsRemove = isRemoveProduct;
            SetProductCode = "0";
            IsClosed = false;
        }

        private async void scannedCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (scannedCode.Text.Length > 0)
            {
                await Task.Delay(1000);
                SetProductCode = scannedCode.Text;
                Close();
            }
        }

        private void Scanner_Load(object sender, EventArgs e)
        {
            if(!IsRemove)
            {
                Size = new Size(278, 118);
                orLabel.Visible = false;
                enterProductManuallyLabel.Visible = false;
                manualProductCode.Visible = false;
                useBarcodeScannerLabel.Visible = false;
            }
        }

        private void manualProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SetProductCode = manualProductCode.Text;
                Close();
            }
            if(e.KeyCode == Keys.Escape)
                scannedCode.Focus();
        }

        private void Scanner_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(SetProductCode == "0")
                IsClosed = true;
        }

        private void Scanner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                scannedCode.Focus();
        }
    }
}
