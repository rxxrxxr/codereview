namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            playerPictureBox = new PictureBox();
            PictureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // playerPictureBox
            // 
            playerPictureBox.BackgroundImage = (Image)resources.GetObject("playerPictureBox.BackgroundImage");
            playerPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            playerPictureBox.Location = new Point(343, 361);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(67, 65);
            playerPictureBox.TabIndex = 0;
            playerPictureBox.TabStop = false;
            // 
            // PictureBox
            // 
            PictureBox.BackgroundImage = (Image)resources.GetObject("PictureBox.BackgroundImage");
            PictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            PictureBox.Location = new Point(297, 12);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(27, 25);
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            PictureBox.Tag = "bullet";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += Timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PictureBox);
            Controls.Add(playerPictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox playerPictureBox;
        private PictureBox PictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}
