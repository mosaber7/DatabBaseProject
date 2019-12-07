namespace WindowsFormsApp1
{
    partial class ClockInOut
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
            this.ClockInOutPanel = new System.Windows.Forms.Panel();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.ClockInOutInput = new System.Windows.Forms.TextBox();
            this.ClockInSubmit = new System.Windows.Forms.Button();
            this.ClockOutSubmit = new System.Windows.Forms.Button();
            this.ClockInOutResultsLabel = new System.Windows.Forms.Label();
            this.ClockInOutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClockInOutPanel
            // 
            this.ClockInOutPanel.Controls.Add(this.ClockInOutResultsLabel);
            this.ClockInOutPanel.Controls.Add(this.ClockOutSubmit);
            this.ClockInOutPanel.Controls.Add(this.ClockInSubmit);
            this.ClockInOutPanel.Controls.Add(this.ClockInOutInput);
            this.ClockInOutPanel.Controls.Add(this.EmployeeNameLabel);
            this.ClockInOutPanel.Location = new System.Drawing.Point(12, 12);
            this.ClockInOutPanel.Name = "ClockInOutPanel";
            this.ClockInOutPanel.Size = new System.Drawing.Size(246, 137);
            this.ClockInOutPanel.TabIndex = 0;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(13, 16);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.EmployeeNameLabel.TabIndex = 1;
            this.EmployeeNameLabel.Text = "Employee Name";
            // 
            // ClockInOutInput
            // 
            this.ClockInOutInput.Location = new System.Drawing.Point(103, 13);
            this.ClockInOutInput.Name = "ClockInOutInput";
            this.ClockInOutInput.Size = new System.Drawing.Size(123, 20);
            this.ClockInOutInput.TabIndex = 2;
            // 
            // ClockInSubmit
            // 
            this.ClockInSubmit.Location = new System.Drawing.Point(16, 43);
            this.ClockInSubmit.Name = "ClockInSubmit";
            this.ClockInSubmit.Size = new System.Drawing.Size(210, 23);
            this.ClockInSubmit.TabIndex = 3;
            this.ClockInSubmit.Text = "Clock In";
            this.ClockInSubmit.UseVisualStyleBackColor = true;
            this.ClockInSubmit.Click += new System.EventHandler(this.ClockInSubmit_Click);
            // 
            // ClockOutSubmit
            // 
            this.ClockOutSubmit.Location = new System.Drawing.Point(16, 72);
            this.ClockOutSubmit.Name = "ClockOutSubmit";
            this.ClockOutSubmit.Size = new System.Drawing.Size(210, 23);
            this.ClockOutSubmit.TabIndex = 4;
            this.ClockOutSubmit.Text = "Clock Out";
            this.ClockOutSubmit.UseVisualStyleBackColor = true;
            this.ClockOutSubmit.Click += new System.EventHandler(this.ClockOutSubmit_Click);
            // 
            // ClockInOutResultsLabel
            // 
            this.ClockInOutResultsLabel.AutoSize = true;
            this.ClockInOutResultsLabel.Location = new System.Drawing.Point(13, 107);
            this.ClockInOutResultsLabel.Name = "ClockInOutResultsLabel";
            this.ClockInOutResultsLabel.Size = new System.Drawing.Size(108, 13);
            this.ClockInOutResultsLabel.TabIndex = 1;
            this.ClockInOutResultsLabel.Text = "Awaiting User Input...";
            // 
            // ClockInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 161);
            this.Controls.Add(this.ClockInOutPanel);
            this.Name = "ClockInOut";
            this.Text = "Clock";
            this.ClockInOutPanel.ResumeLayout(false);
            this.ClockInOutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ClockInOutPanel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Button ClockOutSubmit;
        private System.Windows.Forms.Button ClockInSubmit;
        private System.Windows.Forms.TextBox ClockInOutInput;
        private System.Windows.Forms.Label ClockInOutResultsLabel;
    }
}