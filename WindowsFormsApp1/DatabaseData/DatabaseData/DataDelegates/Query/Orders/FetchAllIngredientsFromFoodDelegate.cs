using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DatabaseData.DataDelegates.Query.Orders
{
    internal class FetchAllIngredientsFromFoodDelegate : DataReaderDelegate<IReadOnlyList<Ingredient>>
    {
        private readonly int foodID;

        public FetchAllIngredientsFromFoodDelegate(int foodID)
            : base("Restaurant.FetchAllIngredientsFromFood")
        {
            this.foodID = foodID;
        }


        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("FoodID", foodID);
        }

        public override IReadOnlyList<Ingredient> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            while(reader.Read())
            {
                ingredients.Add(new Ingredient(
                    reader.GetString("Name"), 
                    decimal.Parse(reader.GetString("AmountUsed"))));
            }

            return ingredients;
        }
    }
}
