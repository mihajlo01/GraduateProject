
namespace GraduateProject.Views
{
    partial class Scanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scannedCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enterProductManuallyLabel = new System.Windows.Forms.Label();
            this.manualProductCode = new System.Windows.Forms.TextBox();
            this.orLabel = new System.Windows.Forms.Label();
            this.useBarcodeScannerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scannedCode
            // 
            this.scannedCode.BackColor = System.Drawing.SystemColors.Menu;
            this.scannedCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scannedCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.scannedCode.Location = new System.Drawing.Point(-42, -11);
            this.scannedCode.Name = "scannedCode";
            this.scannedCode.Size = new System.Drawing.Size(184, 13);
            this.scannedCode.TabIndex = 0;
            this.scannedCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scannedCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Use your barcode scanner";
            // 
            // enterProductManuallyLabel
            // 
            this.enterProductManuallyLabel.AutoSize = true;
            this.enterProductManuallyLabel.Location = new System.Drawing.Point(38, 68);
            this.enterProductManuallyLabel.Name = "enterProductManuallyLabel";
            this.enterProductManuallyLabel.Size = new System.Drawing.Size(120, 13);
            this.enterProductManuallyLabel.TabIndex = 2;
            this.enterProductManuallyLabel.Text = "Enter Product Manually:";
            // 
            // manualProductCode
            // 
            this.manualProductCode.Location = new System.Drawing.Point(41, 85);
            this.manualProductCode.Name = "manualProductCode";
            this.manualProductCode.Size = new System.Drawing.Size(183, 20);
            this.manualProductCode.TabIndex = 3;
            this.manualProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manualProductCode_KeyDown);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(38, 51);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(23, 13);
            this.orLabel.TabIndex = 4;
            this.orLabel.Text = "OR";
            // 
            // useBarcodeScannerLabel
            // 
            this.useBarcodeScannerLabel.AutoSize = true;
            this.useBarcodeScannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useBarcodeScannerLabel.Location = new System.Drawing.Point(39, 108);
            this.useBarcodeScannerLabel.Name = "useBarcodeScannerLabel";
            this.useBarcodeScannerLabel.Size = new System.Drawing.Size(147, 12);
            this.useBarcodeScannerLabel.TabIndex = 5;
            this.useBarcodeScannerLabel.Text = "Press Esc to use BarcodeScanner!";
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 133);
            this.Controls.Add(this.useBarcodeScannerLabel);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.manualProductCode);
            this.Controls.Add(this.enterProductManuallyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scannedCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Scanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Scanner_FormClosed);
            this.Load += new System.EventHandler(this.Scanner_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Scanner_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox scannedCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enterProductManuallyLabel;
        private System.Windows.Forms.TextBox manualProductCode;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label useBarcodeScannerLabel;
    }
}