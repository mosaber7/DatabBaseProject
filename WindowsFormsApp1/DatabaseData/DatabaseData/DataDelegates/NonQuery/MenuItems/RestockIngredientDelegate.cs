using DataAccess;
using DatabaseData.Models;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DatabaseData.DataDelegates.NonQuery.MenuItems
{
    internal class RestockIngredientDelegate : NonQueryDataDelegate<decimal>
    {
        private readonly string name;
        private readonly decimal amount;

        public RestockIngredientDelegate(string ingredientName, decimal amountToRestock)
            : base("Restaurant.RestockIngredient")
        {
            name = ingredientName;
            amount = amountToRestock;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("IngredientName", name);
            command.Parameters.AddWithValue("AmountToRestock", amount);

        }

        public override decimal Translate(SqlCommand command)
        {
            return amount;
        }
    }
}
