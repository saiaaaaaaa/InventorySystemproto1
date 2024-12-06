using System;
using System.Linq;
using System.Windows.Forms;
using static InventorySystemproto1.Constants;
using static InventorySystemproto1.Customs;
using System.Collections;
using System.Drawing;



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

            dataGridView1.Columns.Add("checkboxDelivered", "Select");

        }

        private void btn_allOrders_Click(object sender, EventArgs e)
        { 
            bindingSource.Clear();
            BindData();

           /* btn_allOrders.BackColor = System.Drawing.Color.Green;
            btn_incoming.BackColor = SystemColors.Control;
            btn_cancelled.BackColor = SystemColors.Control;
            btn_delivered.BackColor = SystemColors.Control;
           */

            allOrdersBtnClicked = true;
            incomingBtnClicked = false;
            deliveredBtnClicked = false;
            cancelledBtnClicked = false;

            
        }

        private void btn_incoming_Click(object sender, EventArgs e)
        { 
            var incomingList = orderList.Where(item => item.OrderStatus == "Incoming").ToList();
            FillTableWith(incomingList);

          /*  btn_incoming.BackColor = System.Drawing.Color.Green;
            btn_allOrders.BackColor = SystemColors.Control;
            btn_cancelled.BackColor = SystemColors.Control;
            btn_delivered.BackColor = SystemColors.Control;
*/
            incomingBtnClicked = true;
            allOrdersBtnClicked = false;
            deliveredBtnClicked = false;
            cancelledBtnClicked = false;
        }

        private void btn_delivered_Click(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Add("checkboxDelivered", "Select");
            var deliveredList = orderList.Where(item => item.OrderStatus == "Delivered").ToList();
            FillTableWith(deliveredList);

            //change button color when clicked
          /*  btn_delivered.BackColor = System.Drawing.Color.Green;
            btn_allOrders.BackColor = SystemColors.Control;
            btn_incoming.BackColor = SystemColors.Control;
            btn_cancelled.BackColor = SystemColors.Control;
            
            */
            deliveredBtnClicked = true;
            allOrdersBtnClicked = false;
            incomingBtnClicked = false;
            cancelledBtnClicked = false;
        }

        private void btn_cancelled_Click(object sender, EventArgs e)
        {
            var cancelledList = orderList.Where(item => item.OrderStatus == "Cancelled").ToList();
            FillTableWith(cancelledList);

          /*  btn_cancelled.BackColor = System.Drawing.Color.Green;
            btn_allOrders.BackColor = SystemColors.Control;
            btn_incoming.BackColor = SystemColors.Control; 
            btn_delivered.BackColor = SystemColors.Control;
            */

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

    /*    void FilterByButton(int activeButton, string orderStatus)
        {
            if (activeButton == 0)
            {
                //all orders
                FilterByDate();
            }
            else if (activeButton == 1)
            {
                //incoming
                FilterByDate(orderStatus);
            }
            else if (activeButton == 2)
            {
                //delivered
                FilterByDate(orderStatus);
            }
            else if (activeButton == 3)
            {
                //cancelled
                FilterByDate(orderStatus);
            }
            else 
            { 
                
            }
        }
    */


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

 

        void FillTableWith(IEnumerable status)
        {
            foreach (var item in status)
            {
                bindingSource.Add(item);
            }

            dataGridView1.DataSource = status;
            

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

            FillTableWith(dateAdded);

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

            FillTableWith(dateAdded);

            if (dateTimePicker1.Value > dateTimePicker2.Value || dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("Please select a valid date range.");
            }
        }
    }
}
