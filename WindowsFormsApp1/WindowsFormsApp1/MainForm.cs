using System.Collections.Generic;
using System;
using System.Windows.Forms;
using DatabaseData;
using DatabaseData.Models;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        SqlMenuItemsRepository menuItemsDataManager;
        SqlOrderRepository ordersDataManager;
        SqlWaiterRepository waitersDataManager;

        public MainForm()
        {
            InitializeComponent();

            string connectionString = "Server=mssql.cs.ksu.edu;Database=santiagoscavone;UID=santiagoscavone;Pwd=Sqlpassword1!";

            menuItemsDataManager = new SqlMenuItemsRepository(connectionString);
            ordersDataManager = new SqlOrderRepository(connectionString);
            waitersDataManager = new SqlWaiterRepository(connectionString);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Waiter_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            /*menuItemsDataManager.AddIngredient("Tortilla", 30, "UNITS", 0.33m);
            menuItemsDataManager.AddIngredient("Guacamole", 40, "UNITS", 0.25m);
            menuItemsDataManager.AddIngredient("Chicken", 50, "kg", 1.5m);
            menuItemsDataManager.AddIngredient("Burrito Sauce", 50000, "mL", 0.1m);
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient("Tortilla", 1));
            ingredients.Add(new Ingredient("Guacamole", 1));
            ingredients.Add(new Ingredient("Chicken", 0.2m));
            ingredients.Add(new Ingredient("Burrito Sauce", 0.15m));
            menuItemsDataManager.AddMenuItem("Burrito", "Yummy", 9.5m, ingredients);*/
            IReadOnlyList<DatabaseData.Models.MenuItem> menuItems = menuItemsDataManager.FetchActiveMenuItems();
            foreach(DatabaseData.Models.MenuItem mi in menuItems)
            {
                MessageBox.Show("Name: " + mi.Name);
            }
        }
    }
}
