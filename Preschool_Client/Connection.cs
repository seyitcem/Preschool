using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preschool_Client
{
    static class Connection
    {
        static public string message_sent;
        static public string message_received;
        static public bool connection = false;
        static public bool is_connection_broken = false;
        static public bool is_return_answer = false;
        static public bool is_process_continue = false;
        static public Queue<string> UDP_commands = new Queue<string>();
        static public void SendNewMessage(string msg)
        {
            if (is_process_continue)
            {
                while (is_process_continue) ;
            }
            message_sent = msg;
            is_process_continue = true;
            if (is_process_continue)
            {
                while (is_process_continue) ;
            }
        }
        static public void TCPConnection()
        {
            while (true)
            {
                try
                {
                    TcpClient tcpClient = new TcpClient("127.0.0.1", 1234);
                    StreamWriter sWriter = new StreamWriter(tcpClient.GetStream());
                    Console.WriteLine("Connected to the TCP server." + "\n");
                    Thread readThread = new Thread(TCPListener);
                    readThread.Start(tcpClient);
                    connection = true;
                    if (is_connection_broken)
                    {
                        MessageBox.Show("The connection has been restored.");
                        is_connection_broken = false;
                    }
                    while (true)
                    {
                        if (tcpClient.Connected)
                        {
                            if (is_process_continue)
                            {
                                sWriter.WriteLine(message_sent);
                                sWriter.Flush();
                                is_return_answer = false;
                                /*TEMP*/is_process_continue = false;
                                /*TEMP*/break;
                                if (!is_return_answer)
                                {
                                    while (!is_return_answer) ;
                                }
                                Console.WriteLine("Sent message: " + message_sent);
                                Console.WriteLine("Received message: " + message_received + "\n");
                                is_process_continue = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("The connection is broken. Please check the connection.");
                            connection = false;
                            is_connection_broken = true;
                            Thread.Sleep(1000);
                            break;
                        }
                    }

                }
                catch (Exception e)
                {
                    connection = false;
                    MessageBox.Show(e.Message);
                    Thread.Sleep(1000);
                }
            }
        }
        static public void TCPListener(object obj)
        {
            TcpClient tcpClient = (TcpClient)obj;
            StreamReader sReader = new StreamReader(tcpClient.GetStream());
            while (true)
            {
                try
                {
                    message_received = sReader.ReadLine();
                    is_return_answer = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
        }
    }
}
