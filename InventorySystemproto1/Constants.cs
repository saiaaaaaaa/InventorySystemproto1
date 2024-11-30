using System.Collections.Generic;
using System.Data.SqlClient;
using static InventorySystemproto1.Customs;

namespace InventorySystemproto1
{
    public class Constants
    {
        //NOTE: localhost sql server
        //NOTE: connect to localdb using server explorer 
        static string hostname1 = "Data Source=Saga\\SQLEXPRESS;"; //NOTE: change to your local host name
        static string database1 = "Initial Catalog=inventoryDB;;"; //NOTE: change to your local db name
        public static SqlConnection connection1 = new SqlConnection(hostname1 + database1 + "Integrated Security=True;");


        //NOTE: online sql server (for testing)
        static string hostname = "Data Source=sql.bsite.net\\MSSQL2016;";
        static string database = "Initial Catalog=saiaa_SampleDB;";
        static string username = "User ID=saiaa_SampleDB;";
        static string password = "Password=DBSamplePW;";
        public static SqlConnection connection = new SqlConnection(hostname + database + username + password);
        
        public static List<InventoryItem> inventoryList = new List<InventoryItem>();
        public static List<OrderItem> orderList = new List<OrderItem>();
    }
}
