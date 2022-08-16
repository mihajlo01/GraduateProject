
namespace GraduateProject
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.backToLoginButton = new System.Windows.Forms.Button();
            this.editUserPermission = new System.Windows.Forms.CheckBox();
            this.addProductsPermission = new System.Windows.Forms.CheckBox();
            this.removeProductsPermission = new System.Windows.Forms.CheckBox();
            this.productDashboardPermission = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CompanyName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 34);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(124, 26);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(124, 75);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(124, 26);
            this.textBoxUsername.TabIndex = 5;
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(124, 116);
            this.textBoxCompanyName.Multiline = true;
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(124, 26);
            this.textBoxCompanyName.TabIndex = 6;
            this.textBoxCompanyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCompanyName_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(124, 155);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(124, 26);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(164, 324);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(84, 27);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.Location = new System.Drawing.Point(58, 324);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(84, 27);
            this.backToLoginButton.TabIndex = 9;
            this.backToLoginButton.Text = "Back to Login";
            this.backToLoginButton.UseVisualStyleBackColor = true;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // editUserPermission
            // 
            this.editUserPermission.AutoSize = true;
            this.editUserPermission.Location = new System.Drawing.Point(94, 221);
            this.editUserPermission.Name = "editUserPermission";
            this.editUserPermission.Size = new System.Drawing.Size(69, 17);
            this.editUserPermission.TabIndex = 10;
            this.editUserPermission.Text = "Edit User";
            this.editUserPermission.UseVisualStyleBackColor = true;
            // 
            // addProductsPermission
            // 
            this.addProductsPermission.AutoSize = true;
            this.addProductsPermission.Location = new System.Drawing.Point(94, 244);
            this.addProductsPermission.Name = "addProductsPermission";
            this.addProductsPermission.Size = new System.Drawing.Size(90, 17);
            this.addProductsPermission.TabIndex = 11;
            this.addProductsPermission.Text = "Add Products";
            this.addProductsPermission.UseVisualStyleBackColor = true;
            // 
            // removeProductsPermission
            // 
            this.removeProductsPermission.AutoSize = true;
            this.removeProductsPermission.Location = new System.Drawing.Point(94, 267);
            this.removeProductsPermission.Name = "removeProductsPermission";
            this.removeProductsPermission.Size = new System.Drawing.Size(111, 17);
            this.removeProductsPermission.TabIndex = 12;
            this.removeProductsPermission.Text = "Remove Products";
            this.removeProductsPermission.UseVisualStyleBackColor = true;
            // 
            // productDashboardPermission
            // 
            this.productDashboardPermission.AutoSize = true;
            this.productDashboardPermission.Location = new System.Drawing.Point(94, 290);
            this.productDashboardPermission.Name = "productDashboardPermission";
            this.productDashboardPermission.Size = new System.Drawing.Size(118, 17);
            this.productDashboardPermission.TabIndex = 13;
            this.productDashboardPermission.Text = "Product Dashboard";
            this.productDashboardPermission.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Permissions:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productDashboardPermission);
            this.Controls.Add(this.removeProductsPermission);
            this.Controls.Add(this.addProductsPermission);
            this.Controls.Add(this.editUserPermission);
            this.Controls.Add(this.backToLoginButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button backToLoginButton;
        private System.Windows.Forms.CheckBox editUserPermission;
        private System.Windows.Forms.CheckBox addProductsPermission;
        private System.Windows.Forms.CheckBox removeProductsPermission;
        private System.Windows.Forms.CheckBox productDashboardPermission;
        private System.Windows.Forms.Label label5;
    }
}