using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using ScreenTransferProgram;
using System.Drawing;

namespace ScreenTransferProgram
{
    class AsyncSocket
    {
        // 패킷 헤더 크기
        private const int PACKET_HEADER_SIZE = 4;

        // 기본 포트 번호
        public const int DEFAULT_PORT_NUM = 3317;

        // Display screen form
        private DisplayScreen mDisplayScreenWnd = null;

        // 자신의 IP Address
        private String mMyIPAddress = "";
        // 서버 IP Address
        private String mServerIPAddress = "";

        // 서버 Port num
        private int mServerPortNum = 0;

        // 접속 대기용 소켓
        private Socket mServerSocket = null;
        // 클라이언트용 소켓
        private Socket mClientSocket = null;

        // 서버 데이터 수신 스레드
        private Thread mReceiverThread = null;

        // Screen Capture 관련 기능 수행 클래스
        private ScreenCapture mScreenCapture = null;

        /// <summary>
        /// 기본 생성자
        /// </summary>
        public AsyncSocket()
        {

        }

        /// <summary>
        /// Display 객체를 파라미터로 받는 생성자
        /// </summary>
        /// <param name="displayScreen">Display 객체 변수</param>
        public AsyncSocket(DisplayScreen displayScreen)
        {
            // Display form의 객체를 연결
            mDisplayScreenWnd = displayScreen;
            // 초기화 작업
            Init();
        }

        /// <summary>
        /// 소켓이 생성될 때 필요한 초기화 작업을 수행
        /// </summary>
        private void Init()
        {
            // 내 IP Address 설정
            SetMyIPAddress();

            // Screen capture 관련 기능 수행 객체 생성
            mScreenCapture = new ScreenCapture();
        }

        /// <summary>
        /// Client Socket 초기화
        /// </summary>
        /// <param name="serverIPAddress">접속할 서버 IP 주소</param>
        /// <param name="serverPortNum">접속할 서버 Prot 번호</param>
        public void InitClientSocket(String serverIPAddress, int serverPortNum)
        {
            mServerIPAddress = serverIPAddress;
            mServerPortNum = serverPortNum;

            // 접속할 서버의 IPEndPoint 객체 생성
            IPEndPoint serverIpep = new IPEndPoint(IPAddress.Parse(mServerIPAddress), mServerPortNum);

            // 데이터 통신에 사용할 클라이언트용 소켓 생성
            mClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }

        /// <summary>
        /// Client Socket 종료
        /// </summary>
        public void CloseClientSocket()
        {
            // 클라이언트용 소켓을 닫음
            // 소켓을 닫기 전에 발생할 수 있는 error 처리
            // 소켓 객체가 null일 경우, error 처리
            if(mClientSocket == null)
            {
                mDisplayScreenWnd.NotifyMessage("에러!\r\n 클라이언트 소켓 객체가 null입니다.");
                return;
            }
            // 클라이언트 소켓을 닫음
            // 소켓 자원을 반환
            mClientSocket.Close();

            mDisplayScreenWnd.NotifyMessage("UDP 클라이언트 소켓을 닫았습니다.");
            mDisplayScreenWnd.NotifyMessage("UDP 클라이언트 소켓을 종료 완료");
        }

        /// <summary>
        /// 서버를 시작
        /// </summary>
        /// <param name="portNum">서버 Port 번호</param>
        public void StartServer(int portNum)
        {
            mServerIPAddress = mMyIPAddress;
            mServerPortNum = portNum;

            // 서버의 IPEndPoint 객체를 생성
            IPEndPoint serverIpep = new IPEndPoint(IPAddress.Any, mServerPortNum);

            // 서버에서 접속 대기용으로 사용할 서버용 소켓을 생성
            mServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            // 생성한 서버 소켓에 IP주소와 Port 번호를 지정
            mServerSocket.Bind(serverIpep);

            // 데이터 수신 함수를 스레드에 연결
            mReceiverThread = new Thread(new ThreadStart(Receive));
            // 데이터 수신 스레드 시작
            mReceiverThread.Start();

            mDisplayScreenWnd.NotifyMessage("UDP 서버를 시작합니다.");
        }

        /// <summary>
        /// 서버 중지
        /// </summary>
        public void StopServer()
        {
            // 서버용 소켓을 닫음
            // 소켓을 닫기 전에 발생할 수 있는 error 처리
            if(mServerSocket == null)
            {
                mDisplayScreenWnd.NotifyMessage("에러!\r\n 서버용 소켓 객체가 null입니다.");
                // Return이 필요한지?
            }
            // 서버용 소켓을 닫음
            mServerSocket.Close();

            mDisplayScreenWnd.NotifyMessage("UDP 서버 소켓을 닫았습니다.");

            // 데이터 수신 스레드를 종료
            // 종료하기 전에 발생할 수 있는 error 처리
            // 수신 스레드 객체가 null일경우, error 처리
            if(mReceiverThread == null)
            {
                mDisplayScreenWnd.NotifyMessage("에러!\r\n 수신 스레드 객체가 null입니다.");
                return;
            }

            // 수신 스레드가 동작하지 않을 경우, error 처리
            if(mReceiverThread.IsAlive == false)
            {
                mDisplayScreenWnd.NotifyMessage("에러!\r\n 수신 스레드 객체가 동작하고 있지 않습니다.");
                return;
            }

            // 데이터 수신 스레드를 종료
            mReceiverThread.Abort();

            mDisplayScreenWnd.NotifyMessage("UDP 서버 수신 스레드를 종료하였습니다.");
            mDisplayScreenWnd.NotifyMessage("UDP 서버 종료 완료");
        }

        /// <summary>
        /// 상대방 호스트로부터 데이터 수신
        /// </summary>
        private void Receive()
        {
            // 수신한 raw data
            byte[] data = null;
            // 수신한 Image
            Bitmap image = null;

            while(true)
            {
                // Socket 객체가 null일 경우, error 처리
                if(mServerSocket == null)
                {
                    mDisplayScreenWnd.NotifyMessage("에러!\r\n 소켓 객체가 null입니다.");
                    break;
                }

                // 데이터 수신
                data = ReceiveData();

                image = mScreenCapture.GetScreenImage(data, data.Length);

                // disyplay screen 창에 새로운 image 전달
                mDisplayScreenWnd.RefreshScreenImage(image);

                mDisplayScreenWnd.NotifyMessage("새로운 화면 수신");
            }
        }

        /// <summary>
        /// 소켓의 버퍼에 있는 데이터 수신
        /// </summary>
        /// <returns>수신 완료된 데이터</returns>
        private byte[] ReceiveData()
        {
            // 패킷 헤더 수신 버퍼
            byte[] headerBuffer = new byte[PACKET_HEADER_SIZE];
            // 데이터 수신 버퍼 설정
            byte[] dataBuffer = null;

            // 전체 데이터 크기
            int totalDataSize = 0;
            // 지금까지 수신한 데이터 크기
            int accumulatedDataSize = 0;
            // 미수신한 데이터 크기
            int leftDataSize = 0;
            // 수신한 데이터 크기
            int receivedDataSize = 0;

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 0);
            EndPoint remote = (EndPoint)ipep;

            // 데이터 수신
            // receivedDataSize에는 Receive 함수를 한 번 호출함으로써 수신한 데이터 크기가 저장
            receivedDataSize = mServerSocket.ReceiveFrom(headerBuffer, 0, PACKET_HEADER_SIZE, SocketFlags.None, ref remote);

            // 수신하여야 할 총 데이터 크기를 구함
            totalDataSize = BitConverter.ToInt32(headerBuffer, 0);

            // 남은 수신하여야 하는 데이터 크기를 leftDataSize에 저장
            leftDataSize = totalDataSize;
            // 수신할 총 데이터 크기만큼 데이터 배열 생성
            dataBuffer = new byte[totalDataSize];

            // 수신하여야 할 남은 데이터가 없을 때 까지 반복
            while(leftDataSize > 0)
            {
                // 데이터 수신
                receivedDataSize = mServerSocket.ReceiveFrom(dataBuffer, accumulatedDataSize, leftDataSize, SocketFlags.None, ref remote);

                // 총 누적 수신된 데이터를 구함
                accumulatedDataSize += receivedDataSize;

                // 수신하여야 할 남은 데이터를 구함
                leftDataSize -= receivedDataSize;
            }

            // 수신된 데이터가 들어있는 dataBuffer 변수를 반환
            return dataBuffer;
        }

        /// <summary>
        /// 화면을 캡처한 이미지 전송
        /// </summary>
        public void Send()
        {
            // 전송할 raw data
            byte[] data = null;

            // Socket 객체가 null일 경우, error 처리
            if(mClientSocket == null)
            {
                mDisplayScreenWnd.NotifyMessage("에러!\r\n 소켓 객체가 null입니다.\r\n 메시지를 전송할 수 없습니다.");
                return;
            }

            data = mScreenCapture.GetScreenImageByteArray();

            // 데이터 전송
            SendData(data);

            mDisplayScreenWnd.NotifyMessage("서버로 화면 전송 완료");
        }

        /// <summary>
        /// byte 배열 형태의 데이터 값을 네트워크를 통해 전송
        /// </summary>
        /// <param name="dataBuffer">전송하고자 하는 값이 들어있는 byte 배열</param>
        private void SendData(byte[] dataBuffer)
        {
            // 패킷 헤더 수신 버퍼
            byte[] headerBuffer = new byte[PACKET_HEADER_SIZE];

            // 전체 데이터 크기
            int totalDataSize = 0;
            // 지금까지 수신한 데이터 크기
            int accumulatedDataSize = 0;
            // 미수신한 데이터 크기
            int leftDataSize = 0;
            // 수신한 데이터 크기
            int sentDataSize = 0;

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(mServerIPAddress), mServerPortNum);

            // 저체 데이터 크기를 구함
            totalDataSize = dataBuffer.Length;
            // 남은 데이터 크기를 구함
            leftDataSize = totalDataSize - sentDataSize;

            // 전송할 데이터의 총 크기를 구함
            headerBuffer = BitConverter.GetBytes(totalDataSize);

            // 전체 데이터 크기를 전송
            mClientSocket.SendTo(headerBuffer, PACKET_HEADER_SIZE, SocketFlags.None, ipep);

            // 데이터를 모두 전송할 때 까지 반복
            while (leftDataSize > 0)
            {
                // 데이터 전송
                // sentDatasize에는 send 함수를 한 번 호출함으로써 전송된 데이터의 크기가 저장
                sentDataSize = mClientSocket.SendTo(dataBuffer, accumulatedDataSize, leftDataSize, SocketFlags.None, ipep);

                // 총 누적 수신된 데이터를 구함
                accumulatedDataSize += sentDataSize;

                // 수신하여야 할 남은 데이터를 구함
                leftDataSize -= sentDataSize;
            }
        }

        /// <summary>
        /// 자신의 IP 주소를 구하여 멤버 변수 mMyIPAddress에 저장
        /// </summary>
        private void SetMyIPAddress()
        {
            String myIPAddress = "";
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
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
        /// <returns></returns>
        public String GetMyIPAddress()
        {
            return mMyIPAddress;
        }
    }
}
