using DataAccess;
using DatabaseData.Models;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DatabaseData.DataDelegates.NonQuery.MenuItems
{
    internal class AddIngredientDelegate : NonQueryDataDelegate<IngredientInformation>
    {
        private readonly string ingredientName;
        private readonly decimal amount;
        private readonly string units;
        private readonly decimal costPerUnit;

        public AddIngredientDelegate(string ingredientName, decimal amount, string measurementUnits, decimal costPerUnit)
            : base ("Restaurant.AddIngredient")
        {
            this.ingredientName = ingredientName;
            this.amount = amount;
            units = measurementUnits;
            this.costPerUnit = costPerUnit;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", ingredientName);
            command.Parameters.AddWithValue("Amount", amount);
            command.Parameters.AddWithValue("Units", units);
            command.Parameters.AddWithValue("CostPerUnit", costPerUnit);
        }

        public override IngredientInformation Translate(SqlCommand command)
        {
            return new IngredientInformation(
                ingredientName, amount, units, costPerUnit);
        }
    }
}
