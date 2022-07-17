
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
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(15, 17);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(62, 15);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome ";
            // 
            // manuallyAddProductButton
            // 
            this.manuallyAddProductButton.Location = new System.Drawing.Point(51, 47);
            this.manuallyAddProductButton.Name = "manuallyAddProductButton";
            this.manuallyAddProductButton.Size = new System.Drawing.Size(130, 34);
            this.manuallyAddProductButton.TabIndex = 1;
            this.manuallyAddProductButton.Text = "Manually Add Product ";
            this.manuallyAddProductButton.UseVisualStyleBackColor = true;
            this.manuallyAddProductButton.Click += new System.EventHandler(this.manuallyAddProductButton_Click);
            // 
            // automaticallyAddProductButton
            // 
            this.automaticallyAddProductButton.Location = new System.Drawing.Point(40, 87);
            this.automaticallyAddProductButton.Name = "automaticallyAddProductButton";
            this.automaticallyAddProductButton.Size = new System.Drawing.Size(152, 34);
            this.automaticallyAddProductButton.TabIndex = 2;
            this.automaticallyAddProductButton.Text = "Automatically Add Product ";
            this.automaticallyAddProductButton.UseVisualStyleBackColor = true;
            // 
            // productsDashboardButton
            // 
            this.productsDashboardButton.Location = new System.Drawing.Point(51, 127);
            this.productsDashboardButton.Name = "productsDashboardButton";
            this.productsDashboardButton.Size = new System.Drawing.Size(130, 34);
            this.productsDashboardButton.TabIndex = 3;
            this.productsDashboardButton.Text = "Products Dashboard";
            this.productsDashboardButton.UseVisualStyleBackColor = true;
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(74, 167);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(87, 31);
            this.editUserButton.TabIndex = 4;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 226);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.productsDashboardButton);
            this.Controls.Add(this.automaticallyAddProductButton);
            this.Controls.Add(this.manuallyAddProductButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Dashboard";
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