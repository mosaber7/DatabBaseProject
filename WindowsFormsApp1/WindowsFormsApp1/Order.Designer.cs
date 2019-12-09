namespace WindowsFormsApp1
{
    partial class Order
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.AddFoodButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FoodList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(381, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Done_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(381, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.comboBox1.MouseEnter += new System.EventHandler(this.Combo1_clicked);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Order";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(381, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            this.comboBox2.Click += new System.EventHandler(this.ComboBox2_Click);
            this.comboBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBox2_MouseClick);
            this.comboBox2.MouseCaptureChanged += new System.EventHandler(this.ComboBox2_MouseEnter);
            this.comboBox2.MouseEnter += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            this.comboBox2.MouseHover += new System.EventHandler(this.ComboBox2_MouseEnter);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 233);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(381, 24);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_MouseEnter);
            this.comboBox3.SelectedValueChanged += new System.EventHandler(this.ComboBox3_MouseEnter);
            this.comboBox3.Click += new System.EventHandler(this.ComboBox3_MouseEnter);
            this.comboBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboBox3_MouseClick);
            this.comboBox3.MouseEnter += new System.EventHandler(this.ComboBox3_MouseEnter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(381, 48);
            this.button3.TabIndex = 7;
            this.button3.Text = "cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // AddFoodButton
            // 
            this.AddFoodButton.Location = new System.Drawing.Point(12, 313);
            this.AddFoodButton.Name = "AddFoodButton";
            this.AddFoodButton.Size = new System.Drawing.Size(381, 48);
            this.AddFoodButton.TabIndex = 6;
            this.AddFoodButton.Text = "Add Food Into Order";
            this.AddFoodButton.UseVisualStyleBackColor = true;
            this.AddFoodButton.Click += new System.EventHandler(this.AddFoodButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Location = new System.Drawing.Point(12, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(381, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "FoodItem";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.Location = new System.Drawing.Point(12, 205);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(381, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Waiter";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Location = new System.Drawing.Point(12, 135);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(381, 22);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Remove";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(249, 263);
            this.QuantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(144, 22);
            this.QuantityNumericUpDown.TabIndex = 12;
            this.QuantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FoodList
            // 
            this.FoodList.FormattingEnabled = true;
            this.FoodList.ItemHeight = 16;
            this.FoodList.Location = new System.Drawing.Point(409, 12);
            this.FoodList.Name = "FoodList";
            this.FoodList.Size = new System.Drawing.Size(189, 452);
            this.FoodList.TabIndex = 13;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 481);
            this.Controls.Add(this.FoodList);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AddFoodButton);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Order";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AddFoodButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.ListBox FoodList;
    }
}