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

        public SqlMenuItemsRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public MenuItem AddMenuItem(string name, string description, decimal price, IReadOnlyList<Ingredient> ingredients)
        {
            MenuItem mi = executor.ExecuteNonQuery(new AddMenuItemDelegate(name, description, price));

            foreach (Ingredient i in ingredients)
            {
                executor.ExecuteNonQuery(new AddMenuItemIngredientDelegate(mi.Name, i.Name, i.AmountUsed));
            }

            return mi;
        }

        public IngredientInformation AddIngredient(string name, decimal amount, string units, decimal costPerUnit)
        {
            return executor.ExecuteNonQuery(new AddIngredientDelegate(name, amount, units, costPerUnit));
        }

        public IReadOnlyList<MenuItem> FetchActiveMenuItems()
        {
            return executor.ExecuteReader(new FetchAllActiveMenuItemsDelegate());
        }
    }
}