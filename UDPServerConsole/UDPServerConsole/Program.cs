using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UDPServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket server = null;
            byte[] data = new byte[1024];

            IPEndPoint serverIpep = new IPEndPoint(IPAddress.Any, 3317);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPEndPoint clientIpep = new IPEndPoint(IPAddress.Any, 0);
            EndPoint client = (EndPoint)clientIpep;

            server.Bind(serverIpep);

            Console.WriteLine("서버를 시작합니다.\n");

            server.ReceiveFrom(data, ref client);

            Console.WriteLine("클라이언트로부터 데이터를 수신하였습니다.\n메세지:" + Encoding.Default.GetString(data));

            server.Close();
        }
    }
}
