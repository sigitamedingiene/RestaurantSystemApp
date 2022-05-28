namespace RestaurantSystemApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FoodListBox = new System.Windows.Forms.ComboBox();
            this.DrinksLisBox = new System.Windows.Forms.ComboBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Table1Button = new System.Windows.Forms.Button();
            this.Table2Button = new System.Windows.Forms.Button();
            this.Table3Button = new System.Windows.Forms.Button();
            this.Table4Button = new System.Windows.Forms.Button();
            this.Table5Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FoodListBox
            // 
            this.FoodListBox.FormattingEnabled = true;
            this.FoodListBox.Location = new System.Drawing.Point(325, 72);
            this.FoodListBox.Name = "FoodListBox";
            this.FoodListBox.Size = new System.Drawing.Size(237, 28);
            this.FoodListBox.TabIndex = 0;
            // 
            // DrinksLisBox
            // 
            this.DrinksLisBox.FormattingEnabled = true;
            this.DrinksLisBox.Location = new System.Drawing.Point(325, 123);
            this.DrinksLisBox.Name = "DrinksLisBox";
            this.DrinksLisBox.Size = new System.Drawing.Size(237, 28);
            this.DrinksLisBox.TabIndex = 1;
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(1035, 400);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(94, 29);
            this.PayButton.TabIndex = 2;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(468, 157);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(94, 29);
            this.AddOrderButton.TabIndex = 3;
            this.AddOrderButton.Text = "Add Order";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Drinks";
            // 
            // OrderTextBox
            // 
            this.OrderTextBox.Location = new System.Drawing.Point(583, 72);
            this.OrderTextBox.Multiline = true;
            this.OrderTextBox.Name = "OrderTextBox";
            this.OrderTextBox.ReadOnly = true;
            this.OrderTextBox.Size = new System.Drawing.Size(244, 113);
            this.OrderTextBox.TabIndex = 6;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(833, 72);
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(156, 113);
            this.PriceTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(833, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Drinks";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Send To Kichen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(895, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Send to Bar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Table1Button
            // 
            this.Table1Button.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Table1Button.Image = global::RestaurantSystemApp.Properties.Resources.Table;
            this.Table1Button.Location = new System.Drawing.Point(30, 31);
            this.Table1Button.Name = "Table1Button";
            this.Table1Button.Size = new System.Drawing.Size(139, 98);
            this.Table1Button.TabIndex = 12;
            this.Table1Button.Text = "1";
            this.Table1Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Table1Button.UseVisualStyleBackColor = true;
            // 
            // Table2Button
            // 
            this.Table2Button.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Table2Button.Image = global::RestaurantSystemApp.Properties.Resources.Table;
            this.Table2Button.Location = new System.Drawing.Point(30, 157);
            this.Table2Button.Name = "Table2Button";
            this.Table2Button.Size = new System.Drawing.Size(139, 98);
            this.Table2Button.TabIndex = 13;
            this.Table2Button.Text = "2";
            this.Table2Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Table2Button.UseVisualStyleBackColor = true;
            // 
            // Table3Button
            // 
            this.Table3Button.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Table3Button.Image = global::RestaurantSystemApp.Properties.Resources.Table;
            this.Table3Button.Location = new System.Drawing.Point(30, 288);
            this.Table3Button.Name = "Table3Button";
            this.Table3Button.Size = new System.Drawing.Size(139, 98);
            this.Table3Button.TabIndex = 14;
            this.Table3Button.Text = "3";
            this.Table3Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Table3Button.UseVisualStyleBackColor = true;
            // 
            // Table4Button
            // 
            this.Table4Button.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Table4Button.Image = global::RestaurantSystemApp.Properties.Resources.Table;
            this.Table4Button.Location = new System.Drawing.Point(207, 205);
            this.Table4Button.Name = "Table4Button";
            this.Table4Button.Size = new System.Drawing.Size(139, 98);
            this.Table4Button.TabIndex = 15;
            this.Table4Button.Text = "4";
            this.Table4Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Table4Button.UseVisualStyleBackColor = true;
            // 
            // Table5Button
            // 
            this.Table5Button.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Table5Button.Image = global::RestaurantSystemApp.Properties.Resources.Table;
            this.Table5Button.Location = new System.Drawing.Point(207, 331);
            this.Table5Button.Name = "Table5Button";
            this.Table5Button.Size = new System.Drawing.Size(139, 98);
            this.Table5Button.TabIndex = 16;
            this.Table5Button.Text = "5";
            this.Table5Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Table5Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 450);
            this.Controls.Add(this.Table5Button);
            this.Controls.Add(this.Table4Button);
            this.Controls.Add(this.Table3Button);
            this.Controls.Add(this.Table2Button);
            this.Controls.Add(this.Table1Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.OrderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.DrinksLisBox);
            this.Controls.Add(this.FoodListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FoodListBox;
        private System.Windows.Forms.ComboBox DrinksLisBox;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Table1Button;
        private System.Windows.Forms.Button Table2Button;
        private System.Windows.Forms.Button Table3Button;
        private System.Windows.Forms.Button Table4Button;
        private System.Windows.Forms.Button Table5Button;
    }
}
