namespace ScreenTransferProgram
{
    partial class DisplayScreen
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mPicScreenImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mBtnStartServer = new System.Windows.Forms.Button();
            this.mTxtServerPortNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mTxtServerIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mBtnStartClient = new System.Windows.Forms.Button();
            this.mTxtClientPortNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mTxtClientIPAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mTxtStatus = new System.Windows.Forms.TextBox();
            this.mBtnExit = new System.Windows.Forms.Button();
            this.mTimerSendScreenImage = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mPicScreenImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mPicScreenImage);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 620);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "화면 출력";
            // 
            // mPicScreenImage
            // 
            this.mPicScreenImage.Location = new System.Drawing.Point(6, 20);
            this.mPicScreenImage.Name = "mPicScreenImage";
            this.mPicScreenImage.Size = new System.Drawing.Size(803, 594);
            this.mPicScreenImage.TabIndex = 0;
            this.mPicScreenImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mBtnStartServer);
            this.groupBox2.Controls.Add(this.mTxtServerPortNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mTxtServerIPAddress);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(833, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "서버용";
            // 
            // mBtnStartServer
            // 
            this.mBtnStartServer.Location = new System.Drawing.Point(6, 98);
            this.mBtnStartServer.Name = "mBtnStartServer";
            this.mBtnStartServer.Size = new System.Drawing.Size(188, 37);
            this.mBtnStartServer.TabIndex = 2;
            this.mBtnStartServer.Text = "서버 시작";
            this.mBtnStartServer.UseVisualStyleBackColor = true;
            this.mBtnStartServer.Click += new System.EventHandler(this.mBtnStartServer_Click);
            // 
            // mTxtServerPortNum
            // 
            this.mTxtServerPortNum.Location = new System.Drawing.Point(6, 71);
            this.mTxtServerPortNum.Name = "mTxtServerPortNum";
            this.mTxtServerPortNum.Size = new System.Drawing.Size(188, 21);
            this.mTxtServerPortNum.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "서버 포트번호";
            // 
            // mTxtServerIPAddress
            // 
            this.mTxtServerIPAddress.Location = new System.Drawing.Point(6, 32);
            this.mTxtServerIPAddress.Name = "mTxtServerIPAddress";
            this.mTxtServerIPAddress.Size = new System.Drawing.Size(188, 21);
            this.mTxtServerIPAddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "서버 아이피";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mBtnStartClient);
            this.groupBox3.Controls.Add(this.mTxtClientPortNum);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.mTxtClientIPAddress);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(833, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "클라이언트용";
            // 
            // mBtnStartClient
            // 
            this.mBtnStartClient.Location = new System.Drawing.Point(6, 95);
            this.mBtnStartClient.Name = "mBtnStartClient";
            this.mBtnStartClient.Size = new System.Drawing.Size(188, 44);
            this.mBtnStartClient.TabIndex = 3;
            this.mBtnStartClient.Text = "클라이언트 시작";
            this.mBtnStartClient.UseVisualStyleBackColor = true;
            this.mBtnStartClient.Click += new System.EventHandler(this.mBtnStartClient_Click);
            // 
            // mTxtClientPortNum
            // 
            this.mTxtClientPortNum.Location = new System.Drawing.Point(6, 71);
            this.mTxtClientPortNum.Name = "mTxtClientPortNum";
            this.mTxtClientPortNum.Size = new System.Drawing.Size(188, 21);
            this.mTxtClientPortNum.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "클라이언트 포트번호";
            // 
            // mTxtClientIPAddress
            // 
            this.mTxtClientIPAddress.Location = new System.Drawing.Point(6, 32);
            this.mTxtClientIPAddress.Name = "mTxtClientIPAddress";
            this.mTxtClientIPAddress.Size = new System.Drawing.Size(188, 21);
            this.mTxtClientIPAddress.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "클라이언트 아이피";
            // 
            // mTxtStatus
            // 
            this.mTxtStatus.Location = new System.Drawing.Point(833, 306);
            this.mTxtStatus.Multiline = true;
            this.mTxtStatus.Name = "mTxtStatus";
            this.mTxtStatus.ReadOnly = true;
            this.mTxtStatus.Size = new System.Drawing.Size(200, 272);
            this.mTxtStatus.TabIndex = 3;
            // 
            // mBtnExit
            // 
            this.mBtnExit.Location = new System.Drawing.Point(833, 584);
            this.mBtnExit.Name = "mBtnExit";
            this.mBtnExit.Size = new System.Drawing.Size(200, 42);
            this.mBtnExit.TabIndex = 4;
            this.mBtnExit.Text = "네트워크 종료";
            this.mBtnExit.UseVisualStyleBackColor = true;
            this.mBtnExit.Click += new System.EventHandler(this.mBtnExit_Click);
            // 
            // mTimerSendScreenImage
            // 
            this.mTimerSendScreenImage.Tick += new System.EventHandler(this.mTimerSendScreenImage_Tick);
            // 
            // DisplayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 644);
            this.Controls.Add(this.mBtnExit);
            this.Controls.Add(this.mTxtStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DisplayScreen";
            this.Text = "화면 전송 프로그램";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mPicScreenImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox mPicScreenImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button mBtnStartServer;
        private System.Windows.Forms.TextBox mTxtServerPortNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mTxtServerIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button mBtnStartClient;
        private System.Windows.Forms.TextBox mTxtClientPortNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mTxtClientIPAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mTxtStatus;
        private System.Windows.Forms.Button mBtnExit;
        private System.Windows.Forms.Timer mTimerSendScreenImage;
    }
}

