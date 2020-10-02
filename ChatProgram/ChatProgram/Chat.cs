using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace ChatProgram
{
    public partial class Chat : Form
    {
        delegate void UpdateTextCallback(String message);

        AsyncSocket mAsyncSocket = null;

        /// <summary>
        /// Chat 클래스 생성자
        /// </summary>
        public Chat()
        {
            InitializeComponent();

            mAsyncSocket = new AsyncSocket(this);
            mTxtMyIP.Text = mAsyncSocket.GetMyIPAddress();
            mTxtMyPortNum.Text = AsyncSocket.DEFAULT_PORT_NUM.ToString();
            mTxtServerIP.Text = mAsyncSocket.GetMyIPAddress();
            mTxtServerPortNum.Text = AsyncSocket.DEFAULT_PORT_NUM.ToString();
        }

        /// <summary>
        /// 멀티 스레딩에서 사용할 delegate 함수
        /// </summary>
        /// <param name="message">출력할 메시지</param>
        private void AppendMessage(String message)
        {
            try
            {
                if (mTxtInputMessage.InvokeRequired)
                {
                    UpdateTextCallback d = new UpdateTextCallback(AppendMessage);
                    Invoke(d, new object[] { message });
                }
                else
                {
                    mTxtChatWindow.AppendText(message + "\r\n");
                    mTxtChatWindow.ScrollToCaret();
                    mTxtInputMessage.Focus();
                }
            }
            catch { }
        }

        /// <summary>
        /// 알림 메시지 전달
        /// </summary>
        /// <param name="message">Sync소켓s 클래스로부터 수신한 공지 사항</param>
        public void NotifyMessage(String message)
        {
            message = "\r\n------알림!------\r\n" + message + "\r\n-----------------\r\n";

            AppendMessage(message);
        }

        /// <summary>
        /// 서버 시작 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnStartServer_Click(object sender, EventArgs e)
        {
            int portNum = 0;
            portNum = Int32.Parse(mTxtMyPortNum.Text.Trim());
            mAsyncSocket.StartServer(portNum);
        }

        /// <summary>
        /// 서버 접속 이벤트 처리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnConnectToServer_Click(object sender, EventArgs e)
        {
            String serverIPAddress = "";
            int portNum = 0;

            serverIPAddress = mTxtServerIP.Text.Trim();

            portNum = Int32.Parse(mTxtServerPortNum.Text.Trim());

            mAsyncSocket.Connect(serverIPAddress, portNum);
        }

        /// <summary>
        /// 보내기 버튼 클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mBtnSendMessage_Click(object sender, EventArgs e)
        {
            String message = "";
            String myIPAddress = "";
            message = mTxtInputMessage.Text;
            myIPAddress = mAsyncSocket.GetMyIPAddress();

            SendMessage(message);

            message = "나 (" + myIPAddress + ")\r\n" + message;

            AppendMessage(message);

            mTxtInputMessage.Text = "";
            mTxtInputMessage.Focus();
        }

        /// <summary>
        /// 메시지 전송
        /// </summary>
        /// <param name="message"></param>
        private void SendMessage(String message)
        {
            mAsyncSocket.Send(message);
        }

        /// <summary>
        /// 키보드 입력 이벤트 발생 처리
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mTxtInputMessage_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    String message = "";
            //    String myIPAddress = "";
            //    message = mTxtInputMessage.Text;
            //    myIPAddress = mAsyncSocket.GetMyIPAddress();

            //    SendMessage(message);

            //    message = "나 (" + myIPAddress + ")\r\n" + message;

            //    AppendMessage(message);

            //    mTxtInputMessage.Text = "";
            //    mTxtInputMessage.Focus();
            //}

            // key 입력과 같이 사용 가능
            if (e.KeyCode == Keys.Enter)
            {
                this.mBtnSendMessage_Click(sender, e);
            }
        }

        /// <summary>
        /// 클라이언트로부터 메시지를 수신할 경우 호출
        /// </summary>
        /// <param name="message"></param>
        public void ReceiveMessage(String message)
        {
            String correspondentIPAddress = "";
            correspondentIPAddress = mAsyncSocket.GetCorrespondentIPAddress();

            message = "상대방 (" + correspondentIPAddress + ")\r\n" + message;

            AppendMessage(message);
        }
    }
}
