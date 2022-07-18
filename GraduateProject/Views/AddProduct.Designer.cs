
namespace GraduateProject.Views
{
    partial class AddProduct
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productType = new System.Windows.Forms.ComboBox();
            this.provider = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.productColor = new System.Windows.Forms.TextBox();
            this.productCode = new System.Windows.Forms.TextBox();
            this.isProductAvailable = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.backToDashboard = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.textProductSize = new System.Windows.Forms.RadioButton();
            this.numberedProductSize = new System.Windows.Forms.RadioButton();
            this.productSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provider:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Product Code:";
            // 
            // productType
            // 
            this.productType.FormattingEnabled = true;
            this.productType.Items.AddRange(new object[] {
            "Men Pijamas",
            "Women Pijamas",
            "Kids Pijamas",
            "MenU nderwear",
            "Women Underwear",
            "Kids Underwear",
            "Socks",
            "Men Swimming Shorts",
            "Women Swimsuit",
            "Kids Swimsuit"});
            this.productType.Location = new System.Drawing.Point(111, 18);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(121, 21);
            this.productType.TabIndex = 6;
            this.productType.Text = "Select product type";
            // 
            // provider
            // 
            this.provider.FormattingEnabled = true;
            this.provider.Items.AddRange(new object[] {
            "Silvi Style",
            "Aydogan",
            "Penti",
            "Sara Fashion",
            "Red Star"});
            this.provider.Location = new System.Drawing.Point(111, 49);
            this.provider.Name = "provider";
            this.provider.Size = new System.Drawing.Size(121, 21);
            this.provider.TabIndex = 7;
            this.provider.Text = "Select product provider";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(111, 155);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(121, 20);
            this.quantity.TabIndex = 9;
            // 
            // productColor
            // 
            this.productColor.Location = new System.Drawing.Point(111, 188);
            this.productColor.Name = "productColor";
            this.productColor.Size = new System.Drawing.Size(121, 20);
            this.productColor.TabIndex = 10;
            this.productColor.Text = "Enter product color";
            // 
            // productCode
            // 
            this.productCode.Location = new System.Drawing.Point(111, 219);
            this.productCode.Name = "productCode";
            this.productCode.Size = new System.Drawing.Size(121, 20);
            this.productCode.TabIndex = 11;
            // 
            // isProductAvailable
            // 
            this.isProductAvailable.AutoSize = true;
            this.isProductAvailable.Checked = true;
            this.isProductAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isProductAvailable.Location = new System.Drawing.Point(27, 289);
            this.isProductAvailable.Name = "isProductAvailable";
            this.isProductAvailable.Size = new System.Drawing.Size(120, 17);
            this.isProductAvailable.TabIndex = 12;
            this.isProductAvailable.Text = "Is Product Available";
            this.isProductAvailable.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Price";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(111, 253);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(121, 20);
            this.price.TabIndex = 17;
            // 
            // backToDashboard
            // 
            this.backToDashboard.Location = new System.Drawing.Point(27, 327);
            this.backToDashboard.Name = "backToDashboard";
            this.backToDashboard.Size = new System.Drawing.Size(121, 23);
            this.backToDashboard.TabIndex = 19;
            this.backToDashboard.Text = "Back To Dashboard";
            this.backToDashboard.UseVisualStyleBackColor = true;
            this.backToDashboard.Click += new System.EventHandler(this.backToDashboard_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(235, 327);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 20;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // textProductSize
            // 
            this.textProductSize.AutoSize = true;
            this.textProductSize.Location = new System.Drawing.Point(170, 88);
            this.textProductSize.Name = "textProductSize";
            this.textProductSize.Size = new System.Drawing.Size(109, 17);
            this.textProductSize.TabIndex = 24;
            this.textProductSize.Text = "Text Product Size";
            this.textProductSize.UseVisualStyleBackColor = true;
            this.textProductSize.CheckedChanged += new System.EventHandler(this.textProductSize_CheckedChanged);
            // 
            // numberedProductSize
            // 
            this.numberedProductSize.AutoSize = true;
            this.numberedProductSize.Checked = true;
            this.numberedProductSize.Location = new System.Drawing.Point(27, 88);
            this.numberedProductSize.Name = "numberedProductSize";
            this.numberedProductSize.Size = new System.Drawing.Size(137, 17);
            this.numberedProductSize.TabIndex = 23;
            this.numberedProductSize.TabStop = true;
            this.numberedProductSize.Text = "Numbered Product Size";
            this.numberedProductSize.UseVisualStyleBackColor = true;
            this.numberedProductSize.CheckedChanged += new System.EventHandler(this.numberedProductSize_CheckedChanged);
            // 
            // productSize
            // 
            this.productSize.FormattingEnabled = true;
            this.productSize.Location = new System.Drawing.Point(109, 120);
            this.productSize.Name = "productSize";
            this.productSize.Size = new System.Drawing.Size(123, 21);
            this.productSize.TabIndex = 22;
            this.productSize.Text = "Select product size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Product Size:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(155, 327);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(74, 23);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 382);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textProductSize);
            this.Controls.Add(this.numberedProductSize);
            this.Controls.Add(this.productSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.backToDashboard);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.isProductAvailable);
            this.Controls.Add(this.productCode);
            this.Controls.Add(this.productColor);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.provider);
            this.Controls.Add(this.productType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProducts";
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox productType;
        private System.Windows.Forms.ComboBox provider;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.TextBox productColor;
        private System.Windows.Forms.TextBox productCode;
        private System.Windows.Forms.CheckBox isProductAvailable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.Button backToDashboard;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.RadioButton textProductSize;
        private System.Windows.Forms.RadioButton numberedProductSize;
        private System.Windows.Forms.ComboBox productSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
    }
}