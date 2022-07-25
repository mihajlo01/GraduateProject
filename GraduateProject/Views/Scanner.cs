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
        public static string SetProductCode = "0";
        public Scanner()
        {
            InitializeComponent();
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
    }
}
