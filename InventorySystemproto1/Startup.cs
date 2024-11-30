using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static InventorySystemproto1.Constants;
using static InventorySystemproto1.Customs;

namespace InventorySystemproto1
{
    public partial class Startup : Form
    {
        Timer timer = new Timer();

        public Startup()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SqlCommand sqlCommand0 = new SqlCommand("SELECT * FROM InventorySystem_inventory", connection);
            SqlCommand sqlCommand1 = new SqlCommand("SELECT * FROM InventorySystem_orderhistory", connection1);

            try
            {
                connection.Open();
                connection1.Open();

                using (SqlDataReader reader = sqlCommand0.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        inventoryList.Add(new InventoryItem(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3), reader.GetInt32(4)));
                    }
                }


                using (SqlDataReader reader = sqlCommand1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orderList.Add(new OrderItem(
                             reader["OrderID"].ToString(),
                             reader.GetString(1),
                             reader.GetString(2),
                             reader.GetString(3),
                             reader.GetInt32(4),
                             reader.GetDateTime(5),
                             reader.GetString(6)));
                    }
                }

                timer.Stop();
                new MainWindow(this).Show();
            }
            catch (Exception a)
            {
                timer.Stop();
                MessageBox.Show(a.Message);
                Application.Exit();
            }
        }
    }
}
