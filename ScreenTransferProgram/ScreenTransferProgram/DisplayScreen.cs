using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenTransferProgram
{
    public partial class DisplayScreen : Form
    {
        // 사용할 네트워크의 종류, 서버
        private const int SERVER = 1;
        // 사용할 네트워크의 종류, 클라이언트
        private const int CLIENT = 2;

        // 텍스트 메시지 갱신 delegate
        delegate void UpdateTextCallback(String message);
        // 이미지 갱신 delegate
        delegate void UpdateScreenImage(Bitmap image);

        // 동기 소켓으로 작동하는 사용자 정의 소켓 클래스
        private AsyncSocket mAsynSocket = null;

        // 네트워크 종류를 나타냄
        private int mNetworkType = 0; 
        public DisplayScreen()
        {
            InitializeComponent();

            // 사용자 정의 소켓 클래스 생성
            mAsynSocket = new AsyncSocket(this);
            mTxtServerIPAddress.Text = mAsynSocket.GetMyIPAddress();
            mTxtServerPortNum.Text = AsyncSocket.DEFAULT_PORT_NUM.ToString();
            mTxtClientIPAddress.Text = mAsynSocket.GetMyIPAddress();
            mTxtClientPortNum.Text = AsyncSocket.DEFAULT_PORT_NUM.ToString();
        }

        /// <summary>
        /// 서버 시작 버튼 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnStartServer_Click(object sender, EventArgs e)
        {
            // 서버 port 번호
            int portNum = 0;
            // 서버 port 번호를 입력
            portNum = Int32.Parse(mTxtServerPortNum.Text.Trim());
            // 서버 시작
            mAsynSocket.StartServer(portNum);

            // 네트워크 종류를 서버로 지정
            mNetworkType = SERVER;
        }

        /// <summary>
        /// 클라이언트 시작 버튼 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnStartClient_Click(object sender, EventArgs e)
        {
            // 서버 IP 주소
            String serverIPAddress = "";
            // 서버 port 번호
            int portNum = 0;

            // 접속할 서버 IP 주소 획득
            serverIPAddress = mTxtServerIPAddress.Text.Trim();

            // 접속할 서버 port 번호를 가져옴
            portNum = Int32.Parse(mTxtServerPortNum.Text.Trim());

            // 클라이언트 기능 초기화
            mAsynSocket.InitClientSocket(serverIPAddress, portNum);

            // 네트워크 종류를 클라이언트로 지정
            mNetworkType = CLIENT;

            mAsynSocket.Send();
        }

        /// <summary>
        /// 종료 버튼 클릭 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnExit_Click(object sender, EventArgs e)
        {
            if(mNetworkType == SERVER)
            {
                mAsynSocket.StopServer();
            }
            else if(mNetworkType == CLIENT)
            {
                mAsynSocket.CloseClientSocket();
            }
        }

        /// <summary>
        /// AsyncSockets 클래스로부터 시스템적 전달 사항 수신
        /// </summary>
        /// <param name="message">AsyncSockets 클래스로부터 수신한 공지 사항</param>
        public void NotifyMessage(String message)
        {
            message = message + "\r\n";

            AppendMessage(message);
        }

        /// <summary>
        /// 메시지 창에 텍스트 추가
        /// </summary>
        /// <param name="message"></param>
        private void AppendMessage(String message)
        {
            try
            {
                if(mTxtStatus.InvokeRequired)
                {
                    UpdateTextCallback d = new UpdateTextCallback(AppendMessage);
                    Invoke(d, new object[] { message });
                }
                else
                {
                    // TextBox 컨트롤에 추가할 텍스트 입력
                    mTxtStatus.AppendText(message + "\r\n");
                }
            }
            catch { }
        }
    }
}
