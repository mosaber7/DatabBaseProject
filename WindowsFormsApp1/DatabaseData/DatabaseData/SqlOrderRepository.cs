using System.Collections.Generic;
using DataAccess;
using DatabaseData.Models;
using DatabaseData.DataDelegates.NonQuery.Orders;
using DatabaseData.DataDelegates;
using System;
using DatabaseData.DataDelegates.Query;

namespace DatabaseData
{
    public class SqlOrderRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlOrderRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Order AddOrder(string waiterFirstName, string waiterLastName, int tableNumber)
        {
            return executor.ExecuteNonQuery(new AddOrderDelegate(waiterFirstName, waiterLastName, tableNumber));
        }

        public void AddFood(int orderID, string menuItemName, int quantity, Ingredient[] ingredientsUsedInFood)
        {
            Food food = executor.ExecuteNonQuery(new AddFoodDelegate(orderID, menuItemName, quantity));
            foreach(Ingredient i in ingredientsUsedInFood)
            {
                executor.ExecuteNonQuery(new AddFoodIngredientDelegate(food.ID, i.Name, i.AmountUsed));
            }
        }
    }
}
