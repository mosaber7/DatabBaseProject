using DataAccess;
using DatabaseData.Models;
using System;
using System.Data.SqlClient;

namespace DatabaseData.DataDelegates.NonQuery.MenuItems
{
    internal class RemoveMenuItemDelegate : NonQueryDataDelegate<MenuItem>
    {
        private readonly string name;

        public RemoveMenuItemDelegate(string name)
            : base("Restaurant.RemoveMenuItem")
        {
            this.name = name;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            command.Parameters.AddWithValue("MenuItemName", name);
        }

        public override MenuItem Translate(SqlCommand command)
        {
            return null;
        }
    }
}
