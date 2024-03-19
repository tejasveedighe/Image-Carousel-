namespace ImageResources
{
    public partial class Form1 : Form
    {
        private int imageIndex { get; set; } = 0;
        private List<Image> images;
        System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = images[imageIndex++];

            if (imageIndex > 7) imageIndex = 0;

            imageCount.Text = imageIndex.ToString();
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
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = images[imageIndex--];

            if (imageIndex < 0) imageIndex = 7;

            imageCount.Text = imageIndex.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            StartBtn_Click(sender, e);
            if (imageIndex > 7) timer.Stop();
        }

        private void startBtn_Click_1(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
