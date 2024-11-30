using System.Linq;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static InventorySystemproto1.Constants;


namespace InventorySystemproto1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //entry data from sql
            int totalProducts = inventoryList.Where(item => !string.IsNullOrEmpty(item.Model)).
                                Select(item => item.Model).
                                Distinct().Count();

            int totalOrders = 228; //**
            int totalStocks = inventoryList.Sum(item => item.Stock);
            int outOfStocks = inventoryList.Count(item => item.Category.All(category => item.Stock == 0));

            button1.Text = "Total products:" + totalProducts;
            button2.Text = "Orders: " + totalOrders;
            button3.Text = "Total stocks: " + totalStocks;
            button4.Text = "Out of stocks:" + outOfStocks;
        }


    }
}
