using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DatabaseData;
using DatabaseData.Models;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private string connectionString = "Server=mssql.cs.ksu.edu;Database=santiagoscavone;UID=santiagoscavone;Password=Sqlpassword1!";
        private System.Windows.Forms.Panel[] PropertiesDict;
        private int ActivePane = 0;

        public MainForm()
        {
            InitializeComponent();
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
            decimal Wage = decimal.Parse(HireWaiterWageInput.Text);

            string FirstName = Name.Substring(0, Name.IndexOf(' '));
            string LastName = Name.Substring(Name.IndexOf(' ') + 1);

            SqlWaiterRepository sql = new SqlWaiterRepository(connectionString);
            sql.AddWaiter(FirstName, LastName, Wage);

            FireWaiterList.Items.Clear();
            FireWaiterListLoad(null, null);
        }

        private void FireSelectedWaiterButton_Click(object sender, EventArgs e)
        {
            string Name = FireWaiterList.SelectedItem.ToString();
            string FirstName = Name.Substring(0, Name.IndexOf(' '));
            string LastName = Name.Substring(Name.IndexOf(' ') + 1);

            SqlWaiterRepository sql = new SqlWaiterRepository(connectionString);
            sql.FireWaiter(FirstName, LastName);

            FireWaiterList.Items.Clear();
            FireWaiterListLoad(null, null);
        }

        private void AddMenuItemButton_Click(object sender, EventArgs e)
        {
            // TODO test.
            string Name = AddMenuItemName.Text;
            decimal Price = decimal.Parse(AddMenuItemPrice.Text);
            string Description = AddMenuItemDescription.Text;

            SqlMenuItemsRepository sql = new SqlMenuItemsRepository(connectionString);
            sql.AddMenuItem(Name, Description, Price, null);

            
            RemoveMenuItemListLoad(null, null);
        }

        // Functional.
        private void RemoveSelectedItemButton_Click(object sender, EventArgs e)
        {
            string RemovedMenuItem = RemoveMenuItemList.SelectedItem.ToString();

            SqlMenuItemsRepository sql = new SqlMenuItemsRepository(connectionString);
            sql.RemoveMenuItem(RemovedMenuItem);
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
            // TODO test.
            SqlWaiterRepository sql = new SqlWaiterRepository(connectionString);
            foreach (Waiter waiter in sql.FetchAllWaiters())
            {
                FireWaiterList.Items.Add(waiter.FirstName + " " + waiter.LastName);
            }
        }

        private void RemoveMenuItemListLoad(object sender, EventArgs e)
        {
            // TODO test.
            SqlMenuItemsRepository sql = new SqlMenuItemsRepository(connectionString);
            foreach (DatabaseData.Models.MenuItem item in sql.FetchActiveMenuItems())
            {
                RemoveMenuItemList.Items.Add(item.Name);
            }
        }

        private void RestockIngredientListLoad(object sender, EventArgs e)
        {
            // TODO SQL query to populate list.
        }
    }
}