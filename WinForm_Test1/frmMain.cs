using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Test1
{
    public partial class frmMain : Form
    {
        string path = AppDomain.CurrentDomain.BaseDirectory;
        public frmMain()
        {
            InitializeComponent();
            this.Text = "코드 편집 창에서 Text 속성을 변경하였습니다.";

            linkLabel1.Text = "클릭 하면 홈페이지로 이동합니다.";
            linkLabel1.Links.Add(0, 2, "http:\\www.mircosoft.com");

            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = new Bitmap(path + "Test_Image.PNG");
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
    }
}
