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
            this.OrderToBarTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SentToKichenButton = new System.Windows.Forms.Button();
            this.SentToBarButton = new System.Windows.Forms.Button();
            this.Table1Button = new System.Windows.Forms.Button();
            this.Table2Button = new System.Windows.Forms.Button();
            this.Table3Button = new System.Windows.Forms.Button();
            this.Table4Button = new System.Windows.Forms.Button();
            this.Table5Button = new System.Windows.Forms.Button();
            this.Button1TableIsFreeButton = new System.Windows.Forms.Button();
            this.Button2TableIsFreeButton = new System.Windows.Forms.Button();
            this.Button3TableIsFreeButton = new System.Windows.Forms.Button();
            this.Button4TableIsFreeButton = new System.Windows.Forms.Button();
            this.Button5TableIsFreeButton = new System.Windows.Forms.Button();
            this.FullOrderTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FoodListBox
            // 
            this.FoodListBox.FormattingEnabled = true;
            this.FoodListBox.Location = new System.Drawing.Point(224, 31);
            this.FoodListBox.Name = "FoodListBox";
            this.FoodListBox.Size = new System.Drawing.Size(237, 28);
            this.FoodListBox.TabIndex = 0;
            // 
            // DrinksLisBox
            // 
            this.DrinksLisBox.FormattingEnabled = true;
            this.DrinksLisBox.Location = new System.Drawing.Point(224, 100);
            this.DrinksLisBox.Name = "DrinksLisBox";
            this.DrinksLisBox.Size = new System.Drawing.Size(237, 28);
            this.DrinksLisBox.TabIndex = 1;
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(978, 377);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(94, 29);
            this.PayButton.TabIndex = 2;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(367, 156);
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
            this.label1.Location = new System.Drawing.Point(224, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Drinks";
            // 
            // OrderTextBox
            // 
            this.OrderTextBox.Location = new System.Drawing.Point(637, 72);
            this.OrderTextBox.Multiline = true;
            this.OrderTextBox.Name = "OrderTextBox";
            this.OrderTextBox.ReadOnly = true;
            this.OrderTextBox.Size = new System.Drawing.Size(244, 113);
            this.OrderTextBox.TabIndex = 6;
            // 
            // OrderToBarTextBox
            // 
            this.OrderToBarTextBox.Location = new System.Drawing.Point(916, 72);
            this.OrderToBarTextBox.Multiline = true;
            this.OrderToBarTextBox.Name = "OrderToBarTextBox";
            this.OrderToBarTextBox.ReadOnly = true;
            this.OrderToBarTextBox.Size = new System.Drawing.Size(156, 113);
            this.OrderToBarTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Food";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(916, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Drinks";
            // 
            // SentToKichenButton
            // 
            this.SentToKichenButton.Location = new System.Drawing.Point(637, 191);
            this.SentToKichenButton.Name = "SentToKichenButton";
            this.SentToKichenButton.Size = new System.Drawing.Size(181, 29);
            this.SentToKichenButton.TabIndex = 10;
            this.SentToKichenButton.Text = "Send To Kichen";
            this.SentToKichenButton.UseVisualStyleBackColor = true;
            this.SentToKichenButton.Click += new System.EventHandler(this.SentToKichenButton_Click);
            // 
            // SentToBarButton
            // 
            this.SentToBarButton.Location = new System.Drawing.Point(916, 191);
            this.SentToBarButton.Name = "SentToBarButton";
            this.SentToBarButton.Size = new System.Drawing.Size(94, 29);
            this.SentToBarButton.TabIndex = 11;
            this.SentToBarButton.Text = "Send to Bar";
            this.SentToBarButton.UseVisualStyleBackColor = true;
            this.SentToBarButton.Click += new System.EventHandler(this.SentToBarButton_Click);
            // 
            // Table1Button
            // 
            this.Table1Button.BackgroundImage = global::RestaurantSystemApp.Properties.Resources.Table;
            this.Table1Button.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Table1Button.Location = new System.Drawing.Point(30, 31);
            this.Table1Button.Name = "Table1Button";
            this.Table1Button.Size = new System.Drawing.Size(139, 98);
            this.Table1Button.TabIndex = 12;
            this.Table1Button.Text = "1";
            this.Table1Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Table1Button.UseVisualStyleBackColor = true;
            this.Table1Button.Click += new System.EventHandler(this.Table1Button_Click);
            // 
            // Table2Button
            // 
            this.Table2Button.BackgroundImage = global::RestaurantSystemApp.Properties.Resources.Table;
            this.Table2Button.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Table2Button.Location = new System.Drawing.Point(30, 175);
            this.Table2Button.Name = "Table2Button";
            this.Table2Button.Size = new System.Drawing.Size(139, 98);
            this.Table2Button.TabIndex = 13;
            this.Table2Button.Text = "2";
            this.Table2Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Table2Button.UseVisualStyleBackColor = true;
            this.Table2Button.Click += new System.EventHandler(this.Table2Button_Click);
            // 
            // Table3Button
            // 
            this.Table3Button.BackgroundImage = global::RestaurantSystemApp.Properties.Resources.Table;
            this.Table3Button.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Table3Button.Location = new System.Drawing.Point(30, 314);
            this.Table3Button.Name = "Table3Button";
            this.Table3Button.Size = new System.Drawing.Size(139, 98);
            this.Table3Button.TabIndex = 14;
            this.Table3Button.Text = "3";
            this.Table3Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Table3Button.UseVisualStyleBackColor = true;
            this.Table3Button.Click += new System.EventHandler(this.Table3Button_Click);
            // 
            // Table4Button
            // 
            this.Table4Button.BackgroundImage = global::RestaurantSystemApp.Properties.Resources.Table;
            this.Table4Button.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Table4Button.Location = new System.Drawing.Point(207, 205);
            this.Table4Button.Name = "Table4Button";
            this.Table4Button.Size = new System.Drawing.Size(139, 98);
            this.Table4Button.TabIndex = 15;
            this.Table4Button.Text = "4";
            this.Table4Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Table4Button.UseVisualStyleBackColor = true;
            this.Table4Button.Click += new System.EventHandler(this.Table4Button_Click);
            // 
            // Table5Button
            // 
            this.Table5Button.BackgroundImage = global::RestaurantSystemApp.Properties.Resources.Table;
            this.Table5Button.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Table5Button.Location = new System.Drawing.Point(207, 340);
            this.Table5Button.Name = "Table5Button";
            this.Table5Button.Size = new System.Drawing.Size(139, 98);
            this.Table5Button.TabIndex = 16;
            this.Table5Button.Text = "5";
            this.Table5Button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Table5Button.UseVisualStyleBackColor = true;
            this.Table5Button.Click += new System.EventHandler(this.Table5Button_Click);
            // 
            // Button1TableIsFreeButton
            // 
            this.Button1TableIsFreeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.Button1TableIsFreeButton.Location = new System.Drawing.Point(30, 127);
            this.Button1TableIsFreeButton.Name = "Button1TableIsFreeButton";
            this.Button1TableIsFreeButton.Size = new System.Drawing.Size(139, 29);
            this.Button1TableIsFreeButton.TabIndex = 17;
            this.Button1TableIsFreeButton.Text = "TABLE IS FREE";
            this.Button1TableIsFreeButton.UseVisualStyleBackColor = false;
            this.Button1TableIsFreeButton.Click += new System.EventHandler(this.Button1TableIsFreeButton_Click);
            // 
            // Button2TableIsFreeButton
            // 
            this.Button2TableIsFreeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.Button2TableIsFreeButton.Location = new System.Drawing.Point(30, 265);
            this.Button2TableIsFreeButton.Name = "Button2TableIsFreeButton";
            this.Button2TableIsFreeButton.Size = new System.Drawing.Size(139, 29);
            this.Button2TableIsFreeButton.TabIndex = 18;
            this.Button2TableIsFreeButton.Text = "TABLE IS FREE";
            this.Button2TableIsFreeButton.UseVisualStyleBackColor = false;
            this.Button2TableIsFreeButton.Click += new System.EventHandler(this.Button2TableIsFreeButton_Click);
            // 
            // Button3TableIsFreeButton
            // 
            this.Button3TableIsFreeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.Button3TableIsFreeButton.Location = new System.Drawing.Point(30, 409);
            this.Button3TableIsFreeButton.Name = "Button3TableIsFreeButton";
            this.Button3TableIsFreeButton.Size = new System.Drawing.Size(139, 29);
            this.Button3TableIsFreeButton.TabIndex = 19;
            this.Button3TableIsFreeButton.Text = "TABLE IS FREE";
            this.Button3TableIsFreeButton.UseVisualStyleBackColor = false;
            this.Button3TableIsFreeButton.Click += new System.EventHandler(this.Button3TableIsFreeButton_Click);
            // 
            // Button4TableIsFreeButton
            // 
            this.Button4TableIsFreeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.Button4TableIsFreeButton.Location = new System.Drawing.Point(207, 296);
            this.Button4TableIsFreeButton.Name = "Button4TableIsFreeButton";
            this.Button4TableIsFreeButton.Size = new System.Drawing.Size(139, 29);
            this.Button4TableIsFreeButton.TabIndex = 20;
            this.Button4TableIsFreeButton.Text = "TABLE IS FREE";
            this.Button4TableIsFreeButton.UseVisualStyleBackColor = false;
            this.Button4TableIsFreeButton.Click += new System.EventHandler(this.Button4TableIsFreeButton_Click);
            // 
            // Button5TableIsFreeButton
            // 
            this.Button5TableIsFreeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.Button5TableIsFreeButton.Location = new System.Drawing.Point(207, 432);
            this.Button5TableIsFreeButton.Name = "Button5TableIsFreeButton";
            this.Button5TableIsFreeButton.Size = new System.Drawing.Size(139, 29);
            this.Button5TableIsFreeButton.TabIndex = 21;
            this.Button5TableIsFreeButton.Text = "TABLE IS FREE";
            this.Button5TableIsFreeButton.UseVisualStyleBackColor = false;
            this.Button5TableIsFreeButton.Click += new System.EventHandler(this.Button5TableIsFreeButton_Click);
            // 
            // FullOrderTextBox
            // 
            this.FullOrderTextBox.Location = new System.Drawing.Point(640, 255);
            this.FullOrderTextBox.Multiline = true;
            this.FullOrderTextBox.Name = "FullOrderTextBox";
            this.FullOrderTextBox.Size = new System.Drawing.Size(274, 151);
            this.FullOrderTextBox.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Order";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::RestaurantSystemApp.Properties.Resources.background_image;
            this.ClientSize = new System.Drawing.Size(1233, 473);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FullOrderTextBox);
            this.Controls.Add(this.Button5TableIsFreeButton);
            this.Controls.Add(this.Button4TableIsFreeButton);
            this.Controls.Add(this.Button3TableIsFreeButton);
            this.Controls.Add(this.Button2TableIsFreeButton);
            this.Controls.Add(this.Button1TableIsFreeButton);
            this.Controls.Add(this.Table5Button);
            this.Controls.Add(this.Table4Button);
            this.Controls.Add(this.Table3Button);
            this.Controls.Add(this.Table2Button);
            this.Controls.Add(this.Table1Button);
            this.Controls.Add(this.SentToBarButton);
            this.Controls.Add(this.SentToKichenButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderToBarTextBox);
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
        private System.Windows.Forms.TextBox OrderToBarTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SentToKichenButton;
        private System.Windows.Forms.Button SentToBarButton;
        private System.Windows.Forms.Button Table1Button;
        private System.Windows.Forms.Button Table2Button;
        private System.Windows.Forms.Button Table3Button;
        private System.Windows.Forms.Button Table4Button;
        private System.Windows.Forms.Button Table5Button;
        private System.Windows.Forms.Button Button1TableIsFreeButton;
        private System.Windows.Forms.Button Button2TableIsFreeButton;
        private System.Windows.Forms.Button Button3TableIsFreeButton;
        private System.Windows.Forms.Button Button4TableIsFreeButton;
        private System.Windows.Forms.Button Button5TableIsFreeButton;
        private System.Windows.Forms.TextBox FullOrderTextBox;
        private System.Windows.Forms.Label label5;
    }
}
