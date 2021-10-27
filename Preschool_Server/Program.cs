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
using static Preschool_Server.XMLHelper;

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
                        XElement result = null;
                        if (message.Name == "GET")
                        {
                            result = QueryGet(message);
                        }
                        else if (message.Name == "UPDATE")
                        {
                            result = QueryUpdate(message);
                        }
                        else if (message.Name == "DELETE")
                        {

                        }
                        else if (message.Name == "INSERT")
                        {

                        }
                        else
                        {
                            result = ErrorMessage();
                        }
                        TCPServerSender(result, tcpClient);
                    }
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
        static public void TCPServerSender(XElement message, TcpClient client)
        {
            StreamWriter sWriter = new StreamWriter(client.GetStream());
            Console.WriteLine("Sent message\n" + message.ToString() + "\n");
            sWriter.WriteLine(StringToHexString(message.ToString()));
            sWriter.Flush();
        }
    }
}
