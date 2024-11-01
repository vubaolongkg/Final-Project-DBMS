using System.Data;
using System.Data.SqlClient;


namespace DBMSQuanLyBanHang
{
    internal class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuanLyBanHang;User ID=baolong;Password=Baolong@12345;Connect Timeout=30;Encrypt=True;Integrated Security=True;TrustServerCertificate=True");

        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }


        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }

    }

}
