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
        List<DatabaseData.Models.MenuItem> it =new List<DatabaseData.Models.MenuItem>() ;
        List<DatabaseData.Models.Waiter> mw = new List<DatabaseData.Models.Waiter>();
        int tableno;
        public Order(int no)
        {
            InitializeComponent();
            tableno = no;
            string connectionString = "Server=mssql.cs.ksu.edu;Database=santiagoscavone;UID=santiagoscavone;Pwd=Sqlpassword1!";
            SqlMenuItemsRepository sql = new SqlMenuItemsRepository(connectionString);
            foreach (DatabaseData.Models.MenuItem i in sql.FetchActiveMenuItems())
            {
                
                    if (i != null){

                        it.Add(i);
                        comboBox1.Items.Add(i.Name);
                    }
                    
                
            }
            SqlWaiterRepository sql2 = new SqlWaiterRepository(connectionString);

            foreach (DatabaseData.Models.Waiter w in sql2.FetchAllCurrentylWorkingWaiters())
            {
                if (!comboBox3.Items.Contains(w.FirstName + " " + w.LastName))
                {
                    mw.Add(w);
                    comboBox3.Items.Add(w.FirstName + " " + w.LastName);

                }
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        DatabaseData.Models.MenuItem m;
        private void Combo1_clicked(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)

                foreach (DatabaseData.Models.MenuItem mm in it)
                {
                    if (mm.Name == (string)comboBox1.SelectedItem)
                    {
                        m = mm;
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
            
            if (comboBox1.SelectedItem != null)
                foreach (DatabaseData.Models.MenuItem mm in it)
                {
                    if (mm.Name == (string)comboBox1.SelectedItem)
                    {
                        m = mm;
                    }

                }
        }

       

        private void Done_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=santiagoscavone;UID=santiagoscavone;Pwd=Sqlpassword1!";
            SqlOrderRepository sqlo = new SqlOrderRepository(connectionString);
            if (selectedWaiter != null)
            {
                Console.WriteLine("5555555");
                sqlo.AddOrder(selectedWaiter.FirstName, selectedWaiter.LastName, tableno);
            }

        }
        List<DatabaseData.Models.Ingredient> removedingredi = new List<DatabaseData.Models.Ingredient>();

        /// <summary>
        /// when we wanna delete ingreients from the ingredients list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                foreach (DatabaseData.Models.Ingredient ig in ingredi)
                {
                    if (comboBox2.SelectedItem != null)
                    {
                        if (ig.Name == comboBox2.SelectedItem.ToString())
                        {
                            removedingredi.Add(ig);
                            comboBox2.Items.Remove(comboBox2.SelectedItem);
                        }


                    }
                }

            }

        }
        List<DatabaseData.Models.Ingredient> ingredi =new List<DatabaseData.Models.Ingredient>();
        private void ComboBox2_MouseEnter(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedItem != null)
            {
                foreach (DatabaseData.Models.Ingredient ing in m.Ingredients)
                    {
                        if (!comboBox2.Items.Contains(ing.Name))
                        {
                            comboBox2.Items.Add(ing.Name);
                            ingredi.Add(ing);
                        }
                    }
            }
        }
        DatabaseData.Models.Waiter selectedWaiter;

        private void Waiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                foreach (DatabaseData.Models.Waiter ww in mw)
                {
                    if ((ww.FirstName + " " + ww.LastName) == (string)comboBox3.SelectedItem)
                    {
                        selectedWaiter = ww;
                    }

                }

            }
        }

        private void ComboBox3_MouseEnter(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex >= 0)
            {
                foreach (DatabaseData.Models.Waiter ww in mw)
                {
                    if ((ww.FirstName + " " + ww.LastName) == (string)comboBox3.SelectedItem)
                    {
                        selectedWaiter = ww;
                        Console.WriteLine(comboBox3.SelectedItem);

                    }

                }

            }
        }

        private void ComboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                foreach (DatabaseData.Models.Waiter ww in mw)
                {
                    if ((ww.FirstName + " " + ww.LastName) == (string)comboBox3.SelectedItem)
                    {
                        selectedWaiter = ww;
                        Console.WriteLine(comboBox3.SelectedItem);
                    }

                }

            }
        }

        private void ComboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                foreach (DatabaseData.Models.MenuItem mm in it)
                {
                    if (mm.Name == (string)comboBox1.SelectedItem)
                    {
                        m = mm;
                    }

                }
        }
        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void ComboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                foreach (DatabaseData.Models.Ingredient ig in ingredi)
                {
                    if (comboBox2.SelectedItem!=null) {
                        if (ig.Name == comboBox2.SelectedItem.ToString())
                        {
                            removedingredi.Add(ig);
                            comboBox2.Items.Remove(comboBox2.SelectedItem);
                        }


                    }
                }
                
            }
        }
    }

}
