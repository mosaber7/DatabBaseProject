using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseData;

namespace WindowsFormsApp1
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        IReadOnlyList<DatabaseData.Models.Ingredient> ing;
        List<DatabaseData.Models.MenuItem> items;
        DatabaseData.Models.MenuItem chossenitem;
        private void Combo1_clicked(object sender, EventArgs e)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=santiagoscavone;UID=santiagoscavone;Pwd=Sqlpassword1!";
            SqlMenuItemsRepository sql = new SqlMenuItemsRepository(connectionString);
            items = new List<DatabaseData.Models.MenuItem>();
            foreach (DatabaseData.Models.MenuItem i in sql.FetchActiveMenuItems())
            {
                if (!(comboBox1.Items.Contains(i.Name)))
                {
                    comboBox1.Items.Add(i.Name);
                    items.Add(i);
                }
            }

        }
        int x;
        /// <summary>
        /// changing the sellected item from the order chosse list
        /// </summary>
        List<string> removeditems = new List<string>();
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=santiagoscavone;UID=santiagoscavone;Pwd=Sqlpassword1!";
            SqlMenuItemsRepository sql = new SqlMenuItemsRepository(connectionString);
            if (comboBox1.SelectedIndex >= 0)
            {
                Console.WriteLine("shit");
                Console.WriteLine("" + comboBox1.SelectedItem.ToString());
                foreach (var i in comboBox1.Items)
                {
                    switch (i)
                    {

                        case "Salad":
                            x = 0;
                            Console.WriteLine("rrr");
                            break;

                    }




                }


                

                

            }

        }

        private void Waiter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// when we wanna delete ingreients from the ingredients list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=santiagoscavone;UID=santiagoscavone;Pwd=Sqlpassword1!";
            SqlMenuItemsRepository sql = new SqlMenuItemsRepository(connectionString);
            if (comboBox1.SelectedIndex >= 0)
            {
                removeditems.Add("" + comboBox1.SelectedIndex);
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }
        IReadOnlyCollection<DatabaseData.Models.MenuItem> ingredients;
        private void ComboBox2_MouseEnter(object sender, EventArgs e)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=santiagoscavone;UID=santiagoscavone;Pwd=Sqlpassword1!";
            SqlMenuItemsRepository sql = new SqlMenuItemsRepository(connectionString);
            if (chossenitem != null)
            {
                foreach (DatabaseData.Models.Ingredient ing in chossenitem.Ingredients)
                {

                    comboBox2.Items.Add(ing);
                }
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        

       
    }
}
