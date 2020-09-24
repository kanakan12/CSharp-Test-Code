using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinForm_Test1
{
    public partial class frmMain : Form
    {
        string path = AppDomain.CurrentDomain.BaseDirectory;
        DriveInfo[] drives = DriveInfo.GetDrives();

        public frmMain()
        {
            InitializeComponent();
            this.Text = "코드 편집 창에서 Text 속성을 변경하였습니다.";

            linkLabel1.Text = "클릭 하면 홈페이지로 이동합니다.";
            linkLabel1.Links.Add(0, 2, "http:\\www.mircosoft.com");

            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = new Bitmap(path + "Test_Image.PNG");

            timUpdate.Start();

            for (int n = 0; n < drives.Length; n++)
            {
                lstDrives.Items.Add(drives[n].Name + " - " + drives[n].DriveType);
            }

            for (int n = 0; n < drives.Length; n++)
            {
                cmbDrives.Items.Add(drives[n].Name + " - " + drives[n].DriveType);
            }

            laTime.Text = DateTime.Now.Hour + " : " + DateTime.Now.Minute + " :" + DateTime.Now.Second;
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            this.Text = "클릭 했습니다.";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 해당과 같은 방법으로 링크 추가 가능
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "버튼이 눌렸습니다!!";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            laResult.Text = "아하! 당신은" + txtName.Text + "이군요.";
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                laResult.Text = "아하! 당신은" + txtName.Text + "이군요.";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            laResult.Text = "아하! 당신은" + txtName.Text + "이군요.";
        }

        private void chkExample_CheckedChanged(object sender, EventArgs e)
        {
            // 해당 방법은 선호하지 않음
            // 여러개의 체크 박스를 사용할 경우 혼동여지 존재하기 때문
            //if (chkExample.Checked)
            //    laResult_1.Text = "체크 박스가 선택되었습니다.";
            //else
            //    laResult_1.Text = "체크 박스가 선택되지 않았습니다.";

            CheckBox chkExam = sender as CheckBox;
            if (chkExam.Checked)
                laResult_1.Text = "체크 박스가 선택되었습니다.";
            else
                laResult_1.Text = "체크 박스가 선택되지 않았습니다.";
        }

        private void raItem1_CheckedChanged(object sender, EventArgs e)
        {
            laResult_2.Text = "1번 라디오 버튼이 선택되었습니다.";
        }

        private void raItem2_CheckedChanged(object sender, EventArgs e)
        {
            laResult_2.Text = "2번 라디오 버튼이 선택되었습니다.";
        }

        private void raItem3_CheckedChanged(object sender, EventArgs e)
        {
            laResult_2.Text = "3번 라디오 버튼이 선택되었습니다.";
        }

        private void lstDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selCount = lstDrives.SelectedItems.Count;

            if (selCount <= 1 && selCount > 0)
                laResult_3.Text = "선택된 항목은 " + lstDrives.SelectedItem.ToString() + "입니다.";
            else if (selCount >= 2)
                laResult_3.Text = "선택된 항목은 총" + selCount.ToString() + "개 입니다.";
            else if(selCount == 0)
                laResult_3.Text = "선택된 항목이없습니다.";
        }

        private void cmbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            laResult_3.Text = "선택된 항목은 " + cmbDrives.SelectedItem.ToString() + "입니다.";
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timUpdate_Tick(object sender, EventArgs e)
        {
            laTime.Text = DateTime.Now.Hour + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Second;
        }
    }
}
