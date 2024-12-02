using System;
using System.Linq;
using System.Windows.Forms;
using static InventorySystemproto1.Constants;
using static InventorySystemproto1.Customs;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;



namespace InventorySystemproto1
{
    public partial class OrderHistory : Form
    {
        BindingSource bindingSource = new BindingSource();
        bool incomingBtnClicked, deliveredBtnClicked, 
            cancelledBtnClicked, allOrdersBtnClicked = false;

        public OrderHistory()
        {
            InitializeComponent();

            BindData();

            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker2.CustomFormat = "MM/dd/yyyy";

        }

        private void btn_allOrders_Click(object sender, EventArgs e)
        { 
            bindingSource.Clear();
            BindData();

            allOrdersBtnClicked = true;
            incomingBtnClicked = false;
            deliveredBtnClicked = false;
            cancelledBtnClicked = false;

            
        }

        private void btn_incoming_Click(object sender, EventArgs e)
        { 
            var incomingList = orderList.Where(item => item.OrderStatus == "Incoming").ToList();
            FilterTable(incomingList);

            incomingBtnClicked = true;
            allOrdersBtnClicked = false;
            deliveredBtnClicked = false;
            cancelledBtnClicked = false;
        }

        private void btn_delivered_Click(object sender, EventArgs e)
        {
            var deliveredList = orderList.Where(item => item.OrderStatus == "Delivered").ToList();
            FilterTable(deliveredList);

            deliveredBtnClicked = true;
            allOrdersBtnClicked = false;
            incomingBtnClicked = false;
            cancelledBtnClicked = false;
        }

        private void btn_cancelled_Click(object sender, EventArgs e)
        {
            var cancelledList = orderList.Where(item => item.OrderStatus == "Cancelled").ToList();
            FilterTable(cancelledList);

            cancelledBtnClicked = true;
            allOrdersBtnClicked = false;
            incomingBtnClicked = false;
            deliveredBtnClicked = false;
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            FilterByButton();
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            FilterByButton();
        }

        void FilterByButton() 
        {
            if (incomingBtnClicked == true)
            {
                FilterByDate("Incoming");
            }
            else if (deliveredBtnClicked == true)
            {
                FilterByDate("Delivered");
            }
            else if (cancelledBtnClicked == true)
            {
                FilterByDate("Cancelled");
            }
            else if (allOrdersBtnClicked == true)
            {
                FilterByDate();
            }
        }

        void BindData()
        {
            if (orderList.Count > 0)
            {
                foreach (OrderItem item in orderList)
                {
                    bindingSource.Add(item);
                }

                dataGridView1.DataSource = bindingSource;
            }
            
        }


        void FilterTable(IEnumerable i)
        {
            foreach (var item in i)
            {
                bindingSource.Add(item);
            }

            dataGridView1.DataSource = i;

            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("No results found.");
            }
        }

        void FilterByDate(string activeButton)
        {
            bindingSource.Clear();
            var dateAdded = orderList.Where(item => item.DateAdded >= dateTimePicker1.Value 
                                                 && item.DateAdded <= dateTimePicker2.Value
                                                 && item.OrderStatus == activeButton).ToList();

            FilterTable(dateAdded);

            if (dateTimePicker1.Value > dateTimePicker2.Value || dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("Please select a valid date range.");
            }
        }

        void FilterByDate()
        {
            bindingSource.Clear();
            var dateAdded = orderList.Where(item => item.DateAdded >= dateTimePicker1.Value
                                                 && item.DateAdded <= dateTimePicker2.Value).ToList();

            FilterTable(dateAdded);

            if (dateTimePicker1.Value > dateTimePicker2.Value || dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("Please select a valid date range.");
            }
        }
    }
}
