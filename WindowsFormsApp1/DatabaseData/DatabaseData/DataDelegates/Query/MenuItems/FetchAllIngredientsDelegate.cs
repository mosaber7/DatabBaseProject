using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DatabaseData.DataDelegates.Query.MenuItems
{
    internal class FetchAllIngredientsDelegate : DataReaderDelegate<IReadOnlyList<IngredientInformation>>
    {
        public FetchAllIngredientsDelegate()
            : base ("Restaurant.FetchAllIngredients")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<IngredientInformation> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<IngredientInformation> ingredientInformation = new List<IngredientInformation>();

            while(reader.Read())
            {
                ingredientInformation.Add(new IngredientInformation(
                    reader.GetString("Name"),
                    reader.GetValue<decimal>("Amount"),
                    reader.GetString("Units"),
                    reader.GetValue<decimal>("CostPerUnit")));
            }

            return ingredientInformation;
        }
    }
}
