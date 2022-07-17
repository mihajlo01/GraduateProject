
namespace GraduateProject.Views
{
    partial class EditAcount
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
            this.backToDashboardButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productDashboardPermission = new System.Windows.Forms.CheckBox();
            this.removeProductsPermission = new System.Windows.Forms.CheckBox();
            this.addProductsPermission = new System.Windows.Forms.CheckBox();
            this.editUserPermission = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // backToDashboardButton
            // 
            this.backToDashboardButton.Location = new System.Drawing.Point(49, 356);
            this.backToDashboardButton.Name = "backToDashboardButton";
            this.backToDashboardButton.Size = new System.Drawing.Size(108, 27);
            this.backToDashboardButton.TabIndex = 19;
            this.backToDashboardButton.Text = "Back to Dashboard";
            this.backToDashboardButton.UseVisualStyleBackColor = true;
            this.backToDashboardButton.Click += new System.EventHandler(this.backToDashboardButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(175, 356);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(84, 27);
            this.saveChangesButton.TabIndex = 18;
            this.saveChangesButton.Text = "Save changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(129, 149);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(124, 26);
            this.textBoxPassword.TabIndex = 17;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(129, 110);
            this.textBoxCompanyName.Multiline = true;
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(124, 26);
            this.textBoxCompanyName.TabIndex = 16;
            this.textBoxCompanyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCompanyName_KeyDown);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(129, 69);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(124, 26);
            this.textBoxUsername.TabIndex = 15;
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(129, 28);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(124, 26);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "CompanyName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(129, 190);
            this.textBoxNewPassword.Multiline = true;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(124, 26);
            this.textBoxNewPassword.TabIndex = 21;
            this.textBoxNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNewPassword_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "New Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Permissions:";
            // 
            // productDashboardPermission
            // 
            this.productDashboardPermission.AutoSize = true;
            this.productDashboardPermission.Location = new System.Drawing.Point(104, 321);
            this.productDashboardPermission.Name = "productDashboardPermission";
            this.productDashboardPermission.Size = new System.Drawing.Size(118, 17);
            this.productDashboardPermission.TabIndex = 25;
            this.productDashboardPermission.Text = "Product Dashboard";
            this.productDashboardPermission.UseVisualStyleBackColor = true;
            // 
            // removeProductsPermission
            // 
            this.removeProductsPermission.AutoSize = true;
            this.removeProductsPermission.Location = new System.Drawing.Point(104, 298);
            this.removeProductsPermission.Name = "removeProductsPermission";
            this.removeProductsPermission.Size = new System.Drawing.Size(111, 17);
            this.removeProductsPermission.TabIndex = 24;
            this.removeProductsPermission.Text = "Remove Products";
            this.removeProductsPermission.UseVisualStyleBackColor = true;
            // 
            // addProductsPermission
            // 
            this.addProductsPermission.AutoSize = true;
            this.addProductsPermission.Location = new System.Drawing.Point(104, 275);
            this.addProductsPermission.Name = "addProductsPermission";
            this.addProductsPermission.Size = new System.Drawing.Size(90, 17);
            this.addProductsPermission.TabIndex = 23;
            this.addProductsPermission.Text = "Add Products";
            this.addProductsPermission.UseVisualStyleBackColor = true;
            // 
            // editUserPermission
            // 
            this.editUserPermission.AutoSize = true;
            this.editUserPermission.Location = new System.Drawing.Point(104, 252);
            this.editUserPermission.Name = "editUserPermission";
            this.editUserPermission.Size = new System.Drawing.Size(69, 17);
            this.editUserPermission.TabIndex = 22;
            this.editUserPermission.Text = "Edit User";
            this.editUserPermission.UseVisualStyleBackColor = true;
            // 
            // EditAcount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 408);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productDashboardPermission);
            this.Controls.Add(this.removeProductsPermission);
            this.Controls.Add(this.addProductsPermission);
            this.Controls.Add(this.editUserPermission);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backToDashboardButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditAcount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditAcount";
            this.Load += new System.EventHandler(this.EditAcount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToDashboardButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox productDashboardPermission;
        private System.Windows.Forms.CheckBox removeProductsPermission;
        private System.Windows.Forms.CheckBox addProductsPermission;
        private System.Windows.Forms.CheckBox editUserPermission;
    }
}