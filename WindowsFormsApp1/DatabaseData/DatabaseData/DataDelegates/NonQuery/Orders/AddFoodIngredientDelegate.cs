using DataAccess;
using DatabaseData.Models;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DatabaseData.DataDelegates.NonQuery.Orders
{
    internal class AddFoodIngredientDelegate : NonQueryDataDelegate<Ingredient>
    {
        private readonly int foodID;
        private readonly string ingredientName;
        private readonly decimal amount;

        public AddFoodIngredientDelegate(int foodID, string ingredientName, decimal amountUsed)
            : base ("Restaurant.AddFoodIngredient")
        {
            this.foodID = foodID;
            this.ingredientName = ingredientName;
            amount = amountUsed;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("FoodID", foodID);
            command.Parameters.AddWithValue("IngredientName", ingredientName);
            command.Parameters.AddWithValue("AmountUsed", amount);
        }

        public override Ingredient Translate(SqlCommand command)
        {
            return new Ingredient(ingredientName, amount);
        }
    }
}
