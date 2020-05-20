using System;
using System.Data.SqlClient;

namespace DapperWithSOLID.Controller
{
    public class CreatConnectionDb<T>
    {
        private const string strConn = "Data Source=localhost;Initial Catalog=alif;Integrated Security=True;";
        protected SqlConnection connection = null;

        public CreatConnectionDb()
        {
            connection = new SqlConnection(strConn);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        
    }
}
