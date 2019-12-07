using DataAccess;
using DatabaseData.Models;
using System;
using System.Data.SqlClient;

namespace DatabaseData.DataDelegates.NonQuery.MenuItems
{
    internal class AddMenuItemDelegate : NonQueryDataDelegate<MenuItem>
    {
        private readonly string name;
        private readonly string description;
        private readonly decimal price;

        public AddMenuItemDelegate(string name, string description, decimal price)
            :base("Restaurant.AddMenuItem")
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MenuItemName", name);
            command.Parameters.AddWithValue("Price", price);
            command.Parameters.AddWithValue("Description", description);
        }

        public override MenuItem Translate(SqlCommand command)
        {
            return new MenuItem(name, description, price);
        }
    }
}
