using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DatabaseData.DataDelegates.Query.MenuItems
{
    internal class FetchAllIngredientsFromActiveMenuItemDelegate : DataReaderDelegate<IReadOnlyList<Ingredient>>
    {
        private readonly string menuItemName;

        public FetchAllIngredientsFromActiveMenuItemDelegate(string menuItemName)
            :base("Restaurant.FetchAllIngredientsFromActiveMenuItem")
        {
            this.menuItemName = menuItemName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MenuItemName", menuItemName);
        }

        public override IReadOnlyList<Ingredient> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            while(reader.Read())
            {
                ingredients.Add(new Ingredient(
                    reader.GetString("Name"), reader.GetValue<decimal>("AmountUsed")));
            }

            return ingredients;
        }
    }
}
