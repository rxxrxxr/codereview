using System;
using System.Drawing;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const int PlayerSpeed = 10;
        private const int BulletSpeed = 10;
        private int playerX;
        private System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            playerX = (ClientSize.Width - playerPictureBox.Width) / 2; // 플레이어를 화면 가운데에 배치
            playerPictureBox.Location = new Point(playerX, ClientSize.Height - playerPictureBox.Height - 10); // 플레이어의 초기 위치 설정
            timer = new System.Timers.Timer();
            timer.Interval = 20; // 타이머 간격 설정 (20밀리초마다 타이머 발생)
            timer.Elapsed += Timer_Tick; // 타이머 이벤트 핸들러 연결

            timer.Start(); // 타이머 시작
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MoveBullet(); // 총알 이동
        }
        private bool gameOver = false; // 게임 오버 상태를 나타내는 변수


        private void MoveBullet()
        {
            if (!gameOver) 
            {
                // 총알 PictureBox들을 이동시킵니다.
                foreach (Control control in Controls)
                {
                    if (control is PictureBox && control.Tag?.ToString() == "bullet")
                    {
                        control.Top += BulletSpeed; // 아래로 이동
                        if (control.Bounds.IntersectsWith(playerPictureBox.Bounds))
                        {
                            GameOver(); // 플레이어와 총알이 충돌하면 게임 종료

                        }
                    }
                }
            }
            
        }

        private void GameOver()
        {
            gameOver = true;
            timer.Stop(); // 게임 오버 시 타이머 정지
            MessageBox.Show("Game Over! Your score: "); // 게임 종료 메시지 표시
            // 여기서 점수를 표시할 수도 있습니다.
            Application.Exit(); // 게임 종료
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // 방향키 입력 처리
            switch (keyData)
            {
                case Keys.Left:
                    if (playerPictureBox.Left > 0)
                        playerPictureBox.Left -= PlayerSpeed;
                    break;
                case Keys.Right:
                    if (playerPictureBox.Right < ClientSize.Width)
                        playerPictureBox.Left += PlayerSpeed;
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
