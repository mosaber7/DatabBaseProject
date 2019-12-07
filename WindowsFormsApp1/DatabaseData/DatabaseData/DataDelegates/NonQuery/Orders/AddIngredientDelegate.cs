using DataAccess;
using DatabaseData.Models;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DatabaseData.DataDelegates.NonQuery.Orders
{
    internal class AddIngredientDelegate : NonQueryDataDelegate<IngredientInformation>
    {
        private readonly string name;
        private readonly decimal amount;
        private readonly string units;
        private readonly decimal costPerUnit;

        public AddIngredientDelegate(string ingredientName, decimal amount, string measurmentUnits, decimal costPerUnit)
            : base ("Restaurant.AddIngredient")
        {
            name = ingredientName;
            this.amount = amount;
            units = measurmentUnits;
            this.costPerUnit = costPerUnit;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("Name", name);
            command.Parameters.AddWithValue("Amount", amount);
            command.Parameters.AddWithValue("Units", units);
            command.Parameters.AddWithValue("CostPerUnit", costPerUnit);
        }

        public override IngredientInformation Translate(SqlCommand command)
        {
            return new IngredientInformation(name, amount, units, costPerUnit);
        }
    }
}
