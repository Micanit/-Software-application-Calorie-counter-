using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatloss
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-326B4DB; Initial Catalog=Fatloss_db; Integrated Security=True");

        public void OpenConnection()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public List<string> SqlRequest(string sqlRequest)
        {
            List<string> dataListFromRequest = new List<string>();
            SqlCommand command = new SqlCommand(sqlRequest, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                { 
                    object fieldValue = reader.GetSqlValue(0);
                    dataListFromRequest.Add(fieldValue.ToString());
                }
            }
            reader.Close();
            return dataListFromRequest;
        }
    }
}
