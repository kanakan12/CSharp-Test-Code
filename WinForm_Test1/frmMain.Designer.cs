namespace WinForm_Test1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.laResult = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.laResult_1 = new System.Windows.Forms.Label();
            this.chkExample = new System.Windows.Forms.CheckBox();
            this.laResult_2 = new System.Windows.Forms.Label();
            this.raItem1 = new System.Windows.Forms.RadioButton();
            this.raItem2 = new System.Windows.Forms.RadioButton();
            this.raItem3 = new System.Windows.Forms.RadioButton();
            this.laResult_3 = new System.Windows.Forms.Label();
            this.lstDrives = new System.Windows.Forms.ListBox();
            this.cmbDrives = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴테스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴테스트1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴테스트11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timUpdate = new System.Windows.Forms.Timer(this.components);
            this.laTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(444, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 12);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "이름이 무엇입니까?";
            // 
            // laResult
            // 
            this.laResult.AutoSize = true;
            this.laResult.Location = new System.Drawing.Point(419, 228);
            this.laResult.Name = "laResult";
            this.laResult.Size = new System.Drawing.Size(0, 12);
            this.laResult.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(421, 282);
            this.txtName.MaxLength = 5;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 21);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(421, 310);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // laResult_1
            // 
            this.laResult_1.AutoSize = true;
            this.laResult_1.Location = new System.Drawing.Point(419, 392);
            this.laResult_1.Name = "laResult_1";
            this.laResult_1.Size = new System.Drawing.Size(189, 12);
            this.laResult_1.TabIndex = 7;
            this.laResult_1.Text = "체크 박스가 선택되지 않았습니다.";
            // 
            // chkExample
            // 
            this.chkExample.AutoSize = true;
            this.chkExample.Location = new System.Drawing.Point(421, 420);
            this.chkExample.Name = "chkExample";
            this.chkExample.Size = new System.Drawing.Size(104, 16);
            this.chkExample.TabIndex = 8;
            this.chkExample.Text = "체크 박스 예제";
            this.chkExample.UseVisualStyleBackColor = true;
            this.chkExample.CheckedChanged += new System.EventHandler(this.chkExample_CheckedChanged);
            // 
            // laResult_2
            // 
            this.laResult_2.AutoSize = true;
            this.laResult_2.Location = new System.Drawing.Point(419, 470);
            this.laResult_2.Name = "laResult_2";
            this.laResult_2.Size = new System.Drawing.Size(191, 12);
            this.laResult_2.TabIndex = 9;
            this.laResult_2.Text = "1번 라디오 버튼이 선택되었습니다";
            // 
            // raItem1
            // 
            this.raItem1.AutoSize = true;
            this.raItem1.Checked = true;
            this.raItem1.Location = new System.Drawing.Point(421, 498);
            this.raItem1.Name = "raItem1";
            this.raItem1.Size = new System.Drawing.Size(41, 16);
            this.raItem1.TabIndex = 10;
            this.raItem1.TabStop = true;
            this.raItem1.Text = "1번";
            this.raItem1.UseVisualStyleBackColor = true;
            this.raItem1.CheckedChanged += new System.EventHandler(this.raItem1_CheckedChanged);
            // 
            // raItem2
            // 
            this.raItem2.AutoSize = true;
            this.raItem2.Location = new System.Drawing.Point(421, 520);
            this.raItem2.Name = "raItem2";
            this.raItem2.Size = new System.Drawing.Size(41, 16);
            this.raItem2.TabIndex = 11;
            this.raItem2.TabStop = true;
            this.raItem2.Text = "2번";
            this.raItem2.UseVisualStyleBackColor = true;
            this.raItem2.CheckedChanged += new System.EventHandler(this.raItem2_CheckedChanged);
            // 
            // raItem3
            // 
            this.raItem3.AutoSize = true;
            this.raItem3.Location = new System.Drawing.Point(421, 542);
            this.raItem3.Name = "raItem3";
            this.raItem3.Size = new System.Drawing.Size(41, 16);
            this.raItem3.TabIndex = 12;
            this.raItem3.TabStop = true;
            this.raItem3.Text = "3번";
            this.raItem3.UseVisualStyleBackColor = true;
            this.raItem3.CheckedChanged += new System.EventHandler(this.raItem3_CheckedChanged);
            // 
            // laResult_3
            // 
            this.laResult_3.AutoSize = true;
            this.laResult_3.Location = new System.Drawing.Point(61, 251);
            this.laResult_3.Name = "laResult_3";
            this.laResult_3.Size = new System.Drawing.Size(137, 12);
            this.laResult_3.TabIndex = 13;
            this.laResult_3.Text = "선택된 항목이 없습니다.";
            // 
            // lstDrives
            // 
            this.lstDrives.FormattingEnabled = true;
            this.lstDrives.ItemHeight = 12;
            this.lstDrives.Location = new System.Drawing.Point(63, 282);
            this.lstDrives.Name = "lstDrives";
            this.lstDrives.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDrives.Size = new System.Drawing.Size(160, 232);
            this.lstDrives.TabIndex = 14;
            this.lstDrives.SelectedIndexChanged += new System.EventHandler(this.lstDrives_SelectedIndexChanged);
            // 
            // cmbDrives
            // 
            this.cmbDrives.FormattingEnabled = true;
            this.cmbDrives.Location = new System.Drawing.Point(63, 520);
            this.cmbDrives.Name = "cmbDrives";
            this.cmbDrives.Size = new System.Drawing.Size(121, 20);
            this.cmbDrives.TabIndex = 15;
            this.cmbDrives.SelectedIndexChanged += new System.EventHandler(this.cmbDrives_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴테스트ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴테스트ToolStripMenuItem
            // 
            this.메뉴테스트ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴테스트1ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.메뉴테스트ToolStripMenuItem.Name = "메뉴테스트ToolStripMenuItem";
            this.메뉴테스트ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.메뉴테스트ToolStripMenuItem.Text = "메뉴 테스트";
            // 
            // 메뉴테스트1ToolStripMenuItem
            // 
            this.메뉴테스트1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴테스트11ToolStripMenuItem});
            this.메뉴테스트1ToolStripMenuItem.Name = "메뉴테스트1ToolStripMenuItem";
            this.메뉴테스트1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.메뉴테스트1ToolStripMenuItem.Text = "메뉴 테스트 1";
            // 
            // 메뉴테스트11ToolStripMenuItem
            // 
            this.메뉴테스트11ToolStripMenuItem.Name = "메뉴테스트11ToolStripMenuItem";
            this.메뉴테스트11ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.메뉴테스트11ToolStripMenuItem.Text = "메뉴 테스트 1-1";
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // timUpdate
            // 
            this.timUpdate.Tick += new System.EventHandler(this.timUpdate_Tick);
            // 
            // laTime
            // 
            this.laTime.AutoSize = true;
            this.laTime.Location = new System.Drawing.Point(201, 524);
            this.laTime.Name = "laTime";
            this.laTime.Size = new System.Drawing.Size(65, 12);
            this.laTime.TabIndex = 17;
            this.laTime.Text = "00 : 00 : 00";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 621);
            this.Controls.Add(this.laTime);
            this.Controls.Add(this.cmbDrives);
            this.Controls.Add(this.lstDrives);
            this.Controls.Add(this.laResult_3);
            this.Controls.Add(this.raItem3);
            this.Controls.Add(this.raItem2);
            this.Controls.Add(this.raItem1);
            this.Controls.Add(this.laResult_2);
            this.Controls.Add(this.chkExample);
            this.Controls.Add(this.laResult_1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.laResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForm-EX";
            this.Click += new System.EventHandler(this.frmMain_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laResult;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label laResult_1;
        private System.Windows.Forms.CheckBox chkExample;
        private System.Windows.Forms.Label laResult_2;
        private System.Windows.Forms.RadioButton raItem1;
        private System.Windows.Forms.RadioButton raItem2;
        private System.Windows.Forms.RadioButton raItem3;
        private System.Windows.Forms.Label laResult_3;
        private System.Windows.Forms.ListBox lstDrives;
        private System.Windows.Forms.ComboBox cmbDrives;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴테스트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴테스트1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴테스트11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.Timer timUpdate;
        private System.Windows.Forms.Label laTime;
    }
}

