using DatabaseData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClockInOut : Form
    {
        private readonly string connectionString = "Server=mssql.cs.ksu.edu;Database=santiagoscavone;UID=santiagoscavone;Password=Sqlpassword1!";

        public ClockInOut()
        {
            InitializeComponent();
        }

        private void ClockInSubmit_Click(object sender, EventArgs e)
        {
            string name = ClockInOutInput.Text;
            string firstName;
            string lastName;
            try
            {
                firstName = name.Substring(0, name.IndexOf(' '));
                lastName = name.Substring(name.IndexOf(' ') + 1);
            } catch(ArgumentOutOfRangeException aoore)
            {
                return;
            }
            
            try
            {
                SqlWaiterRepository sql = new SqlWaiterRepository(connectionString);
                sql.OpenShift(firstName, lastName);
            } catch(Exception ex)
            {
                ClockInOutResultsLabel.Text = name + " is already clocked in.";
                return;
            }

            ClockInOutResultsLabel.Text = name + " clocked in!";
        }

        private void ClockOutSubmit_Click(object sender, EventArgs e)
        {
            string name = ClockInOutInput.Text;

            string firstName;
            string lastName;
            try
            {
                firstName = name.Substring(0, name.IndexOf(' '));
                lastName = name.Substring(name.IndexOf(' ') + 1);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                return;
            }

            try
            {
                SqlWaiterRepository sql = new SqlWaiterRepository(connectionString);
                sql.CloseShift(firstName, lastName);
            }
            catch (Exception ex)
            {
                ClockInOutResultsLabel.Text = name + " is already clocked out.";
                return;
            }

            ClockInOutResultsLabel.Text = name + " clocked out!";
        }
    }
}
