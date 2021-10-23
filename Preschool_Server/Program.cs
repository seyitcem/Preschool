using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static Preschool_Server.Transform;
using static Preschool_Server.DBManager;

namespace Preschool_Server
{
    class Program
    {
        static private TcpListener tcpListener = new TcpListener(IPAddress.Any, 1234);
        static private List<TcpClient> tcpClientsList = new List<TcpClient>();
        static void Main(string[] args)
        {
            tcpListener.Start();
            Console.WriteLine("Server is started." + "\n");

            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                tcpClientsList.Add(tcpClient);
                Thread thread_TCP = new Thread(TCPServerListener);
                thread_TCP.Start(tcpClient);
            }

        }
        static public void TCPServerListener(object obj)
        {
            TcpClient tcpClient = (TcpClient)obj;
            StreamReader reader = new StreamReader(tcpClient.GetStream());

            Console.WriteLine("A client is connected.");
            Console.WriteLine("Active number of connection is: " + tcpClientsList.Count + "\n");

            while (true)
            {
                try
                {
                    string encoded_message = reader.ReadLine();
                    XElement message;
                    if (encoded_message == null)
                    {
                        throw new IOException();
                    }
                    else
                    {
                        message = XElement.Parse(HexStringToString(encoded_message));
                        if (message.Name == "GET")
                        {
                            QueryGet(message);
                        }
                        else if (message.Name == "UPDATE")
                        {

                        }
                        else if (message.Name == "DELETE")
                        {

                        }
                        else if (message.Name == "INSERT")
                        {

                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                    /*
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        string query = "Select * from Products";
                        sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlDataReader = sqlCommand.ExecuteReader();
                        XElement resultNode = new XElement("Result");
                        if (sqlDataReader.HasRows)
                        {
                            while (sqlDataReader.Read())
                            {
                                XElement row = new XElement("Product");
                                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                                {
                                    row.Add(new XElement(sqlDataReader.GetName(i), sqlDataReader.GetValue(i)));
                                }
                                resultNode.Add(row);
                            }
                            Console.WriteLine(resultNode.ToString());
                        }
                    }
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        string query = "Select * from Products";
                        DataSet dataSet = new DataSet();
                        sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                        sqlDataAdapter.Fill(dataSet);
                        dataSet.DataSetName = "Results";
                        dataSet.Tables[0].TableName = "Product";
                        using (var writer = new StringWriter())
                        {
                            dataSet.WriteXml(writer);
                            Console.WriteLine(writer.ToString());
                        }
                    }
                    */
                }
                catch (IOException)
                {
                    Console.WriteLine("A connection is terminated.");
                    tcpClientsList.RemoveAt(tcpClientsList.IndexOf(tcpClient));
                    Console.WriteLine("Active number of connection is: " + tcpClientsList.Count + "\n");
                    tcpClient.Close();
                    break;
                }
            }
        }
        static public void TCPServerSender(string message, TcpClient client)
        {
            StreamWriter sWriter = new StreamWriter(client.GetStream());
            Console.WriteLine("Sent message: " + message + "\n");
            sWriter.WriteLine(message);
            sWriter.Flush();
        }
    }
}
