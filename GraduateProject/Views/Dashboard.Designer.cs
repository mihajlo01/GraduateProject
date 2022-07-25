
namespace GraduateProject.Views
{
    partial class Dashboard
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.productSale = new System.Windows.Forms.Button();
            this.productsDashboardButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.manualAdd = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 22);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(76, 18);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome ";
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(16, 69);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(106, 30);
            this.addProductButton.TabIndex = 1;
            this.addProductButton.Text = "Add Product ";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // productSale
            // 
            this.productSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSale.Location = new System.Drawing.Point(16, 105);
            this.productSale.Name = "productSale";
            this.productSale.Size = new System.Drawing.Size(141, 30);
            this.productSale.TabIndex = 2;
            this.productSale.Text = "Sell Products";
            this.productSale.UseVisualStyleBackColor = true;
            // 
            // productsDashboardButton
            // 
            this.productsDashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsDashboardButton.Location = new System.Drawing.Point(16, 141);
            this.productsDashboardButton.Name = "productsDashboardButton";
            this.productsDashboardButton.Size = new System.Drawing.Size(157, 30);
            this.productsDashboardButton.TabIndex = 3;
            this.productsDashboardButton.Text = "Products Dashboard";
            this.productsDashboardButton.UseVisualStyleBackColor = true;
            this.productsDashboardButton.Click += new System.EventHandler(this.productsDashboardButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserButton.Location = new System.Drawing.Point(16, 177);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(89, 30);
            this.editUserButton.TabIndex = 4;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.Location = new System.Drawing.Point(311, 22);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(58, 17);
            this.clock.TabIndex = 5;
            this.clock.Text = "00:00:00";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(16, 213);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(89, 30);
            this.logOutButton.TabIndex = 6;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // manualAdd
            // 
            this.manualAdd.AutoSize = true;
            this.manualAdd.Location = new System.Drawing.Point(129, 76);
            this.manualAdd.Name = "manualAdd";
            this.manualAdd.Size = new System.Drawing.Size(130, 17);
            this.manualAdd.TabIndex = 7;
            this.manualAdd.Text = "Add Product Manually";
            this.manualAdd.UseVisualStyleBackColor = true;
            this.manualAdd.CheckedChanged += new System.EventHandler(this.manualAdd_CheckedChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 274);
            this.Controls.Add(this.manualAdd);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.productsDashboardButton);
            this.Controls.Add(this.productSale);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button productSale;
        private System.Windows.Forms.Button productsDashboardButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.CheckBox manualAdd;
    }
}