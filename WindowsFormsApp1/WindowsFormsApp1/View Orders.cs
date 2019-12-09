using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseData.Models;
using DatabaseData;

namespace WindowsFormsApp1
{
    public partial class View_Orders : Form
    {
        readonly int tableNumber;
        SqlOrderRepository orderRepository;
        public View_Orders(int tableNumber)
        {
            InitializeComponent();
            this.tableNumber = tableNumber;
        }

        private void OrdersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodsListBox.Items.Clear();

            if (OrdersListBox.SelectedItem != null)
            {
                int orderID = Convert.ToInt32(OrdersListBox.SelectedItem.ToString());

                IReadOnlyList<Food> foods = orderRepository.GetFoodsFromOrder(orderID);

                foreach (Food f in foods)
                {
                    FoodsListBox.Items.Add(f.Name + ", " + f.Quantity);
                    foreach (Ingredient i in f.IngredientsUsed)
                    {
                        FoodsListBox.Items.Add(" " + i.Name);
                    }
                }
            }
        }

        private void FoodsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (OrdersListBox.SelectedItem != null)
            {
                try
                {
                    decimal tip = Convert.ToDecimal(textBox1.Text);
                    orderRepository.DeliverOrder(Convert.ToInt32(OrdersListBox.SelectedItem.ToString()), tip);
                    OrdersListBox.Items.Remove(OrdersListBox.SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (OrdersListBox.SelectedItem != null)
            {
                try
                {
                    orderRepository.CancelOrder(Convert.ToInt32(OrdersListBox.SelectedItem.ToString()));
                    OrdersListBox.Items.Remove(OrdersListBox.SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void View_Orders_Load(object sender, EventArgs e)
        {

            Text = "View Orders from Table " + tableNumber.ToString();

            string connectionString = "Server=mssql.cs.ksu.edu;Database=santiagoscavone;UID=santiagoscavone;Pwd=Sqlpassword1!";

            orderRepository = new SqlOrderRepository(connectionString);

            IReadOnlyList<DatabaseData.Models.Order> orders = orderRepository.FetchAllOrdersFromTable(tableNumber);

            foreach (DatabaseData.Models.Order o in orders)
            {
                OrdersListBox.Items.Add(o.OrderID);
            }
        }

        private void View_Orders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tables t = new Tables();
            t.Show();
        }
    }
}
