using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DatabaseData;
using DatabaseData.Models;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private readonly string connectionString = "Server=mssql.cs.ksu.edu;Database=santiagoscavone;UID=santiagoscavone;Password=Sqlpassword1!";
        private System.Windows.Forms.Panel[] PropertiesDict;
        private System.Windows.Forms.Panel[] ReportsDict;
        private int ActivePane = 0;
        private int ActiveReportsPane = 0;

        SqlMenuItemsRepository menuItemsRepository;
        SqlOrderRepository orderRepository;
        SqlWaiterRepository waiterRepository;
        SqlStatisticsRepository statisticsRepository;

        public MainForm()
        {
            InitializeComponent();

            menuItemsRepository = new SqlMenuItemsRepository(connectionString);
            orderRepository = new SqlOrderRepository(connectionString);
            waiterRepository = new SqlWaiterRepository(connectionString);
            statisticsRepository = new SqlStatisticsRepository(connectionString);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Waiter_Click(object sender, EventArgs e)
        {
            MainPanel.Hide();
            PropertyChangePanel.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PropertiesDict = new[] {
                HireWaiterPanel,
                FireWaiterPanel,
                AddMenuItemPanel,
                RemoveMenuItemPanel,
                AddIngredientPanel,
                RestockIngredientPanel
            };

            ReportsDict = new[] {
                DailySalesPanel,
                MostOrderedFoodPanel,
                EotMPanel,
                CustSatPanel
            };
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PropertiesDict[ActivePane].Hide();
            PropertiesDict[PropertiesList.SelectedIndex].BringToFront();
            PropertiesDict[PropertiesList.SelectedIndex].Show();
            ActivePane = PropertiesList.SelectedIndex;
        }

        private void PropertiesReturnButton_Click(object sender, EventArgs e)
        {
            MainPanel.Show();
            PropertyChangePanel.Hide();
        }

        private void HireWaiterSubmitButton_Click(object sender, EventArgs e)
        {
            string Name = HireWaiterNameInput.Text;
            decimal Wage = decimal.Parse(HireWaiterWageInput.Text);

            string FirstName = Name.Substring(0, Name.IndexOf(' '));
            string LastName = Name.Substring(Name.IndexOf(' ') + 1);

            waiterRepository.AddWaiter(FirstName, LastName, Wage);

            FireWaiterList.Items.Clear();
            FireWaiterListLoad(null, null);
        }

        private void FireSelectedWaiterButton_Click(object sender, EventArgs e)
        {
            string Name = FireWaiterList.SelectedItem.ToString();
            string FirstName = Name.Substring(0, Name.IndexOf(' '));
            string LastName = Name.Substring(Name.IndexOf(' ') + 1);

            waiterRepository.FireWaiter(FirstName, LastName);

            FireWaiterList.Items.Clear();
            FireWaiterListLoad(null, null);
        }

        private void AddMenuItemButton_Click(object sender, EventArgs e)
        {
            // TODO test.
            string Name = AddMenuItemName.Text;
            decimal Price = decimal.Parse(AddMenuItemPrice.Text);
            string Description = AddMenuItemDescription.Text;

            menuItemsRepository.AddMenuItem(Name, Description, Price, null);

            
            RemoveMenuItemListLoad(null, null);
        }

        private void RemoveSelectedItemButton_Click(object sender, EventArgs e)
        {
            string RemovedMenuItem = RemoveMenuItemList.SelectedItem.ToString();

            menuItemsRepository.RemoveMenuItem(RemovedMenuItem);
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            string Name = AddIngredientName.Text;
            string Amount = AddIngredientAmount.Text;
            string Units = AddIngredientUnits.Text;

            // TODO Fill.
        }

        private void RestockIngredientButton_Click(object sender, EventArgs e)
        {
            string NewAmount = RestockIngredientAmount.Text;

            // TODO Fill.
        }

        private void FireWaiterListLoad(object sender, EventArgs e)
        {
            // TODO test.
            foreach (Waiter waiter in waiterRepository.FetchAllWaiters())
            {
                FireWaiterList.Items.Add(waiter.FirstName + " " + waiter.LastName);
            }
        }

        private void RemoveMenuItemListLoad(object sender, EventArgs e)
        {
            // TODO test.
            foreach (DatabaseData.Models.MenuItem item in menuItemsRepository.FetchActiveMenuItems())
            {
                RemoveMenuItemList.Items.Add(item.Name);
            }
        }

        private void RestockIngredientListLoad(object sender, EventArgs e)
        {
            // TODO SQL query to populate list.
        }

        // ------------------- REPORTS

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            MainPanel.Hide();
            ReportPanel.Show();
        }

        private void ReportsReturnButton_Click(object sender, EventArgs e)
        {
            MainPanel.Show();
            ReportPanel.Hide();
        }

        private void ReportQueriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportsDict[ActiveReportsPane].Hide();
            ReportsDict[ReportQueriesList.SelectedIndex].BringToFront();
            ReportsDict[ReportQueriesList.SelectedIndex].Show();
            ActiveReportsPane = ReportQueriesList.SelectedIndex;
        }

        private void MostOrderedFoodSubmit_Click(object sender, EventArgs e)
        {
            // TODO Most Ordered Food Query.

            Console.WriteLine(2);
        }

        private void DailySalesSubmit_Click(object sender, EventArgs e)
        {
            string dateString = DailySalesInput.Text;
            DateTimeOffset date = new DateTimeOffset(DateTime.Parse(dateString + " 8:00:00 AM"));
            // TODO SQL query.
            Console.WriteLine(1);
        }

        private void EotMSubmit_Click(object sender, EventArgs e)
        {
            string monthString = EotMInput.Text;
            // TODO SQL query.
            Console.WriteLine(3);
        }

        private void CustSatSubmit_Click(object sender, EventArgs e)
        {
            string startDateString = CustSatStartDateInput.Text;
            string endDateString = CustSatEndDateInput.Text;
            // TODO SQL query.
            Console.WriteLine(4);
        }

        
    }
}