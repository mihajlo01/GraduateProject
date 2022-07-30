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
        static bool IsRemove = false;
        public static string SetProductCode = "0";
        public Scanner(bool isRemoveProduct = false)
        {
            InitializeComponent();
            IsRemove = isRemoveProduct;
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
            if(IsRemove)
            {
                //Scanner.ActiveForm.Size = new Size().Height =;
            }
        }
    }
}
