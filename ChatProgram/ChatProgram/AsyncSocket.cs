using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatProgram
{
    class AsyncSocket
    {
        private const int BUFFER_SIZE = 1024;

        public const int DEFAULT_PORT_NUM = 3317;

        private Chat mChatWnd = null; // Chat form

        private String mMyIPAddress = ""; // 자신의 IP Address
        private String mCorrespondentIPAddress = ""; // 상대방의 IP Address
        private String mServerIPAddress = ""; // 서버 IP Address
        private String mClientIPAddress = ""; // 클라이언트 IP Address

        private int mServerPortNum = 0; // 서버 port num

        private Socket mServerSocket = null; // 접속 대기용 소켓
        private Socket mClientSocket = null; // 클라이언트용 소켓

        private Thread mServerThread = null; // 서버 시작 스레드
        private Thread mReceiverThread = null; // 클라이언트로부터 수신 스레드

        /// <summary>
        /// 기본 생성자
        /// </summary>
        public AsyncSocket()
        {

        }

        /// <summary>
        /// chat창 객체를 파라미터로 받는 생성자
        /// </summary>
        /// <param name="chat"></param>
        public AsyncSocket(Chat chat)
        {
            mChatWnd = chat; // main chat form의 객체르 ㄹ연결
            Init(); // 초기화 작업
        }

        /// <summary>
        /// 소켓이 생성될때 필요한 초기화 작업을 수행
        /// </summary>
        private void Init()
        {
            SetMyIPAddress(); // 내 IP address 설정
        }

        /// <summary>
        /// 서버에 접속
        /// </summary>
        /// <param name="address">서버의 IP 주소</param>
        /// <param name="portNum">서버의 Prot 주소</param>
        public void Connect(String address, int portNum)
        {
            mServerIPAddress = address;
            mServerPortNum = portNum;

            // 접속할 서버의 IPEndpoint 객체 생성
            IPEndPoint serverIpep = new IPEndPoint(IPAddress.Parse(mServerIPAddress), mServerPortNum);

            mClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            mClientSocket.Connect(serverIpep);
            mChatWnd.NotifyMessage("서버에 접속하였습니다.");

            mCorrespondentIPAddress = mServerIPAddress;
            mReceiverThread = new Thread(new ThreadStart(Receive));
            mReceiverThread.Start();
            mChatWnd.NotifyMessage("서버로부터 메시지 수신을 시작합니다.");
        }

        /// <summary>
        /// 서버와 접속 종료
        /// </summary>
        public void Disconnet()
        {
            if (mClientSocket == null)
            {
                mChatWnd.NotifyMessage(" 에러!\r\n 클라이언트 소켓 객체가 null입니다.");
                return;
            }

            if (mClientSocket.Connected == false)
            {
                mChatWnd.NotifyMessage(" 에러!\r\n 클라이언트 소켓이 접속되어 있지 않습니다.");
            }
            mClientSocket.Close();

            if (mReceiverThread == null)
            {
                mChatWnd.NotifyMessage(" 에러!\r\n 수신 스레드 객체가 null입니다.");
                return;
            }

            if (mReceiverThread.IsAlive == false)
            {
                mChatWnd.NotifyMessage(" 에러!\r\n 수신 스레드 객체가 동작하고 있지 않습니다.");
                return;
            }
            mReceiverThread.Abort();
        }

        /// <summary>
        /// 서버를 시작
        /// </summary>
        /// <param name="portNum"></param>
        public void StartServer(int portNum)
        {
            mServerIPAddress = mMyIPAddress;
            mServerPortNum = portNum;

            mServerThread = new Thread(new ThreadStart(WaitConnection));
            mServerThread.Start();
        }

        /// <summary>
        /// 서버 중지
        /// </summary>
        public void StopServer()
        {
            if (mClientSocket != null)
            {
                if (mClientSocket.Connected == true)
                {
                    mClientSocket.Close();
                }
            }

            if (mServerSocket != null)
            {
                if (mServerSocket.Connected == true)
                {
                    mServerSocket.Close();
                }
            }

            if (mReceiverThread == null)
            {
                mChatWnd.NotifyMessage(" 에러!\r\n 수신 스레드 객체가 null입니다.");
                return;
            }

            if (mReceiverThread.IsAlive == false)
            {
                mChatWnd.NotifyMessage(" 에러!\r\n 수신 스레드 객체가 동작하고 있지 않습니다.");
                return;
            }
            mReceiverThread.Abort();
        }

        /// <summary>
        /// 서버용 접속 대기 함수
        /// </summary>
        private void WaitConnection()
        {
            IPEndPoint serverIpep = new IPEndPoint(IPAddress.Any, mServerPortNum);
            IPEndPoint clientIpep = null;

            mServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            mServerSocket.Bind(serverIpep);
            mServerSocket.Listen(10);

            mChatWnd.NotifyMessage("서버가 시작되었습니다.\r\n클라이언트의 접속을 대기합니다.");

            mClientSocket = mServerSocket.Accept();

            clientIpep = (IPEndPoint)mClientSocket.RemoteEndPoint;

            mChatWnd.NotifyMessage("IP주소 : " + clientIpep.Address.ToString() + "의 클라리언트가 접속하였습니다.");

            mCorrespondentIPAddress = clientIpep.Address.ToString();

            mReceiverThread = new Thread(new ThreadStart(Receive));
            mReceiverThread.Start();
            mChatWnd.NotifyMessage("클라이언트로부터 메시지 수신을 시작합니다.");
        }

        /// <summary>
        /// 상대방 호스트로부터 데이터 수신
        /// </summary>
        private void Receive()
        {
            String message = "";
            byte[] data = null;

            data = new byte[BUFFER_SIZE];

            while (true)
            {
                if (mClientSocket == null)
                {
                    mChatWnd.NotifyMessage(" 에러!\r\n 소켓 객체가 null입니다.");
                    break;
                }

                if (mClientSocket.Connected == false)
                {
                    mChatWnd.NotifyMessage(" 에러!\r\n 연결되어 있지 않습니다.");
                    break;
                }

                mClientSocket.Receive(data, SocketFlags.None);

                message = Encoding.Default.GetString(data);

                mChatWnd.ReceiveMessage(message);
            }
        }

        /// <summary>
        /// 문자열 형태의 message 전송
        /// </summary>
        /// <param name="message">전송할 문자열</param>
        public void Send(String message)
        {
            byte[] data = null;

            if (mClientSocket == null)
            {
                mChatWnd.NotifyMessage(" 에러!\r\n 소켓 객체가 null입니다.\r\n 메시지를 전송할 수 없습니다.");
                return;
            }

            if (mClientSocket.Connected == false)
            {
                mChatWnd.NotifyMessage(" 에러!\r\n 연결되어 있지 않습니다.\r\n 메시지를 전송할 수 없습니다.");
                return;
            }

            data = Encoding.Default.GetBytes(message);

            mClientSocket.Send(data, 0, data.Length, SocketFlags.None);
        }

        /// <summary>
        /// 자신의 IP 주소를 구하여 멤버 변수 mMyIPAddress에 저장
        /// </summary>
        private void SetMyIPAddress()
        {
            String myIPAddress = "";
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    myIPAddress = ip.ToString();
                    break;
                }
            }

            mMyIPAddress = myIPAddress;
        }

        /// <summary>
        /// 자신의 IP 주소를 반환
        /// </summary>
        /// <returns>자신의 IP 주소</returns>
        public String GetMyIPAddress()
        {
            return mMyIPAddress;
        }

        public String GetCorrespondentIPAddress()
        {
            return mCorrespondentIPAddress;
        }
    }
}
