namespace ImageResources
{
    public partial class ImageSlider : Form
    {
        private int imageIndex { get; set; } = 0;
        public List<Image> images;
        System.Windows.Forms.Timer timer;
        public ImageSlider() => InitializeComponent();
        private void ToggleTimer()
        {
            if (timer.Enabled)
            {
                timer.Stop();
                timer.Dispose();
                startBtn.Text = "Start";
            }
            else
            {
                timer.Start();
                startBtn.Text = "Stop";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            images = new List<Image>
            {
                Resource1.house0,
                Resource1.house1,
                Resource1.house2,
                Resource1.house3,
                Resource1.house4,
                Resource1.house5,
                Resource1.house6,
                Resource1.house7
            };

            pictureBox1.Image = images[0];

            imageCount.Text = imageIndex.ToString();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1500;
            timer.Tick += Timer_Tick;

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "I am NotifyIcon Ballon";
            notifyIcon1.BalloonTipTitle = "Welcome Message";
            notifyIcon1.Text = "My Application";
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = images[imageIndex++];

            if (imageIndex > 7) imageIndex = 0;

            imageCount.Text = imageIndex.ToString();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = images[imageIndex--];

            if (imageIndex < 0) imageIndex = 7;

            imageCount.Text = imageIndex.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            nextBtn_Click(sender, e);
            if (imageIndex == 6) timer.Stop();
        }

        private void startBtn_Click_1(object sender, EventArgs e)
        {
            ToggleTimer();
        }

        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExcuteBtn_Click(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void addImageBtn_Click(object sender, EventArgs e)
        {
            (new Drag_Drop()).Show();
        }
    }
}
