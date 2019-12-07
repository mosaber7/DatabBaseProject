using DataAccess;
using DatabaseData.Models;
using System;
using System.Data.SqlClient;

namespace DatabaseData.DataDelegates.NonQuery.MenuItems
{
    internal class AddMenuItemIngredientDelegate : NonQueryDataDelegate<Ingredient>
    {
        private readonly string menuItemName;
        private readonly string ingredientName;
        private readonly decimal amountUsed;

        public AddMenuItemIngredientDelegate(string menuItemName, string ingredientName, decimal amountUsed)
            : base("Restaurant.AddMenuItemIngredient")
        {
            this.menuItemName = menuItemName;
            this.ingredientName = ingredientName;
            this.amountUsed = amountUsed;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MenuItemName", menuItemName);
            command.Parameters.AddWithValue("IngredientName", ingredientName);
            command.Parameters.AddWithValue("AmountUsed", amountUsed);
        }

        public override Ingredient Translate(SqlCommand command)
        {
            return new Ingredient(ingredientName, amountUsed);
        }
    }
}
