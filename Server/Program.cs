using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(IPAddress.Any, 20001);
            server.Start();
            
            while (true)
            {
                Socket client = server.AcceptSocket();
                NetworkStream stream = new NetworkStream(client);
                StreamReader reader = new StreamReader(stream);
                StreamWriter writer = new StreamWriter(stream);
                writer.AutoFlush = true;

                writer.WriteLine("send to client");
                Console.WriteLine(reader.ReadLine());
            }
           

        }
    }
}
