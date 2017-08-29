using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketsAtmar
{
    //Client
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("client");
            TcpClient server = new TcpClient("localhost", 20001);
            string serverMessage = "";
            NetworkStream stream = server.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);
            writer.AutoFlush = true;
            Console.WriteLine("Message:");
            serverMessage =reader.ReadLine();
            Console.WriteLine("Server says: " + serverMessage);
            writer.WriteLine(Console.ReadLine());

        }
    }
}
