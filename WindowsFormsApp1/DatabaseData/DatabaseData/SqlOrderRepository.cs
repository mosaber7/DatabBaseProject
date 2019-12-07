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

        public SqlOrderRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Order AddOrder(string waiterFirstName, string waiterLastName, int tableNumber)
        {
            return executor.ExecuteNonQuery(new AddOrderDelegate(waiterFirstName, waiterLastName, tableNumber));
        }

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

        public IReadOnlyList<Food> GetFoodsFromOrder(int orderID)
        {
            IReadOnlyList<Food> foods = executor.ExecuteReader(new FetchAllFoodsFromOrderDelegate(orderID));

            foreach(Food f in foods)
            {
                f.IngredientsUsed = executor.ExecuteReader(new FetchAllIngredientsFromFoodDelegate(f.ID));
            }

            return foods;
        }
    }
}
