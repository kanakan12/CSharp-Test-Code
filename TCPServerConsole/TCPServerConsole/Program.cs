using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket server = null;
            Socket client = null;
            byte[] data = new byte[1024]; // 데이터를 수신할 byte 배열

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 3317);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(ipep);
            server.Listen(10); // 처리 대기큐 최대 크기

            Console.WriteLine("서버를 시작합니다. \n클라이언트의 접속을 대기합니다.");

            client = server.Accept(); // 클라이언트 접속 대기

            Console.WriteLine("클라이언트가 접속하였습니다.");

            // 클라이언트로부터 데이터 수신
            client.Receive(data);

            Console.WriteLine("클라이언트로부터 데이터를 수진하였습니다 \n메시지: " + Encoding.Default.GetString(data));

            client.Close();
            server.Close();
        }
    }
}
