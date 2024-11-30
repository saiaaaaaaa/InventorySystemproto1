using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static InventorySystemproto1.Constants;
using static InventorySystemproto1.Customs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Globalization;
using System.Collections;


namespace InventorySystemproto1
{
    public partial class OrderHistory : Form
    {
        BindingSource bindingSource = new BindingSource();

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
        }

        private void btn_incoming_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
            var incomingList = orderList.Where(item => item.OrderStatus == "Incoming").ToList();
            filterTable(incomingList);
        }

        private void btn_delivered_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
            var deliveredList = orderList.Where(item => item.OrderStatus == "Delivered").ToList();
            filterTable(deliveredList);
        }

        private void btn_cancelled_Click(object sender, EventArgs e)
        {
            bindingSource.Clear();
            var cancelledList = orderList.Where(item => item.OrderStatus == "Cancelled").ToList();
            filterTable(cancelledList);
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateRange();
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            DateRange();
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

        void filterTable(IEnumerable i)
        {
            foreach (var item in i)
            {
                bindingSource.Add(item);
            }
            dataGridView1.DataSource = i;
        }

        void DateRange()
        {
            bindingSource.Clear();
            var dateAdded = orderList.Where(item => item.DateAdded >= dateTimePicker1.Value && item.DateAdded <= dateTimePicker2.Value).ToList();
            filterTable(dateAdded);

            if (dateTimePicker1.Value > dateTimePicker2.Value || dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("Please select a valid date range.");
            }
        }
        
    }
}
