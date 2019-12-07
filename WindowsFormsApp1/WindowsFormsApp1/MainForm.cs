using System;
using System.Windows.Forms;
using DatabaseData;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        SqlMenuItemsRepository menuItemsDataManager;
        SqlOrderRepository ordersDataManager;
        SqlWaiterRepository waitersDataManager;

        public MainForm()
        {
            InitializeComponent();

            string connectionString = "Server=mssql.cs.ksu.edu;Database=santiagoscavone;UID=santiagoscavone;Pwd=Sqlpassword1!";

            menuItemsDataManager = new SqlMenuItemsRepository(connectionString);
            ordersDataManager = new SqlOrderRepository(connectionString);
            waitersDataManager = new SqlWaiterRepository(connectionString);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Waiter_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //menuItemsDataManager.AddIngredient("")
        }
    }
}
