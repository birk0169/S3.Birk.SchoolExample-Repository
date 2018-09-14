using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birk.SchoolExample.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 9999;
            Server server = new Server(port);
            server.Start();
        }
    }
}
