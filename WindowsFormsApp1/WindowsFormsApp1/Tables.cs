﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;


namespace WindowsFormsApp1
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Order o = new Order(7);
            Hide();
            o.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Order o = new Order(1);
            Hide();
            o.Show();

        }

        private void Table2_Click(object sender, EventArgs e)
        {

            Order o = new Order(2);
            Hide();
            o.Show();
        }

        private void Table3_Click(object sender, EventArgs e)
        {

            Order o = new Order(3);
            Hide();
            o.Show();
        }

        private void Table4_Click(object sender, EventArgs e)
        {

            Order o = new Order(4);
            Hide();
            o.Show();
        }

        private void Table6_Click(object sender, EventArgs e)
        {

            Order o = new Order(6);
            Hide();
            o.Show();
        }

        private void Table7_Click(object sender, EventArgs e)
        {

            Order o = new Order(7);
            Hide();
            o.Show();
        }

        private void Table8_Click(object sender, EventArgs e)
        {

            Order o = new Order(8);
            Hide();
            o.Show();
        }

        private void Table9_Click(object sender, EventArgs e)
        {

            Order o = new Order(9);
            this.Hide();
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Orders vw = new View_Orders(1);
            vw.Show();
            Hide();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            View_Orders vw = new View_Orders(2);
            vw.Show();
            Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            View_Orders vw = new View_Orders(3);
            vw.Show();
            Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            View_Orders vw = new View_Orders(4);
            vw.Show();
            Hide();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            View_Orders vw = new View_Orders(5);
            vw.Show();
            Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            View_Orders vw = new View_Orders(6);
            vw.Show();
            Hide();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            View_Orders vw = new View_Orders(7);
            vw.Show();
            Hide();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            View_Orders vw = new View_Orders(8);
            vw.Show();
            Hide();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            View_Orders vw = new View_Orders(9);
            vw.Show();
            Hide();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tables_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
        }
    }
}
