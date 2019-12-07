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
            this.PropertiesList = new System.Windows.Forms.ListBox();
            this.RemoveMenuItemPanel = new System.Windows.Forms.Panel();
            this.RemoveMenuItemList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RemoveSelectedItemButton = new System.Windows.Forms.Button();
            this.HireWaiterPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HireWaiterSubmitButton = new System.Windows.Forms.Button();
            this.HireWaiterNameInput = new System.Windows.Forms.TextBox();
            this.HireWaiterWageInput = new System.Windows.Forms.TextBox();
            this.FireWaiterPanel = new System.Windows.Forms.Panel();
            this.FireWaiterList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FireSelectedWaiterButton = new System.Windows.Forms.Button();
            this.AddIngredientPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AddIngredientUnits = new System.Windows.Forms.TextBox();
            this.AddIngredientAmount = new System.Windows.Forms.TextBox();
            this.AddIngredientName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddIngredientButton = new System.Windows.Forms.Button();
            this.RestockIngredientPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.RestockIngredientAmount = new System.Windows.Forms.TextBox();
            this.RestockIngredientsList = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RestockIngredientButton = new System.Windows.Forms.Button();
            this.AddMenuItemPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.AddMenuItemDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AddMenuItemPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddMenuItemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddMenuItemButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.PropertyChangePanel.SuspendLayout();
            this.RemoveMenuItemPanel.SuspendLayout();
            this.HireWaiterPanel.SuspendLayout();
            this.FireWaiterPanel.SuspendLayout();
            this.AddIngredientPanel.SuspendLayout();
            this.RestockIngredientPanel.SuspendLayout();
            this.AddMenuItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(427, 68);
            this.order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(219, 103);
            this.order.TabIndex = 0;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Waiter
            // 
            this.Waiter.Location = new System.Drawing.Point(89, 68);
            this.Waiter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Waiter.Name = "Waiter";
            this.Waiter.Size = new System.Drawing.Size(203, 103);
            this.Waiter.TabIndex = 1;
            this.Waiter.Text = "Properties";
            this.Waiter.UseVisualStyleBackColor = true;
            this.Waiter.Click += new System.EventHandler(this.Waiter_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.order);
            this.MainPanel.Controls.Add(this.Waiter);
            this.MainPanel.Location = new System.Drawing.Point(16, 15);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(768, 421);
            this.MainPanel.TabIndex = 2;
            // 
            // PropertyChangePanel
            // 
            this.PropertyChangePanel.Controls.Add(this.PropertiesList);
            this.PropertyChangePanel.Controls.Add(this.RemoveMenuItemPanel);
            this.PropertyChangePanel.Controls.Add(this.HireWaiterPanel);
            this.PropertyChangePanel.Controls.Add(this.FireWaiterPanel);
            this.PropertyChangePanel.Controls.Add(this.AddIngredientPanel);
            this.PropertyChangePanel.Controls.Add(this.RestockIngredientPanel);
            this.PropertyChangePanel.Controls.Add(this.AddMenuItemPanel);
            this.PropertyChangePanel.Location = new System.Drawing.Point(16, 15);
            this.PropertyChangePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PropertyChangePanel.Name = "PropertyChangePanel";
            this.PropertyChangePanel.Size = new System.Drawing.Size(768, 421);
            this.PropertyChangePanel.TabIndex = 3;
            this.PropertyChangePanel.Visible = false;
            // 
            // PropertiesList
            // 
            this.PropertiesList.FormattingEnabled = true;
            this.PropertiesList.ItemHeight = 16;
            this.PropertiesList.Items.AddRange(new object[] {
            "Hire Waiter",
            "Fire Waiter",
            "Add Menu Item",
            "Remove Menu Item",
            "Add Ingredient",
            "Restock Ingredient"});
            this.PropertiesList.Location = new System.Drawing.Point(8, 4);
            this.PropertiesList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PropertiesList.Name = "PropertiesList";
            this.PropertiesList.Size = new System.Drawing.Size(159, 404);
            this.PropertiesList.TabIndex = 0;
            this.PropertiesList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RemoveMenuItemPanel
            // 
            this.RemoveMenuItemPanel.Controls.Add(this.textBox1);
            this.RemoveMenuItemPanel.Controls.Add(this.button1);
            this.RemoveMenuItemPanel.Controls.Add(this.RemoveMenuItemList);
            this.RemoveMenuItemPanel.Controls.Add(this.label5);
            this.RemoveMenuItemPanel.Controls.Add(this.RemoveSelectedItemButton);
            this.RemoveMenuItemPanel.Location = new System.Drawing.Point(172, 4);
            this.RemoveMenuItemPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveMenuItemPanel.Name = "RemoveMenuItemPanel";
            this.RemoveMenuItemPanel.Size = new System.Drawing.Size(592, 414);
            this.RemoveMenuItemPanel.TabIndex = 3;
            this.RemoveMenuItemPanel.Visible = false;
            // 
            // RemoveMenuItemList
            // 
            this.RemoveMenuItemList.FormattingEnabled = true;
            this.RemoveMenuItemList.ItemHeight = 16;
            this.RemoveMenuItemList.Location = new System.Drawing.Point(71, 42);
            this.RemoveMenuItemList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveMenuItemList.Name = "RemoveMenuItemList";
            this.RemoveMenuItemList.Size = new System.Drawing.Size(176, 308);
            this.RemoveMenuItemList.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Remove Menu Item";
            // 
            // RemoveSelectedItemButton
            // 
            this.RemoveSelectedItemButton.Location = new System.Drawing.Point(71, 358);
            this.RemoveSelectedItemButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveSelectedItemButton.Name = "RemoveSelectedItemButton";
            this.RemoveSelectedItemButton.Size = new System.Drawing.Size(177, 28);
            this.RemoveSelectedItemButton.TabIndex = 2;
            this.RemoveSelectedItemButton.Text = "Remove Selected Item";
            this.RemoveSelectedItemButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedItemButton.Click += new System.EventHandler(this.RemoveSelectedItemButton_Click);
            // 
            // HireWaiterPanel
            // 
            this.HireWaiterPanel.Controls.Add(this.label3);
            this.HireWaiterPanel.Controls.Add(this.label2);
            this.HireWaiterPanel.Controls.Add(this.label1);
            this.HireWaiterPanel.Controls.Add(this.HireWaiterSubmitButton);
            this.HireWaiterPanel.Controls.Add(this.HireWaiterNameInput);
            this.HireWaiterPanel.Controls.Add(this.HireWaiterWageInput);
            this.HireWaiterPanel.Location = new System.Drawing.Point(172, 4);
            this.HireWaiterPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HireWaiterPanel.Name = "HireWaiterPanel";
            this.HireWaiterPanel.Size = new System.Drawing.Size(592, 414);
            this.HireWaiterPanel.TabIndex = 0;
            this.HireWaiterPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hire Waiter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // HireWaiterSubmitButton
            // 
            this.HireWaiterSubmitButton.Location = new System.Drawing.Point(115, 106);
            this.HireWaiterSubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HireWaiterSubmitButton.Name = "HireWaiterSubmitButton";
            this.HireWaiterSubmitButton.Size = new System.Drawing.Size(133, 28);
            this.HireWaiterSubmitButton.TabIndex = 2;
            this.HireWaiterSubmitButton.Text = "Hire Waiter";
            this.HireWaiterSubmitButton.UseVisualStyleBackColor = true;
            this.HireWaiterSubmitButton.Click += new System.EventHandler(this.HireWaiterSubmitButton_Click);
            // 
            // HireWaiterNameInput
            // 
            this.HireWaiterNameInput.Location = new System.Drawing.Point(115, 42);
            this.HireWaiterNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HireWaiterNameInput.Name = "HireWaiterNameInput";
            this.HireWaiterNameInput.Size = new System.Drawing.Size(132, 22);
            this.HireWaiterNameInput.TabIndex = 1;
            // 
            // HireWaiterWageInput
            // 
            this.HireWaiterWageInput.Location = new System.Drawing.Point(115, 74);
            this.HireWaiterWageInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HireWaiterWageInput.Name = "HireWaiterWageInput";
            this.HireWaiterWageInput.Size = new System.Drawing.Size(132, 22);
            this.HireWaiterWageInput.TabIndex = 0;
            // 
            // FireWaiterPanel
            // 
            this.FireWaiterPanel.Controls.Add(this.FireWaiterList);
            this.FireWaiterPanel.Controls.Add(this.label4);
            this.FireWaiterPanel.Controls.Add(this.FireSelectedWaiterButton);
            this.FireWaiterPanel.Location = new System.Drawing.Point(172, 4);
            this.FireWaiterPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FireWaiterPanel.Name = "FireWaiterPanel";
            this.FireWaiterPanel.Size = new System.Drawing.Size(592, 414);
            this.FireWaiterPanel.TabIndex = 1;
            this.FireWaiterPanel.Visible = false;
            // 
            // FireWaiterList
            // 
            this.FireWaiterList.FormattingEnabled = true;
            this.FireWaiterList.ItemHeight = 16;
            this.FireWaiterList.Location = new System.Drawing.Point(71, 42);
            this.FireWaiterList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FireWaiterList.Name = "FireWaiterList";
            this.FireWaiterList.Size = new System.Drawing.Size(176, 308);
            this.FireWaiterList.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fire Waiter";
            // 
            // FireSelectedWaiterButton
            // 
            this.FireSelectedWaiterButton.Location = new System.Drawing.Point(71, 358);
            this.FireSelectedWaiterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FireSelectedWaiterButton.Name = "FireSelectedWaiterButton";
            this.FireSelectedWaiterButton.Size = new System.Drawing.Size(177, 28);
            this.FireSelectedWaiterButton.TabIndex = 2;
            this.FireSelectedWaiterButton.Text = "Fire Selected Waiter";
            this.FireSelectedWaiterButton.UseVisualStyleBackColor = true;
            this.FireSelectedWaiterButton.Click += new System.EventHandler(this.FireSelectedWaiterButton_Click);
            // 
            // AddIngredientPanel
            // 
            this.AddIngredientPanel.Controls.Add(this.label14);
            this.AddIngredientPanel.Controls.Add(this.label13);
            this.AddIngredientPanel.Controls.Add(this.label12);
            this.AddIngredientPanel.Controls.Add(this.AddIngredientUnits);
            this.AddIngredientPanel.Controls.Add(this.AddIngredientAmount);
            this.AddIngredientPanel.Controls.Add(this.AddIngredientName);
            this.AddIngredientPanel.Controls.Add(this.label7);
            this.AddIngredientPanel.Controls.Add(this.AddIngredientButton);
            this.AddIngredientPanel.Location = new System.Drawing.Point(172, 4);
            this.AddIngredientPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddIngredientPanel.Name = "AddIngredientPanel";
            this.AddIngredientPanel.Size = new System.Drawing.Size(592, 414);
            this.AddIngredientPanel.TabIndex = 7;
            this.AddIngredientPanel.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 112);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Units";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 81);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 49);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Name";
            // 
            // AddIngredientUnits
            // 
            this.AddIngredientUnits.Location = new System.Drawing.Point(111, 110);
            this.AddIngredientUnits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddIngredientUnits.Name = "AddIngredientUnits";
            this.AddIngredientUnits.Size = new System.Drawing.Size(132, 22);
            this.AddIngredientUnits.TabIndex = 8;
            // 
            // AddIngredientAmount
            // 
            this.AddIngredientAmount.Location = new System.Drawing.Point(111, 78);
            this.AddIngredientAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddIngredientAmount.Name = "AddIngredientAmount";
            this.AddIngredientAmount.Size = new System.Drawing.Size(132, 22);
            this.AddIngredientAmount.TabIndex = 7;
            // 
            // AddIngredientName
            // 
            this.AddIngredientName.Location = new System.Drawing.Point(111, 46);
            this.AddIngredientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddIngredientName.Name = "AddIngredientName";
            this.AddIngredientName.Size = new System.Drawing.Size(132, 22);
            this.AddIngredientName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(4, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Add Ingredient";
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Location = new System.Drawing.Point(111, 142);
            this.AddIngredientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(133, 28);
            this.AddIngredientButton.TabIndex = 2;
            this.AddIngredientButton.Text = "Add Ingredient";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // RestockIngredientPanel
            // 
            this.RestockIngredientPanel.Controls.Add(this.label15);
            this.RestockIngredientPanel.Controls.Add(this.RestockIngredientAmount);
            this.RestockIngredientPanel.Controls.Add(this.RestockIngredientsList);
            this.RestockIngredientPanel.Controls.Add(this.label8);
            this.RestockIngredientPanel.Controls.Add(this.RestockIngredientButton);
            this.RestockIngredientPanel.Location = new System.Drawing.Point(172, 4);
            this.RestockIngredientPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RestockIngredientPanel.Name = "RestockIngredientPanel";
            this.RestockIngredientPanel.Size = new System.Drawing.Size(592, 414);
            this.RestockIngredientPanel.TabIndex = 8;
            this.RestockIngredientPanel.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 313);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Amount";
            // 
            // RestockIngredientAmount
            // 
            this.RestockIngredientAmount.Location = new System.Drawing.Point(84, 309);
            this.RestockIngredientAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RestockIngredientAmount.Name = "RestockIngredientAmount";
            this.RestockIngredientAmount.Size = new System.Drawing.Size(159, 22);
            this.RestockIngredientAmount.TabIndex = 7;
            // 
            // RestockIngredientsList
            // 
            this.RestockIngredientsList.FormattingEnabled = true;
            this.RestockIngredientsList.ItemHeight = 16;
            this.RestockIngredientsList.Location = new System.Drawing.Point(84, 41);
            this.RestockIngredientsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RestockIngredientsList.Name = "RestockIngredientsList";
            this.RestockIngredientsList.Size = new System.Drawing.Size(159, 260);
            this.RestockIngredientsList.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(4, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 26);
            this.label8.TabIndex = 5;
            this.label8.Text = "Restock Ingredient";
            // 
            // RestockIngredientButton
            // 
            this.RestockIngredientButton.Location = new System.Drawing.Point(84, 358);
            this.RestockIngredientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RestockIngredientButton.Name = "RestockIngredientButton";
            this.RestockIngredientButton.Size = new System.Drawing.Size(161, 28);
            this.RestockIngredientButton.TabIndex = 2;
            this.RestockIngredientButton.Text = "Restock Ingredient";
            this.RestockIngredientButton.UseVisualStyleBackColor = true;
            this.RestockIngredientButton.Click += new System.EventHandler(this.RestockIngredientButton_Click);
            // 
            // AddMenuItemPanel
            // 
            this.AddMenuItemPanel.Controls.Add(this.label11);
            this.AddMenuItemPanel.Controls.Add(this.AddMenuItemDescription);
            this.AddMenuItemPanel.Controls.Add(this.label10);
            this.AddMenuItemPanel.Controls.Add(this.AddMenuItemPrice);
            this.AddMenuItemPanel.Controls.Add(this.label9);
            this.AddMenuItemPanel.Controls.Add(this.AddMenuItemName);
            this.AddMenuItemPanel.Controls.Add(this.label6);
            this.AddMenuItemPanel.Controls.Add(this.AddMenuItemButton);
            this.AddMenuItemPanel.Location = new System.Drawing.Point(172, 4);
            this.AddMenuItemPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMenuItemPanel.Name = "AddMenuItemPanel";
            this.AddMenuItemPanel.Size = new System.Drawing.Size(592, 414);
            this.AddMenuItemPanel.TabIndex = 7;
            this.AddMenuItemPanel.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Description";
            // 
            // AddMenuItemDescription
            // 
            this.AddMenuItemDescription.Location = new System.Drawing.Point(115, 112);
            this.AddMenuItemDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMenuItemDescription.Multiline = true;
            this.AddMenuItemDescription.Name = "AddMenuItemDescription";
            this.AddMenuItemDescription.Size = new System.Drawing.Size(181, 131);
            this.AddMenuItemDescription.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Price";
            // 
            // AddMenuItemPrice
            // 
            this.AddMenuItemPrice.Location = new System.Drawing.Point(115, 78);
            this.AddMenuItemPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMenuItemPrice.Name = "AddMenuItemPrice";
            this.AddMenuItemPrice.Size = new System.Drawing.Size(181, 22);
            this.AddMenuItemPrice.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Name";
            // 
            // AddMenuItemName
            // 
            this.AddMenuItemName.Location = new System.Drawing.Point(115, 41);
            this.AddMenuItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMenuItemName.Name = "AddMenuItemName";
            this.AddMenuItemName.Size = new System.Drawing.Size(181, 22);
            this.AddMenuItemName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(4, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Add Menu Item";
            // 
            // AddMenuItemButton
            // 
            this.AddMenuItemButton.Location = new System.Drawing.Point(115, 251);
            this.AddMenuItemButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMenuItemButton.Name = "AddMenuItemButton";
            this.AddMenuItemButton.Size = new System.Drawing.Size(183, 28);
            this.AddMenuItemButton.TabIndex = 2;
            this.AddMenuItemButton.Text = "Add Menu Item";
            this.AddMenuItemButton.UseVisualStyleBackColor = true;
            this.AddMenuItemButton.Click += new System.EventHandler(this.AddMenuItemButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PropertyChangePanel);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.PropertyChangePanel.ResumeLayout(false);
            this.RemoveMenuItemPanel.ResumeLayout(false);
            this.RemoveMenuItemPanel.PerformLayout();
            this.HireWaiterPanel.ResumeLayout(false);
            this.HireWaiterPanel.PerformLayout();
            this.FireWaiterPanel.ResumeLayout(false);
            this.FireWaiterPanel.PerformLayout();
            this.AddIngredientPanel.ResumeLayout(false);
            this.AddIngredientPanel.PerformLayout();
            this.RestockIngredientPanel.ResumeLayout(false);
            this.RestockIngredientPanel.PerformLayout();
            this.AddMenuItemPanel.ResumeLayout(false);
            this.AddMenuItemPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button Waiter;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PropertyChangePanel;
        private System.Windows.Forms.ListBox PropertiesList;
        private System.Windows.Forms.Panel HireWaiterPanel;
        private System.Windows.Forms.Button HireWaiterSubmitButton;
        private System.Windows.Forms.TextBox HireWaiterNameInput;
        private System.Windows.Forms.TextBox HireWaiterWageInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel FireWaiterPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FireSelectedWaiterButton;
        private System.Windows.Forms.ListBox FireWaiterList;
        private System.Windows.Forms.Panel RemoveMenuItemPanel;
        private System.Windows.Forms.ListBox RemoveMenuItemList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button RemoveSelectedItemButton;
        private System.Windows.Forms.Panel AddMenuItemPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddMenuItemButton;
        private System.Windows.Forms.Panel AddIngredientPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddIngredientButton;
        private System.Windows.Forms.Panel RestockIngredientPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RestockIngredientButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AddMenuItemName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox AddMenuItemDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AddMenuItemPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AddIngredientUnits;
        private System.Windows.Forms.TextBox AddIngredientAmount;
        private System.Windows.Forms.TextBox AddIngredientName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox RestockIngredientAmount;
        private System.Windows.Forms.ListBox RestockIngredientsList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

