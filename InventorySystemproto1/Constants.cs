using System.Collections.Generic;
using System.Data.SqlClient;
using static InventorySystemproto1.Customs;

namespace InventorySystemproto1
{
    public class Constants
    {
        //NOTE: localhost sql server
        //NOTE: connect to localdb using server explorer 
        //static string hostname = "Data Source=DESKTOP-0P0JELF\\SQLEXPRESS;"; //NOTE: change to your local host name
        //static string database = "Initial Catalog=sampleDB;"; //NOTE: change to your local db name
        //public static SqlConnection connection = new SqlConnection(hostname + database + "Integrated Security=True;");

        //NOTE: online sql server (for testing)
        static string hostname = "Data Source=sql.bsite.net\\MSSQL2016;";
        static string database = "Initial Catalog=sasaia_SampleDB;";
        static string username = "User ID=sasaia_SampleDB;";
        static string password = "Password=samplepw;";
        public static SqlConnection connection = new SqlConnection(hostname + database + username + password);
        
        public static List<InventoryItem> inventoryList = new List<InventoryItem>();
    }
}
