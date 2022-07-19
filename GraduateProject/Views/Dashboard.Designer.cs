
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
            this.manuallyAddProductButton = new System.Windows.Forms.Button();
            this.automaticallyAddProductButton = new System.Windows.Forms.Button();
            this.productsDashboardButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
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
            // manuallyAddProductButton
            // 
            this.manuallyAddProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuallyAddProductButton.Location = new System.Drawing.Point(59, 63);
            this.manuallyAddProductButton.Name = "manuallyAddProductButton";
            this.manuallyAddProductButton.Size = new System.Drawing.Size(153, 43);
            this.manuallyAddProductButton.TabIndex = 1;
            this.manuallyAddProductButton.Text = "Manually Add Product ";
            this.manuallyAddProductButton.UseVisualStyleBackColor = true;
            this.manuallyAddProductButton.Click += new System.EventHandler(this.manuallyAddProductButton_Click);
            // 
            // automaticallyAddProductButton
            // 
            this.automaticallyAddProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.automaticallyAddProductButton.Location = new System.Drawing.Point(47, 116);
            this.automaticallyAddProductButton.Name = "automaticallyAddProductButton";
            this.automaticallyAddProductButton.Size = new System.Drawing.Size(177, 45);
            this.automaticallyAddProductButton.TabIndex = 2;
            this.automaticallyAddProductButton.Text = "Automatically Add Product ";
            this.automaticallyAddProductButton.UseVisualStyleBackColor = true;
            // 
            // productsDashboardButton
            // 
            this.productsDashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsDashboardButton.Location = new System.Drawing.Point(66, 171);
            this.productsDashboardButton.Name = "productsDashboardButton";
            this.productsDashboardButton.Size = new System.Drawing.Size(141, 42);
            this.productsDashboardButton.TabIndex = 3;
            this.productsDashboardButton.Text = "Products Dashboard";
            this.productsDashboardButton.UseVisualStyleBackColor = true;
            // 
            // editUserButton
            // 
            this.editUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserButton.Location = new System.Drawing.Point(77, 221);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(118, 40);
            this.editUserButton.TabIndex = 4;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 299);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.productsDashboardButton);
            this.Controls.Add(this.automaticallyAddProductButton);
            this.Controls.Add(this.manuallyAddProductButton);
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
        private System.Windows.Forms.Button manuallyAddProductButton;
        private System.Windows.Forms.Button automaticallyAddProductButton;
        private System.Windows.Forms.Button productsDashboardButton;
        private System.Windows.Forms.Button editUserButton;
    }
}