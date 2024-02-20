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
            playerX = (ClientSize.Width - playerPictureBox.Width) / 2; // �÷��̾ ȭ�� ����� ��ġ
            playerPictureBox.Location = new Point(playerX, ClientSize.Height - playerPictureBox.Height - 10); // �÷��̾��� �ʱ� ��ġ ����
            timer = new System.Timers.Timer();
            timer.Interval = 20; // Ÿ�̸� ���� ���� (20�и��ʸ��� Ÿ�̸� �߻�)
            timer.Elapsed += Timer_Tick; // Ÿ�̸� �̺�Ʈ �ڵ鷯 ����

            timer.Start(); // Ÿ�̸� ����
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MoveBullet(); // �Ѿ� �̵�
        }
        private bool gameOver = false; // ���� ���� ���¸� ��Ÿ���� ����


        private void MoveBullet()
        {
            if (!gameOver) 
            {
                // �Ѿ� PictureBox���� �̵���ŵ�ϴ�.
                foreach (Control control in Controls)
                {
                    if (control is PictureBox && control.Tag?.ToString() == "bullet")
                    {
                        control.Top += BulletSpeed; // �Ʒ��� �̵�
                        if (control.Bounds.IntersectsWith(playerPictureBox.Bounds))
                        {
                            GameOver(); // �÷��̾�� �Ѿ��� �浹�ϸ� ���� ����

                        }
                    }
                }
            }
            
        }

        private void GameOver()
        {
            gameOver = true;
            timer.Stop(); // ���� ���� �� Ÿ�̸� ����
            MessageBox.Show("Game Over! Your score: "); // ���� ���� �޽��� ǥ��
            // ���⼭ ������ ǥ���� ���� �ֽ��ϴ�.
            Application.Exit(); // ���� ����
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // ����Ű �Է� ó��
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
