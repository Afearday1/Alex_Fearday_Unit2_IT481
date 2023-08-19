using Alexander_Fearday_Unit2_IT481;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alex_Fearday_Unit2_IT481
{
    public partial class Form1 : Form
    {
        DB database;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                database = new DB("Server = DESKTOP-4J19U6L\\SQLEXPRESS;" + "Trusted_Connection=true;" + "Database=northwind;" + "User Instance=false;" + "Connection timeout=30");
                MessageBox.Show("Connection information was sent.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer count");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string names = database.getCustomerName();
            MessageBox.Show(names, "Customer Names");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string count = database.getOrderCount();
            MessageBox.Show(count, "Order Count");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string orderid = database.getOrders();
            MessageBox.Show(orderid, "Order ID");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string count = database.getEmployeeCount();
            MessageBox.Show(count, "Employee Count");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string names = database.getEmployeeLastName();
            MessageBox.Show(names, "Employees Last Names");
        }
    }
}
