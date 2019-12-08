using System.Collections.Generic;
using DataAccess;
using DatabaseData.Models;
using DatabaseData.DataDelegates.NonQuery.MenuItems;
using DatabaseData.DataDelegates;
using System;
using DatabaseData.DataDelegates.Query.MenuItems;

namespace DatabaseData
{
    public class SqlMenuItemsRepository
    {
        private readonly SqlCommandExecutor executor;

        /// <summary>
        /// Creates a MenuItemsRepository based on the connectionString
        /// </summary>
        /// <param name="connectionString">ConnectionString to the Database in SQL format</param>
        public SqlMenuItemsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        /// <summary>
        /// Adds a MenuItem into the database
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="description">Description</param>
        /// <param name="price">Price</param>
        /// <param name="ingredients">List of Ingredients of the MenuItems</param>
        /// <returns></returns>
        public MenuItem AddMenuItem(string name, string description, decimal price, IReadOnlyList<Ingredient> ingredients)
        {
            MenuItem mi = executor.ExecuteNonQuery(new AddMenuItemDelegate(name, description, price));

            foreach (Ingredient i in ingredients)
            {
                executor.ExecuteNonQuery(new AddMenuItemIngredientDelegate(mi.Name, i.Name, i.AmountUsed));
            }

            return mi;
        }

        /// <summary>
        /// Removes a Menu Item from the Database
        /// </summary>
        /// <param name="menuItemName">Name of the Menu Item</param>
        public void RemoveMenuItem(string menuItemName)
        {
            executor.ExecuteNonQuery(new RemoveMenuItemDelegate(menuItemName));
        }

        /// <summary>
        /// Adds an Ingredient into the database
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="amount">Amount of the ingredient</param>
        /// <param name="units">Units to measure the amount</param>
        /// <param name="costPerUnit">Cost per unit of that ingredient</param>
        /// <returns></returns>
        public IngredientInformation AddIngredient(string name, decimal amount, string units, decimal costPerUnit)
        {
            return executor.ExecuteNonQuery(new AddIngredientDelegate(name, amount, units, costPerUnit));
        }

        /// <summary>
        /// Returns a list with all the currently active menu items in the database
        /// </summary>
        /// <returns>List of Menu Items</returns>
        public IReadOnlyList<MenuItem> FetchActiveMenuItems()
        {
            IReadOnlyList<MenuItem> menuItems = executor.ExecuteReader(new FetchAllActiveMenuItemsDelegate());

            foreach(MenuItem mi in menuItems)
            {
                mi.Ingredients = executor.ExecuteReader(new FetchAllIngredientsFromActiveMenuItemDelegate(mi.Name));
            }

            return menuItems;
        }

        /// <summary>
        /// Returns all the ingredients in the database
        /// </summary>
        /// <returns>List of all the ingredients</returns>
        public IReadOnlyList<IngredientInformation> FetchAllIngredients()
        {
            return executor.ExecuteReader(new FetchAllIngredientsDelegate());
        }

        /// <summary>
        /// Adds the amount passed as a parameter into the ingredient's amount
        /// </summary>
        /// <param name="ingredientName">Ingredient's name</param>
        /// <param name="amountToRestock">Amount to add</param>
        /// <returns></returns>
        public decimal RestockIngredient(string ingredientName, decimal amountToRestock)
        {
            return executor.ExecuteNonQuery(new RestockIngredientDelegate(ingredientName, amountToRestock));
        }
    }
}