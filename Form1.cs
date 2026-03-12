using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; // Windows Media Player 라이브러리 사용

namespace CatchButton
{
    public partial class Form1 : Form
    {        
        // 1. 난수 생성기 준비 (클래스 레벨에서 선언하여 재사용)
        Random rd = new Random();

        // 효과음 재생기 생성
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void C_Button_Click(object sender, EventArgs e)
        {
            // [잡았을 때] 버튼을 실제로 클릭했을 때
            // 잡은 소리 재생 
            player.URL = "Catch.mp3";
            player.controls.play();

            // 축하 메시지 출력 
            MessageBox.Show("축하합니다~!", "승리");
        }

        // 마우스가 버튼 영역에 진입했을 때 실행되는 이벤트 핸들러
        private void C_Button_MouseEnter(object sender, EventArgs e)
        {
            // 2. 가용 영역 계산 (버튼이 폼 테두리 밖으로 나가지 않게 버튼 크기만큼 제외)
            int maxX = this.ClientSize.Width - C_Button.Width;
            int maxY = this.ClientSize.Height - C_Button.Height;

            // 3. 랜덤 좌표 추출 (0 이상, 최대 가용치 미만)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);

            // 4. 새로운 위치로 버튼 이동
            C_Button.Location = new Point(nextX, nextY);

            // 5. 폼 제목 표시줄에 현재 좌표 출력
            this.Text = $"버튼 위치: ({nextX}, {nextY})";

            // [도망갈 때] 마우스가 버튼에 닿으려 할 때 
            // 도망가는 소리 재생
            player.URL = "Run.mp3";
            player.controls.play();

            C_Button.Location = new Point(nextX, nextY);
            this.Text = $"버튼 위치: ({nextX}, {nextY})";
        }
    }
}
