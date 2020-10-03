using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UDPClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];

            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");

            IPEndPoint ipep = new IPEndPoint(ipAddress, 3317);

            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            data = Encoding.Default.GetBytes("클라이언트에서 보내는 메시지입니다.");

            server.SendTo(data, ipep);

            Console.WriteLine("서버에 데이터를 전송하였습니다.");

            server.Close();
        }
    }
}
