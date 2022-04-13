using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Preschool_Client.Connection;

namespace Preschool_Client
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Thread thread_TCP = new Thread(TCPConnection);
            thread_TCP.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Manager());
        }
    }
}
