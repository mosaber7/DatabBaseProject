using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DatabaseData;
using DatabaseData.Models;
using DatabaseData.Models.Report;

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
                EmployeeShiftsPanel
            };

            FireWaiterListLoad();
            RemoveMenuItemListLoad();
            RestockIngredientListLoad();

            DailySalesOutputTable.ColumnCount = 3;
            DailySalesOutputTable.Columns[0].Name = "Product Name";
            DailySalesOutputTable.Columns[1].Name = "Total Sales";
            DailySalesOutputTable.Columns[2].Name = "Times Ordered";

            EotMOutputTable.ColumnCount = 6;
            EotMOutputTable.Columns[0].Name = "First Name";
            EotMOutputTable.Columns[1].Name = "Last Name";
            EotMOutputTable.Columns[2].Name = "Hours Worked";
            EotMOutputTable.Columns[3].Name = "Orders Served";
            EotMOutputTable.Columns[4].Name = "Tips Earned";
            EotMOutputTable.Columns[5].Name = "Average Tip per Order";

            MostOrderedFoodOutputTable.ColumnCount = 3;
            MostOrderedFoodOutputTable.Columns[0].Name = "Name";
            MostOrderedFoodOutputTable.Columns[1].Name = "Amount Sold";
            MostOrderedFoodOutputTable.Columns[2].Name = "Total Earnings";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PropertiesDict[ActivePane].Hide();
                PropertiesDict[PropertiesList.SelectedIndex].BringToFront();
                PropertiesDict[PropertiesList.SelectedIndex].Show();
                ActivePane = PropertiesList.SelectedIndex;
            }
            catch { }
        }

        private void PropertiesReturnButton_Click(object sender, EventArgs e)
        {
            MainPanel.Show();
            PropertyChangePanel.Hide();
        }

        // ------------------- PROPERTY QUERY FUNCTIONS

        // Complete. 
        private void HireWaiterSubmitButton_Click(object sender, EventArgs e)
        {
            string Name = HireWaiterNameInput.Text;
            string FirstName;
            string LastName;
            decimal Wage;
            try
            {
                Wage = decimal.Parse(HireWaiterWageInput.Text);

                FirstName = Name.Substring(0, Name.IndexOf(' '));
                LastName = Name.Substring(Name.IndexOf(' ') + 1);
            } catch(Exception ex)
            {
                return;
            }
            
            try
            {
                waiterRepository.AddWaiter(FirstName, LastName, Wage);
            } catch(Exception ex)
            {
                return;
            }
            

            FireWaiterList.Items.Clear();
            FireWaiterListLoad();
        }

        // Complete.
        private void FireSelectedWaiterButton_Click(object sender, EventArgs e)
        {
            string Name = FireWaiterList.SelectedItem.ToString();
            string FirstName;
            string LastName;
            try
            {
                FirstName = Name.Substring(0, Name.IndexOf(' '));
                LastName = Name.Substring(Name.IndexOf(' ') + 1);
            } catch(Exception ex)
            {
                return;
            }

            try
            {
                waiterRepository.FireWaiter(FirstName, LastName);
            } catch(Exception ex)
            {
                return;
            }
            

            FireWaiterList.Items.Clear();
            FireWaiterListLoad();
        }

        // Complete.
        private void AddMenuItemButton_Click(object sender, EventArgs e)
        {
            string Name;
            decimal Price;
            string Description;
            List<Ingredient> Ingredients;

            try
            {
                Name = AddMenuItemName.Text;
                Price = decimal.Parse(AddMenuItemPrice.Text);
                Description = AddMenuItemDescription.Text;
                Ingredients = new List<Ingredient>();

                foreach(string line in AddMenuItemIngredients.Text.Split('\n'))
                {
                    string IngName = line.Substring(0, line.IndexOf(',')).Trim();
                    decimal IngAmt = decimal.Parse(line.Substring(line.IndexOf(',') + 1).Trim());
                    Ingredients.Add(new Ingredient(IngName, IngAmt));
                }
            } catch(Exception ex)
            {
                return;
            }

            try
            {
                menuItemsRepository.AddMenuItem(Name, Description, Price, Ingredients);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            

            RemoveMenuItemList.Items.Clear();
            RemoveMenuItemListLoad();
        }

        // Complete.
        private void RemoveSelectedItemButton_Click(object sender, EventArgs e)
        {
            string RemovedMenuItem = RemoveMenuItemList.SelectedItem.ToString();

            try
            {
                menuItemsRepository.RemoveMenuItem(RemovedMenuItem);
            } catch(Exception ex)
            {
                return;
            }
            
            RemoveMenuItemList.Items.Clear();
            RemoveMenuItemListLoad();
        }

        // Complete.
        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            string Name;
            decimal Amount;
            string Units;
            decimal Cost;
            try
            {
                Name = AddIngredientName.Text;
                Amount = decimal.Parse(AddIngredientAmount.Text);
                Units = AddIngredientUnits.Text;
                Cost = decimal.Parse(AddIngredientCost.Text);
            } catch(Exception ex)
            {
                return;
            }

            try
            {
                orderRepository.AddIngredient(Name, Amount, Units, Cost);
            } catch(Exception ex)
            {
                return;
            }

            RestockIngredientsList.Items.Clear();
            RestockIngredientListLoad();
        }

        // Complete.
        private void RestockIngredientButton_Click(object sender, EventArgs e)
        {
            string Name;
            decimal NewAmount;

            try
            {
                Name = RestockIngredientsList.SelectedItem.ToString();
                Name = Name.Substring(0, Name.IndexOf(','));
                NewAmount = decimal.Parse(RestockIngredientAmount.Text);
            } catch(Exception ex)
            {
                return;
            }

            try
            {
                menuItemsRepository.RestockIngredient(Name, NewAmount);
            } catch(Exception ex)
            {
                return;
            }

            RestockIngredientsList.Items.Clear();
            RestockIngredientListLoad();
        }

        // Complete.
        private void FireWaiterListLoad()
        {
            foreach (Waiter waiter in waiterRepository.FetchAllWaiters())
            {
                FireWaiterList.Items.Add(waiter.FirstName + " " + waiter.LastName);
            }
        }

        // Complete.
        private void RemoveMenuItemListLoad()
        {
            foreach (DatabaseData.Models.MenuItem item in menuItemsRepository.FetchActiveMenuItems())
            {
                RemoveMenuItemList.Items.Add(item.Name);
            }
        }

        // Complete.
        private void RestockIngredientListLoad()
        {
            foreach(IngredientInformation ingredient in menuItemsRepository.FetchAllIngredients())
            {
                RestockIngredientsList.Items.Add(ingredient.Name + ", " + ingredient.Amount + " " + ingredient.Units);
            }
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
            try
            {
                ReportsDict[ActiveReportsPane].Hide();
                ReportsDict[ReportQueriesList.SelectedIndex].BringToFront();
                ReportsDict[ReportQueriesList.SelectedIndex].Show();
                ActiveReportsPane = ReportQueriesList.SelectedIndex;
            }
            catch { }
        }

        // TODO
        private void MostOrderedFoodSubmit_Click(object sender, EventArgs e)
        {
            int Year;
            
            try
            {
                Year = int.Parse(MostOrderedFoodInput.Text);

                List<FoodYearInfo> foods = (List<FoodYearInfo>)statisticsRepository.MostOrderedFoodInYear(Year);

                MostOrderedFoodOutputTable.Rows.Clear();
                foreach(FoodYearInfo food in foods)
                {
                    MostOrderedFoodOutputTable.Rows.Add(food.Name, food.AmountSoldInYear, food.TotalEarnings);
                }
            } catch(Exception ex)
            {

            }
        }

        // Complete.
        private void DailySalesSubmit_Click(object sender, EventArgs e)
        {
            string DateString = DailySalesInput.Text;

            try
            {
                DateTimeOffset date = new DateTimeOffset(DateTime.Parse(DateString + " 8:00:00 AM"));
            
                statisticsRepository.GetDaySales(date);
                List<ItemSale> daysales = (List<ItemSale>)statisticsRepository.GetDaySales(date);

                DailySalesOutputTable.Rows.Clear();
                foreach(ItemSale sale in daysales)
                {
                    DailySalesOutputTable.Rows.Add(sale.Name, sale.TotalSale, sale.AmountSold);
                }
            } catch(Exception ex)
            {
                return;
            }
            
        }

        // Complete.
        private void EotMSubmit_Click(object sender, EventArgs e)
        {
            int Month;
            int Year;

            try
            {
                Month = int.Parse(EotMMonthInput.Text);
                Year = int.Parse(EotMYearInput.Text);

                List<EmployeePerformanceReport> eotm = (List<EmployeePerformanceReport>)statisticsRepository.EmployeesPerformance(Year, Month);

                EotMOutputTable.Rows.Clear();
                foreach(EmployeePerformanceReport report in eotm)
                {
                    EotMOutputTable.Rows.Add(report.FirstName, report.LastName, report.HoursWorked, report.OrdersServed, report.TotalTipEarnings, report.AverageTipPerOrder);
                }
            } catch(Exception ex)
            {
                return;
            }
        }

        private void EmployeeShiftsSubmit_Click(object sender, EventArgs e)
        {
            DateTimeOffset Date;
            // TODO SQL query.

            Date = new DateTimeOffset(DateTime.Parse(EmployeeShiftsStartDateInput.Text + " 8:00:00 AM"));

            Console.WriteLine(statisticsRepository.WaitersWorkOnDate(Date).Count());

            try
            {
                
            } catch(Exception ex)
            {
                return;
            }
            
        }

        // ----------------- CLOCK

        private void ClockButton_Click(object sender, EventArgs e)
        {
            ClockInOut test = new ClockInOut();
            test.Show();
        }
    }
}