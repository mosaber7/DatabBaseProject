using System.Collections.Generic;
using DataAccess;
using DatabaseData.Models;
using DatabaseData.DataDelegates.NonQuery.Orders;
using DatabaseData.DataDelegates.Query.Orders;

namespace DatabaseData
{
    public class SqlOrderRepository
    {
        private readonly SqlCommandExecutor executor;

        /// <summary>
        /// Creates a OrderRepository based on the connectionString
        /// </summary>
        /// <param name="connectionString">ConnectionString to the Database in SQL format</param>
        public SqlOrderRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        /// <summary>
        /// Adds an order into the database
        /// </summary>
        /// <param name="waiterFirstName">Waiter's first name</param>
        /// <param name="waiterLastName">Waiter's last name</param>
        /// <param name="tableNumber">Table Number</param>
        /// <returns>Order's information</returns>
        public Order AddOrder(string waiterFirstName, string waiterLastName, int tableNumber)
        {
            return executor.ExecuteNonQuery(new AddOrderDelegate(waiterFirstName, waiterLastName, tableNumber));
        }

        /// <summary>
        /// Adds a food into an order
        /// </summary>
        /// <param name="orderID">Order's ID</param>
        /// <param name="menuItemName">Menu Item's name</param>
        /// <param name="quantity">Quantity</param>
        /// <param name="ingredientsUsedInFood">List of ingredients used to make that food</param>
        /// <returns>Food's information</returns>
        public Food AddFood(int orderID, string menuItemName, int quantity, IReadOnlyList<Ingredient> ingredientsUsedInFood)
        {
            Food food = executor.ExecuteNonQuery(new AddFoodDelegate(orderID, menuItemName, quantity));
            foreach(Ingredient i in ingredientsUsedInFood)
            {
                executor.ExecuteNonQuery(new AddFoodIngredientDelegate(food.ID, i.Name, i.AmountUsed));
            }
            food.IngredientsUsed = ingredientsUsedInFood;
            return food;
        }

        /// <summary>
        /// Returns all the foods in an order
        /// </summary>
        /// <param name="orderID">Order's ID</param>
        /// <returns>List of foods</returns>
        public IReadOnlyList<Food> GetFoodsFromOrder(int orderID)
        {
            IReadOnlyList<Food> foods = executor.ExecuteReader(new FetchAllFoodsFromOrderDelegate(orderID));

            foreach(Food f in foods)
            {
                f.IngredientsUsed = executor.ExecuteReader(new FetchAllIngredientsFromFoodDelegate(f.ID));
            }

            return foods;
        }

        /// <summary>
        /// Cancels an order
        /// </summary>
        /// <param name="orderID">Order's ID</param>
        public void CancelOrder(int orderID)
        {
            executor.ExecuteNonQuery(new CancelOrderDelegate(orderID));
        }

        /// <summary>
        /// Delivers an order
        /// (Marks it as completed)
        /// </summary>
        /// <param name="orderID">Order's ID</param>
        /// <param name="tip">Order's Tip</param>
        public void DeliverOrder(int orderID, decimal tip)
        {
            executor.ExecuteNonQuery(new DeliveredOrderDelegate(orderID, tip));
        }

        /// <summary>
        /// Gets the list of orders from a table
        /// </summary>
        /// <param name="tableNumber">Table Number</param>
        /// <returns>List of orders</returns>
        public IReadOnlyList<Order> FetchAllOrdersFromTable(int tableNumber)
        {
            return executor.ExecuteReader(new FetchAllOrdersFromTableDelegate(tableNumber));
        }
    }
}
