using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static Preschool_Server.XMLHelper;

namespace Preschool_Server
{
    static class DBManager
    {
        static private string connectionString = "Data Source=SEYIT-PC;Initial Catalog=Preschool;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static private SqlCommand sqlCommand;
        static private SqlDataReader sqlDataReader;
        static public void QueryGet(XElement message)
        {
            List<string> selects = new List<string>();
            List<List<object>> wheres = new List<List<object>>();
            string table_name = null;
            GetQueryTokensFromXML(message,ref table_name,ref selects,ref wheres);
            string query = "SELECT ";
            foreach (string select in selects)
            {
                query += select + ",";
            }
            query = query.TrimEnd(',') + " FROM " + table_name;
            if (wheres.Count != 0)
            {
                query += " WHERE ";
                for (int i = 0; i < wheres.Count; i++)
                {
                    query += wheres[i][0] + " = @" + wheres[i][0];
                    if (i + 1 != wheres.Count)
                    {
                        query += " AND ";
                    }
                }
            }
            Console.WriteLine("Received command: " + query);
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                for (int i = 0; i < wheres.Count; i++)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(wheres[i][0].ToString(), wheres[i][1]));
                }
                sqlDataReader = sqlCommand.ExecuteReader();
                Console.WriteLine(ConvertToXML(sqlDataReader, table_name));
            }
        }
        static public object ConvertTypeByColumnType(string table_name, string column_name, string value)
        {
            object return_val = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string cmd = "Select DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where table_name = @table_name AND column_name = @column_name";
                sqlCommand = new SqlCommand(cmd, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("table_name", table_name));
                sqlCommand.Parameters.Add(new SqlParameter("column_name", column_name));
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    if (sqlDataReader["DATA_TYPE"].ToString() == "varchar")
                    {
                        return_val = value.ToString().Trim();
                    }
                    else if (sqlDataReader["DATA_TYPE"].ToString() == "int")
                    {
                        return_val = Convert.ToInt32(value);
                    }
                    else if (sqlDataReader["DATA_TYPE"].ToString() == "bit")
                    {
                        return_val = value.ToString() == "True" ? true : false;
                    }
                    else if (sqlDataReader["DATA_TYPE"].ToString() == "float")
                    {
                        return_val = Convert.ToDouble(value.Replace('.', ','));
                    }
                    else
                    {
                        Console.WriteLine("Undefined data type.");
                        return_val = value;
                    }
                }
            }
            return return_val;
        }
    }
}
