
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
            this.backToDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToDashboard.Location = new System.Drawing.Point(13, 22);
            this.backToDashboard.Name = "backToDashboard";
            this.backToDashboard.Size = new System.Drawing.Size(134, 31);
            this.backToDashboard.TabIndex = 1;
            this.backToDashboard.Text = "Back To Dashboard";
            this.backToDashboard.UseVisualStyleBackColor = true;
            this.backToDashboard.Click += new System.EventHandler(this.backToDashboard_Click);
            // 
            // removeSelectedProducts
            // 
            this.removeSelectedProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedProducts.Location = new System.Drawing.Point(13, 59);
            this.removeSelectedProducts.Name = "removeSelectedProducts";
            this.removeSelectedProducts.Size = new System.Drawing.Size(173, 31);
            this.removeSelectedProducts.TabIndex = 2;
            this.removeSelectedProducts.Text = "Remove Selected Products";
            this.removeSelectedProducts.UseVisualStyleBackColor = true;
            this.removeSelectedProducts.Click += new System.EventHandler(this.removeSelectedProducts_Click);
            // 
            // ProductsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 450);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDataView;
        private System.Windows.Forms.Button backToDashboard;
        private System.Windows.Forms.Button removeSelectedProducts;
    }
}