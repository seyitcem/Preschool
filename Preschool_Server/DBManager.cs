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
        static private string connectionString = "Data Source=DESKTOP-PF4Q263;Initial Catalog=DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static private SqlCommand sqlCommand;
        static private SqlDataReader sqlDataReader;
        static public string QuerySelect(string query)
        {
            Console.WriteLine("Received command: " + query);
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                return ConvertToXML(sqlDataReader, "RESULT").ToString();
            }
        }
        static public string QueryUpdate(string query)
        {
            Console.WriteLine("Received command: " + query);
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                int result = sqlCommand.ExecuteNonQuery();
                if (result == 1)
                {
                    return SuccessfulMessage();
                }
                else
                {
                    return ErrorMessage();
                }
            }
        }
        static public string QueryInsert(string query)
        {
            Console.WriteLine("Received command: " + query);
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                int result = sqlCommand.ExecuteNonQuery();
                if (result == 1)
                {
                    return SuccessfulMessage();
                }
                else
                {
                    return ErrorMessage();
                }
            }
        }
        static public string QueryDelete(string query)
        {
            Console.WriteLine("Received command: " + query);
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                int result = sqlCommand.ExecuteNonQuery();
                if (result == 1)
                {
                    return SuccessfulMessage();
                }
                else
                {
                    return ErrorMessage();
                }
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
        static public List<string> GetCreateTableQueries()
        {
            List<string> queries = new List<string>();
            queries.Add(
              @"CREATE TABLE [dbo].[Employee]
                (
                    [id] INT NOT NULL PRIMARY KEY IDENTITY,
                    [name] NVARCHAR(50) NOT NULL,
                    [surname] NVARCHAR(50) NOT NULL,
                    [TCNo] CHAR(11) NOT NULL,
                    [salary] FLOAT NULL, 
                    [phone_number] NVARCHAR(25) NULL
                )");
            queries.Add(
              @"CREATE TABLE [dbo].[Class]
                (
                    [id] INT NOT NULL PRIMARY KEY IDENTITY,
                    [name] VARCHAR(50) NOT NULL
                )");
            queries.Add(
              @"CREATE TABLE [dbo].[Teacher]
                (
	                [id] INT NOT NULL PRIMARY KEY IDENTITY, 
                    [employee_id] INT NOT NULL, 
                    [full_time_flag] BIT NULL, 
                    [part_time_flag] BIT NULL, 
                    [field] NVARCHAR(50) NULL, 
                    [class_id] INT NULL,
	                CONSTRAINT Teacher_FK_EmpId FOREIGN KEY(employee_id) REFERENCES Employee(id),
	                CONSTRAINT Teacher_FK_ClsId FOREIGN KEY(class_id) REFERENCES Class(id)
                )");
            queries.Add(
              @"CREATE TABLE [dbo].[Student]
                (
	                [id] INT NOT NULL PRIMARY KEY IDENTITY, 
                    [name] NVARCHAR(50) NOT NULL, 
                    [surname] NVARCHAR(50) NOT NULL, 
                    [TCNo] CHAR(11) NOT NULL, 
                    [parent_name] NVARCHAR(50) NOT NULL, 
                    [phone_number] NVARCHAR(50) NOT NULL, 
                    [class_id] INT NULL,
	                CONSTRAINT Student_FK_ClsId FOREIGN KEY(class_id) REFERENCES Class(id)
                )");
            queries.Add(
              @"CREATE TABLE [dbo].[Bill]
                (
	                [id] INT NOT NULL PRIMARY KEY IDENTITY, 
                    [bill_id] NVARCHAR(50) NOT NULL, 
                    [date] DATE NOT NULL, 
                    [amount] FLOAT NOT NULL, 
                    [period] NVARCHAR(50) NOT NULL, 
                    [student_id] INT NOT NULL,
	                CONSTRAINT Bill_FK_StuId FOREIGN KEY(student_id) REFERENCES Student(id)
                )");
            queries.Add(
              @"CREATE TABLE [dbo].[Worker]
                (
	                [id] INT NOT NULL PRIMARY KEY IDENTITY, 
                    [employee_id] INT NOT NULL,
	                CONSTRAINT Worker_FK_EmpId FOREIGN KEY(employee_id) REFERENCES Employee(id)
                )");
            queries.Add(
              @"CREATE TABLE [dbo].[Manager]
                (
	                [id] INT NOT NULL PRIMARY KEY IDENTITY, 
                    [employee_id] INT NOT NULL,
	                CONSTRAINT Manager_FK_EmpId FOREIGN KEY(employee_id) REFERENCES Employee(id)
                )");
            queries.Add(
              @"CREATE TABLE [dbo].[Expense]
                (
	                [id] INT NOT NULL PRIMARY KEY IDENTITY, 
                    [worker_id] INT NOT NULL, 
                    [amount] FLOAT NOT NULL, 
                    [date] DATE NOT NULL,
	                CONSTRAINT Expense_FK_WorkerId FOREIGN KEY(worker_id) REFERENCES Worker(id)
                )");
            queries.Add(
              @"CREATE TABLE [dbo].[HealthInfo]
                (
	                [id] INT NOT NULL PRIMARY KEY IDENTITY, 
                    [student_id] INT NOT NULL, 
                    [period] NVARCHAR(50) NOT NULL, 
                    [height] FLOAT NOT NULL, 
                    [weight] FLOAT NOT NULL,
	                CONSTRAINT HealthInfo_FK_StuId FOREIGN KEY(student_id) REFERENCES Student(id)
                )");
            queries.Add(
              @"CREATE TABLE [dbo].[Activity]
                (
	                [id] INT NOT NULL PRIMARY KEY IDENTITY, 
                    [name] NVARCHAR(50) NOT NULL
                )
                ");
            queries.Add(
              @"CREATE TABLE [dbo].[Performance]
                (
	                [id] INT NOT NULL PRIMARY KEY IDENTITY, 
                    [activity_id] INT NOT NULL, 
                    [student_id] INT NOT NULL, 
                    [date] DATE NOT NULL, 
                    [point] INT NULL,
	                CONSTRAINT Performance_FK_ActivityId FOREIGN KEY(activity_id) REFERENCES Activity(id),
	                CONSTRAINT Performance_FK_StuId FOREIGN KEY(student_id) REFERENCES Student(id)
                )");
            return queries;
        }

        static public void InitializeTables()
        {
            List<string> queries = GetCreateTableQueries();

            for (int i = 0; i < queries.Count; i++)
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        sqlCommand = new SqlCommand(queries[i], sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        string table_name = queries[i].Substring(19);
                        table_name = table_name.Substring(0, table_name.IndexOf(']') + 1);
                        Console.WriteLine(table_name + " table is created.");
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
