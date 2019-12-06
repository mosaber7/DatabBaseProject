using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DatabaseData;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private System.Windows.Forms.Panel[] PropertiesDict;
        private int ActivePane = 0;

        public MainForm()
        {
            InitializeComponent();
            TsqlExecutionAgent tea = new TsqlExecutionAgent("mssql.cs.ksu.edu", "mri", "mri", "");
            tea.ExecuteQuery();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Waiter_Click(object sender, EventArgs e)
        {
            MainPanel.Hide();
            PropertyChangePanel.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PropertiesDict = new[] {
                HireWaiterPanel,
                FireWaiterPanel,
                AddMenuItemPanel,
                RemoveMenuItemPanel,
                AddIngredientPanel,
                RestockIngredientPanel
            };
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PropertiesDict[ActivePane].Hide();
            PropertiesDict[PropertiesList.SelectedIndex].BringToFront();
            PropertiesDict[PropertiesList.SelectedIndex].Show();
            ActivePane = PropertiesList.SelectedIndex;
        }

        private void HireWaiterSubmitButton_Click(object sender, EventArgs e)
        {
            string Name = HireWaiterNameInput.Text;
            string Wage = HireWaiterWageInput.Text;

            // TODO Fill.
        }

        private void FireSelectedWaiterButton_Click(object sender, EventArgs e)
        {
            //string FiredWaiters = FireWaiterList.SelectedValue;
        }

        private void AddMenuItemButton_Click(object sender, EventArgs e)
        {
            string Name = AddMenuItemName.Text;
            string Price = AddMenuItemPrice.Text;
            string Description = AddMenuItemDescription.Text;

            // TODO Fill.
        }

        private void RemoveSelectedItemButton_Click(object sender, EventArgs e)
        {

        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            string Name = AddIngredientName.Text;
            string Amount = AddIngredientAmount.Text;
            string Units = AddIngredientUnits.Text;

            // TODO Fill.
        }

        private void RestockIngredientButton_Click(object sender, EventArgs e)
        {
            string NewAmount = RestockIngredientAmount.Text;

            // TODO Fill.
        }

        private void FireWaiterListLoad(object sender, EventArgs e)
        {
            // TODO SQL query to populate list.
        }

        private void RemoveMenuItemListLoad(object sender, EventArgs e)
        {
            // TODO SQL query to populate list.
        }

        private void RestockIngredientListLoad(object sender, EventArgs e)
        {
            // TODO SQL query to populate list.
        }
    }
}
