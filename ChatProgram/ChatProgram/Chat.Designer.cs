namespace ChatProgram
{
    partial class Chat
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mTxtMyIP = new System.Windows.Forms.TextBox();
            this.mTxtMyPortNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mTxtServerPortNum = new System.Windows.Forms.TextBox();
            this.mTxtServerIP = new System.Windows.Forms.TextBox();
            this.mBtnStartServer = new System.Windows.Forms.Button();
            this.mBtnConnectToServer = new System.Windows.Forms.Button();
            this.mTxtChatWindow = new System.Windows.Forms.TextBox();
            this.mTxtInputMessage = new System.Windows.Forms.TextBox();
            this.mBtnSendMessage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "내 아이피";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "내 포트 번호";
            // 
            // mTxtMyIP
            // 
            this.mTxtMyIP.Location = new System.Drawing.Point(97, 14);
            this.mTxtMyIP.Name = "mTxtMyIP";
            this.mTxtMyIP.Size = new System.Drawing.Size(100, 21);
            this.mTxtMyIP.TabIndex = 2;
            // 
            // mTxtMyPortNum
            // 
            this.mTxtMyPortNum.Location = new System.Drawing.Point(97, 36);
            this.mTxtMyPortNum.Name = "mTxtMyPortNum";
            this.mTxtMyPortNum.Size = new System.Drawing.Size(100, 21);
            this.mTxtMyPortNum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "서버 아이피";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "서버 포트 번호";
            // 
            // mTxtServerPortNum
            // 
            this.mTxtServerPortNum.Location = new System.Drawing.Point(97, 14);
            this.mTxtServerPortNum.Name = "mTxtServerPortNum";
            this.mTxtServerPortNum.Size = new System.Drawing.Size(100, 21);
            this.mTxtServerPortNum.TabIndex = 6;
            // 
            // mTxtServerIP
            // 
            this.mTxtServerIP.Location = new System.Drawing.Point(97, 36);
            this.mTxtServerIP.Name = "mTxtServerIP";
            this.mTxtServerIP.Size = new System.Drawing.Size(100, 21);
            this.mTxtServerIP.TabIndex = 7;
            // 
            // mBtnStartServer
            // 
            this.mBtnStartServer.Location = new System.Drawing.Point(203, 14);
            this.mBtnStartServer.Name = "mBtnStartServer";
            this.mBtnStartServer.Size = new System.Drawing.Size(87, 45);
            this.mBtnStartServer.TabIndex = 8;
            this.mBtnStartServer.Text = "서버 시작";
            this.mBtnStartServer.UseVisualStyleBackColor = true;
            this.mBtnStartServer.Click += new System.EventHandler(this.mBtnStartServer_Click);
            // 
            // mBtnConnectToServer
            // 
            this.mBtnConnectToServer.Location = new System.Drawing.Point(203, 12);
            this.mBtnConnectToServer.Name = "mBtnConnectToServer";
            this.mBtnConnectToServer.Size = new System.Drawing.Size(87, 46);
            this.mBtnConnectToServer.TabIndex = 9;
            this.mBtnConnectToServer.Text = "서버 접속";
            this.mBtnConnectToServer.UseVisualStyleBackColor = true;
            this.mBtnConnectToServer.Click += new System.EventHandler(this.mBtnConnectToServer_Click);
            // 
            // mTxtChatWindow
            // 
            this.mTxtChatWindow.Location = new System.Drawing.Point(12, 155);
            this.mTxtChatWindow.Multiline = true;
            this.mTxtChatWindow.Name = "mTxtChatWindow";
            this.mTxtChatWindow.Size = new System.Drawing.Size(307, 179);
            this.mTxtChatWindow.TabIndex = 10;
            // 
            // mTxtInputMessage
            // 
            this.mTxtInputMessage.Location = new System.Drawing.Point(12, 340);
            this.mTxtInputMessage.Multiline = true;
            this.mTxtInputMessage.Name = "mTxtInputMessage";
            this.mTxtInputMessage.Size = new System.Drawing.Size(239, 42);
            this.mTxtInputMessage.TabIndex = 11;
            this.mTxtInputMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mTxtInputMessage_KeyDown);
            // 
            // mBtnSendMessage
            // 
            this.mBtnSendMessage.Location = new System.Drawing.Point(257, 340);
            this.mBtnSendMessage.Name = "mBtnSendMessage";
            this.mBtnSendMessage.Size = new System.Drawing.Size(62, 42);
            this.mBtnSendMessage.TabIndex = 12;
            this.mBtnSendMessage.Text = "보내기";
            this.mBtnSendMessage.UseVisualStyleBackColor = true;
            this.mBtnSendMessage.Click += new System.EventHandler(this.mBtnSendMessage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mTxtMyIP);
            this.groupBox1.Controls.Add(this.mTxtMyPortNum);
            this.groupBox1.Controls.Add(this.mBtnStartServer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 67);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "서버용";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mTxtServerPortNum);
            this.groupBox2.Controls.Add(this.mTxtServerIP);
            this.groupBox2.Controls.Add(this.mBtnConnectToServer);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 64);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "클라이언트용";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 392);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mBtnSendMessage);
            this.Controls.Add(this.mTxtInputMessage);
            this.Controls.Add(this.mTxtChatWindow);
            this.Name = "Chat";
            this.Text = "채팅 프로그램";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mTxtMyIP;
        private System.Windows.Forms.TextBox mTxtMyPortNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mTxtServerPortNum;
        private System.Windows.Forms.TextBox mTxtServerIP;
        private System.Windows.Forms.Button mBtnStartServer;
        private System.Windows.Forms.Button mBtnConnectToServer;
        private System.Windows.Forms.TextBox mTxtChatWindow;
        private System.Windows.Forms.TextBox mTxtInputMessage;
        private System.Windows.Forms.Button mBtnSendMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

