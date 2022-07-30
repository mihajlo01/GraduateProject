
namespace GraduateProject.Views
{
    partial class ProductsDashboard
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
            this.productsDataView = new System.Windows.Forms.DataGridView();
            this.backToDashboard = new System.Windows.Forms.Button();
            this.removeSelectedProducts = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.enteredProductsLabel = new System.Windows.Forms.Label();
            this.selledProductsLabel = new System.Windows.Forms.Label();
            this.removedProductsLabel = new System.Windows.Forms.Label();
            this.productInformationButton = new System.Windows.Forms.Button();
            this.scanToRemoveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // productsDataView
            // 
            this.productsDataView.AllowUserToAddRows = false;
            this.productsDataView.AllowUserToDeleteRows = false;
            this.productsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataView.Location = new System.Drawing.Point(201, 12);
            this.productsDataView.Name = "productsDataView";
            this.productsDataView.ReadOnly = true;
            this.productsDataView.Size = new System.Drawing.Size(1144, 426);
            this.productsDataView.TabIndex = 0;
            // 
            // backToDashboard
            // 
            this.backToDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToDashboard.Location = new System.Drawing.Point(14, 359);
            this.backToDashboard.Name = "backToDashboard";
            this.backToDashboard.Size = new System.Drawing.Size(155, 32);
            this.backToDashboard.TabIndex = 1;
            this.backToDashboard.Text = "Back To Dashboard";
            this.backToDashboard.UseVisualStyleBackColor = true;
            this.backToDashboard.Click += new System.EventHandler(this.backToDashboard_Click);
            // 
            // removeSelectedProducts
            // 
            this.removeSelectedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedProducts.Location = new System.Drawing.Point(14, 283);
            this.removeSelectedProducts.Name = "removeSelectedProducts";
            this.removeSelectedProducts.Size = new System.Drawing.Size(184, 32);
            this.removeSelectedProducts.TabIndex = 2;
            this.removeSelectedProducts.Text = "Remove Selected Products";
            this.removeSelectedProducts.UseVisualStyleBackColor = true;
            this.removeSelectedProducts.Click += new System.EventHandler(this.removeSelectedProducts_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(12, 61);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(46, 16);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "User:  ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 90);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(54, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:  ";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameLabel.Location = new System.Drawing.Point(12, 121);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(69, 16);
            this.companyNameLabel.TabIndex = 5;
            this.companyNameLabel.Text = "C. Name:  ";
            // 
            // enteredProductsLabel
            // 
            this.enteredProductsLabel.AutoSize = true;
            this.enteredProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enteredProductsLabel.Location = new System.Drawing.Point(12, 153);
            this.enteredProductsLabel.Name = "enteredProductsLabel";
            this.enteredProductsLabel.Size = new System.Drawing.Size(120, 16);
            this.enteredProductsLabel.TabIndex = 6;
            this.enteredProductsLabel.Text = "Entered Products:  ";
            // 
            // selledProductsLabel
            // 
            this.selledProductsLabel.AutoSize = true;
            this.selledProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selledProductsLabel.Location = new System.Drawing.Point(12, 185);
            this.selledProductsLabel.Name = "selledProductsLabel";
            this.selledProductsLabel.Size = new System.Drawing.Size(112, 16);
            this.selledProductsLabel.TabIndex = 7;
            this.selledProductsLabel.Text = "Selled Products:  ";
            // 
            // removedProductsLabel
            // 
            this.removedProductsLabel.AutoSize = true;
            this.removedProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removedProductsLabel.Location = new System.Drawing.Point(12, 216);
            this.removedProductsLabel.Name = "removedProductsLabel";
            this.removedProductsLabel.Size = new System.Drawing.Size(133, 16);
            this.removedProductsLabel.TabIndex = 8;
            this.removedProductsLabel.Text = "Removed Products:  ";
            // 
            // productInformationButton
            // 
            this.productInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInformationButton.Location = new System.Drawing.Point(11, 245);
            this.productInformationButton.Name = "productInformationButton";
            this.productInformationButton.Size = new System.Drawing.Size(155, 32);
            this.productInformationButton.TabIndex = 9;
            this.productInformationButton.Text = "Product Information";
            this.productInformationButton.UseVisualStyleBackColor = true;
            this.productInformationButton.Click += new System.EventHandler(this.productInformationButton_Click);
            // 
            // scanToRemoveButton
            // 
            this.scanToRemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanToRemoveButton.Location = new System.Drawing.Point(14, 321);
            this.scanToRemoveButton.Name = "scanToRemoveButton";
            this.scanToRemoveButton.Size = new System.Drawing.Size(155, 32);
            this.scanToRemoveButton.TabIndex = 10;
            this.scanToRemoveButton.Text = "Scan To Remove";
            this.scanToRemoveButton.UseVisualStyleBackColor = true;
            this.scanToRemoveButton.Click += new System.EventHandler(this.scanToRemoveButton_Click);
            // 
            // ProductsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 450);
            this.Controls.Add(this.scanToRemoveButton);
            this.Controls.Add(this.productInformationButton);
            this.Controls.Add(this.removedProductsLabel);
            this.Controls.Add(this.selledProductsLabel);
            this.Controls.Add(this.enteredProductsLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.removeSelectedProducts);
            this.Controls.Add(this.backToDashboard);
            this.Controls.Add(this.productsDataView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductsDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsDashboard";
            this.Load += new System.EventHandler(this.ProductsDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataView;
        private System.Windows.Forms.Button backToDashboard;
        private System.Windows.Forms.Button removeSelectedProducts;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label enteredProductsLabel;
        private System.Windows.Forms.Label selledProductsLabel;
        private System.Windows.Forms.Label removedProductsLabel;
        private System.Windows.Forms.Button productInformationButton;
        private System.Windows.Forms.Button scanToRemoveButton;
    }
}