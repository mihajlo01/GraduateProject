
namespace GraduateProject.Views
{
    partial class RemoveScanned
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
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.addedByLabel = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.backButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(23, 24);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(78, 13);
            this.productCodeLabel.TabIndex = 0;
            this.productCodeLabel.Text = "Product Code: ";
            // 
            // addedByLabel
            // 
            this.addedByLabel.AutoSize = true;
            this.addedByLabel.Location = new System.Drawing.Point(23, 46);
            this.addedByLabel.Name = "addedByLabel";
            this.addedByLabel.Size = new System.Drawing.Size(58, 13);
            this.addedByLabel.TabIndex = 1;
            this.addedByLabel.Text = "Added by: ";
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(23, 68);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(50, 13);
            this.createdLabel.TabIndex = 2;
            this.createdLabel.Text = "Created: ";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(23, 90);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(78, 88);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(83, 20);
            this.quantity.TabIndex = 4;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(30, 118);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(111, 118);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // RemoveScanned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 151);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.createdLabel);
            this.Controls.Add(this.addedByLabel);
            this.Controls.Add(this.productCodeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RemoveScanned";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveScanned";
            this.Load += new System.EventHandler(this.RemoveScanned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Label addedByLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button removeButton;
    }
}