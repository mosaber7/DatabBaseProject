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
            List<Ingredient> ingredientsBurrito = new List<Ingredient>();
            ingredientsBurrito.Add(new Ingredient("Tortilla", 1));
            ingredientsBurrito.Add(new Ingredient("Guacamole", 1));
            ingredientsBurrito.Add(new Ingredient("Chicken", 0.2m));
            ingredientsBurrito.Add(new Ingredient("Burrito Sauce", 0.15m));

            List<Ingredient> ingredientsBurger = new List<Ingredient>();
            ingredientsBurger.Add(new Ingredient("Burger Meat", 1));
            ingredientsBurger.Add(new Ingredient("Burger Bun", 2));
            ingredientsBurger.Add(new Ingredient("Cheddar Cheese", 0.2m));
            ingredientsBurger.Add(new Ingredient("Ketchup", 0.15m));

            /*menuItemsDataManager.AddIngredient("Tortilla", 30, "UNITS", 0.33m);
            menuItemsDataManager.AddIngredient("Guacamole", 40, "UNITS", 0.25m);
            menuItemsDataManager.AddIngredient("Chicken", 50, "kg", 1.5m);
            menuItemsDataManager.AddIngredient("Burrito Sauce", 50000, "mL", 0.1m);
            menuItemsDataManager.AddMenuItem("Burrito", "Yummy", 9.5m, ingredients);
            IReadOnlyList<DatabaseData.Models.MenuItem> menuItems = menuItemsDataManager.FetchActiveMenuItems();
            foreach(DatabaseData.Models.MenuItem mi in menuItems)
            {
                MessageBox.Show("Name: " + mi.Name);
            }*/


            /*Order order= ordersDataManager.AddOrder("name", "last", 1);
            ordersDataManager.AddFood(order.OrderID, "Burrito", 2, ingredientsBurrito);
            ordersDataManager.AddFood(order.OrderID, "Burger", 2, ingredientsBurger);

            IReadOnlyList<Food> foodsFromOrder = ordersDataManager.GetFoodsFromOrder(order.OrderID);
            foreach(Food f in foodsFromOrder)
            {
                MessageBox.Show("Name: " + f.Name + "\nPrice: " + f.Price + "\nQuantity" + f.Quantity);
            }

            ordersDataManager.CancelOrder(order.OrderID);*/

            waitersDataManager.FireWaiter("Kevin", "Johnson");
            waitersDataManager.AddWaiter("Kevin", "Johnson", 7.5m);
            DateTime start = new DateTime(2019, 12, 7, 7, 0, 0);
            DateTime end = new DateTime(2019, 12, 7, 18, 30, 0);

            waitersDataManager.AddShift("Kevin", "Johnson", start, end);
        }
    }
}
