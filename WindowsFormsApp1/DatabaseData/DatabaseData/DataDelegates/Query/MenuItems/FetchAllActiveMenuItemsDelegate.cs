using DataAccess;
using DatabaseData.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DatabaseData.DataDelegates.Query.MenuItems
{
    internal class FetchAllActiveMenuItemsDelegate : DataReaderDelegate<IReadOnlyList<MenuItem>>
    {
        public FetchAllActiveMenuItemsDelegate()
            : base("Restaurant.FetchAllActiveMenuItems")
        {

        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<MenuItem> Translate(SqlCommand command, IDataRowReader reader)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            while(reader.Read())
            {
                menuItems.Add(new MenuItem(
                    reader.GetString("Name"), reader.GetString("Description"),
                    reader.GetValue<decimal>("Price")));
            }

            return menuItems;
        }
    }
}
