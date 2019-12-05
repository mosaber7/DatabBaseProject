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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(441, 82);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(219, 103);
            this.order.TabIndex = 0;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Waiter
            // 
            this.Waiter.Location = new System.Drawing.Point(106, 82);
            this.Waiter.Name = "Waiter";
            this.Waiter.Size = new System.Drawing.Size(203, 103);
            this.Waiter.TabIndex = 1;
            this.Waiter.Text = "button2";
            this.Waiter.UseVisualStyleBackColor = true;
            this.Waiter.Click += new System.EventHandler(this.Waiter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Waiter);
            this.Controls.Add(this.order);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button Waiter;
        private System.Windows.Forms.Button button1;
    }
}

