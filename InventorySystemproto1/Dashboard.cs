using System.Linq;
using System;
using System.Windows.Forms;
using static InventorySystemproto1.Constants;
using System.Collections.Generic;
using static InventorySystemproto1.Customs;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;
namespace InventorySystemproto1
{
    public partial class Dashboard : Form
    {
        BindingSource bindingSource = new BindingSource();

        public Dashboard()
        {
            InitializeComponent();
            BindData();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //overviews            
            int totalProducts = inventoryList.Where(item => !string.IsNullOrEmpty(item.Model)).
                                Select(item => item.Model).
                                Distinct().Count();

            int totalOrders = 228; 
            int totalStocks = inventoryList.Sum(item => item.Stock);
            int outOfStocks = inventoryList.Count(item => item.Category.All(category => item.Stock == 0));

            button1.Text = "Total Products: " + totalProducts;
            button2.Text = "Orders: " + totalOrders;
            button3.Text = "Total Stock: " + totalStocks;
            button4.Text = "Out of Stock:" + outOfStocks;
 

            //chart          
            this.chart1.Series["Sales in million"].XValueMember = "Month";
            this.chart1.Series["Sales in million"].YValueMembers = "Sales";
            chart1.Titles.Add(DateTime.Now.Year + " Monthly Sales Chart");
            chart1.Series[0].ToolTip = "#VALX, #VAL";
            
        }


        void BindData()
        {
            if (salesList.Count > 0)
            {
                foreach (SalesChart item in salesList)
                {
                    bindingSource.Add(item);
                }

                chart1.DataSource = bindingSource;
            }     
        }

    }
}
