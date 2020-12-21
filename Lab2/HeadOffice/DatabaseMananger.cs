using Lab2ComServerIntefaces;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HeadOffice
{
    public class DatabaseMananger: IDatabaseManager
    {
        private readonly string ConnectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=HeadOfficeDB;Integrated Security=SSPI;";

        public DataTable GetTable(string query)
        {
            var conection = new SqlConnection(ConnectionString);
            conection.Open();
            var command = new SqlCommand(query, conection);

            var r = command.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(r);

            conection.Close();
            return dataTable;
        }

        //public void SaveTable(string query)
        //{
        //    var conection = new SqlConnection(ConnectionString);
        //    conection.Open();
        //    var command = new SqlCommand(query, conection);

        //    var r = command.ExecuteReader();
        //    var dataTable = new DataTable();
        //    dataTable.Load(r);

        //    conection.Close();
        //    return dataTable;
        //}

        public List<string> GetTables()
        {
            var resutlList = new List<string>();
            var conection = new SqlConnection(ConnectionString);
            conection.Open();
            var command = new SqlCommand("SELECT * FROM sys.tables", conection);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                resutlList.Add(r.GetString(0));
            }
            conection.Close();
            return resutlList;
        }
    }
}
