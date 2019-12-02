namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.order = new System.Windows.Forms.Button();
            this.Waiter = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PropertyChangePanel = new System.Windows.Forms.Panel();
            this.AddMenuItemPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.RemoveMenuItemPanel = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.HireWaiterPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FireWaiterPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.PropertiesList = new System.Windows.Forms.ListBox();
            this.MainPanel.SuspendLayout();
            this.PropertyChangePanel.SuspendLayout();
            this.AddMenuItemPanel.SuspendLayout();
            this.RemoveMenuItemPanel.SuspendLayout();
            this.HireWaiterPanel.SuspendLayout();
            this.FireWaiterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(320, 55);
            this.order.Margin = new System.Windows.Forms.Padding(2);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(164, 84);
            this.order.TabIndex = 0;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Waiter
            // 
            this.Waiter.Location = new System.Drawing.Point(67, 55);
            this.Waiter.Margin = new System.Windows.Forms.Padding(2);
            this.Waiter.Name = "Waiter";
            this.Waiter.Size = new System.Drawing.Size(152, 84);
            this.Waiter.TabIndex = 1;
            this.Waiter.Text = "button2";
            this.Waiter.UseVisualStyleBackColor = true;
            this.Waiter.Click += new System.EventHandler(this.Waiter_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.order);
            this.MainPanel.Controls.Add(this.Waiter);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(576, 342);
            this.MainPanel.TabIndex = 2;
            // 
            // PropertyChangePanel
            // 
            this.PropertyChangePanel.Controls.Add(this.AddMenuItemPanel);
            this.PropertyChangePanel.Controls.Add(this.RemoveMenuItemPanel);
            this.PropertyChangePanel.Controls.Add(this.HireWaiterPanel);
            this.PropertyChangePanel.Controls.Add(this.FireWaiterPanel);
            this.PropertyChangePanel.Controls.Add(this.PropertiesList);
            this.PropertyChangePanel.Location = new System.Drawing.Point(12, 12);
            this.PropertyChangePanel.Name = "PropertyChangePanel";
            this.PropertyChangePanel.Size = new System.Drawing.Size(576, 342);
            this.PropertyChangePanel.TabIndex = 3;
            this.PropertyChangePanel.Visible = false;
            // 
            // AddMenuItemPanel
            // 
            this.AddMenuItemPanel.Controls.Add(this.label6);
            this.AddMenuItemPanel.Controls.Add(this.button4);
            this.AddMenuItemPanel.Location = new System.Drawing.Point(129, 3);
            this.AddMenuItemPanel.Name = "AddMenuItemPanel";
            this.AddMenuItemPanel.Size = new System.Drawing.Size(444, 336);
            this.AddMenuItemPanel.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Add Menu Item";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(53, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Add Menu Item";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // RemoveMenuItemPanel
            // 
            this.RemoveMenuItemPanel.Controls.Add(this.listBox2);
            this.RemoveMenuItemPanel.Controls.Add(this.label5);
            this.RemoveMenuItemPanel.Controls.Add(this.button3);
            this.RemoveMenuItemPanel.Location = new System.Drawing.Point(129, 3);
            this.RemoveMenuItemPanel.Name = "RemoveMenuItemPanel";
            this.RemoveMenuItemPanel.Size = new System.Drawing.Size(444, 336);
            this.RemoveMenuItemPanel.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(53, 34);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(133, 251);
            this.listBox2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Remove Menu Item";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Remove Selected Item";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // HireWaiterPanel
            // 
            this.HireWaiterPanel.Controls.Add(this.label3);
            this.HireWaiterPanel.Controls.Add(this.label2);
            this.HireWaiterPanel.Controls.Add(this.label1);
            this.HireWaiterPanel.Controls.Add(this.button1);
            this.HireWaiterPanel.Controls.Add(this.textBox2);
            this.HireWaiterPanel.Controls.Add(this.textBox1);
            this.HireWaiterPanel.Location = new System.Drawing.Point(129, 3);
            this.HireWaiterPanel.Name = "HireWaiterPanel";
            this.HireWaiterPanel.Size = new System.Drawing.Size(444, 336);
            this.HireWaiterPanel.TabIndex = 0;
            this.HireWaiterPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hire Waiter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hire Waiter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // FireWaiterPanel
            // 
            this.FireWaiterPanel.Controls.Add(this.listBox1);
            this.FireWaiterPanel.Controls.Add(this.label4);
            this.FireWaiterPanel.Controls.Add(this.button2);
            this.FireWaiterPanel.Location = new System.Drawing.Point(129, 3);
            this.FireWaiterPanel.Name = "FireWaiterPanel";
            this.FireWaiterPanel.Size = new System.Drawing.Size(444, 336);
            this.FireWaiterPanel.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(53, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 251);
            this.listBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fire Waiter";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Fire Selected Waiter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PropertiesList
            // 
            this.PropertiesList.FormattingEnabled = true;
            this.PropertiesList.Items.AddRange(new object[] {
            "Hire Waiter",
            "Fire Waiter",
            "Add Menu Item",
            "Remove Menu Item",
            "Add Ingredient",
            "Restock Ingredient"});
            this.PropertiesList.Location = new System.Drawing.Point(3, 3);
            this.PropertiesList.Name = "PropertiesList";
            this.PropertiesList.Size = new System.Drawing.Size(120, 329);
            this.PropertiesList.TabIndex = 0;
            this.PropertiesList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.PropertyChangePanel);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.PropertyChangePanel.ResumeLayout(false);
            this.AddMenuItemPanel.ResumeLayout(false);
            this.AddMenuItemPanel.PerformLayout();
            this.RemoveMenuItemPanel.ResumeLayout(false);
            this.RemoveMenuItemPanel.PerformLayout();
            this.HireWaiterPanel.ResumeLayout(false);
            this.HireWaiterPanel.PerformLayout();
            this.FireWaiterPanel.ResumeLayout(false);
            this.FireWaiterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button Waiter;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PropertyChangePanel;
        private System.Windows.Forms.ListBox PropertiesList;
        private System.Windows.Forms.Panel HireWaiterPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel FireWaiterPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel RemoveMenuItemPanel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel AddMenuItemPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
    }
}

