using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];

            // 접속할 서버의 IP 주소
            // 127.0.0.1은 내부적으로 약속된 IP 주소로, 자기 자신을 가리킴
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            // 접속할 서버를 지정
            IPEndPoint ipep = new IPEndPoint(ipAddress, 3317);

            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Console.WriteLine("서버에 접속합니다.");

            server.Connect(ipep);

            Console.WriteLine("서버에 접속하였습니다");

            data = Encoding.Default.GetBytes("클라이언트에서 보내는 메시지입니다.");

            server.Send(data);

            Console.WriteLine("서버에 데이터를 전송하였습니다.");

            server.Close();
        }
    }
}
