namespace ImageResources
{
    partial class ImageSlider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageSlider));
            pictureBox1 = new PictureBox();
            nextBtn = new Button();
            prevBtn = new Button();
            imageCount = new Label();
            startBtn = new Button();
            ExecuteBtn = new ToolStripMenuItem();
            CloseBtn = new ToolStripMenuItem();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            ExcuteBtn = new ToolStripMenuItem();
            CloseAppBtn = new ToolStripMenuItem();
            label1 = new Label();
            addImageBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(29, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 303);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // nextBtn
            // 
            nextBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nextBtn.Location = new Point(254, 427);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(75, 41);
            nextBtn.TabIndex = 1;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            prevBtn.Location = new Point(92, 427);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(75, 41);
            prevBtn.TabIndex = 2;
            prevBtn.Text = "Prev";
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // imageCount
            // 
            imageCount.AutoSize = true;
            imageCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            imageCount.Location = new Point(148, 332);
            imageCount.Name = "imageCount";
            imageCount.Size = new Size(19, 21);
            imageCount.TabIndex = 3;
            imageCount.Text = "0";
            // 
            // startBtn
            // 
            startBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            startBtn.Location = new Point(173, 427);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(75, 41);
            startBtn.TabIndex = 4;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click_1;
            // 
            // ExecuteBtn
            // 
            ExecuteBtn.Name = "ExecuteBtn";
            ExecuteBtn.Size = new Size(32, 19);
            // 
            // CloseBtn
            // 
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(32, 19);
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ExcuteBtn, CloseAppBtn });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 48);
            // 
            // ExcuteBtn
            // 
            ExcuteBtn.Name = "ExcuteBtn";
            ExcuteBtn.Size = new Size(103, 22);
            ExcuteBtn.Text = "Open";
            // 
            // CloseAppBtn
            // 
            CloseAppBtn.Name = "CloseAppBtn";
            CloseAppBtn.Size = new Size(103, 22);
            CloseAppBtn.Text = "Close";
            CloseAppBtn.Click += CloseAppBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 332);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 5;
            label1.Text = "Current Image:";
            // 
            // addImageBtn
            // 
            addImageBtn.Location = new Point(344, 335);
            addImageBtn.Name = "addImageBtn";
            addImageBtn.Size = new Size(75, 23);
            addImageBtn.TabIndex = 6;
            addImageBtn.Text = "Add Image";
            addImageBtn.UseVisualStyleBackColor = true;
            addImageBtn.Click += addImageBtn_Click;
            // 
            // ImageSlider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 486);
            Controls.Add(addImageBtn);
            Controls.Add(label1);
            Controls.Add(startBtn);
            Controls.Add(imageCount);
            Controls.Add(prevBtn);
            Controls.Add(nextBtn);
            Controls.Add(pictureBox1);
            Name = "ImageSlider";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button nextBtn;
        private Button prevBtn;
        private Label imageCount;
        private Button startBtn;
        private ToolStripMenuItem ExecuteBtn;
        private ToolStripMenuItem CloseBtn;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ExcuteBtn;
        private ToolStripMenuItem CloseAppBtn;
        private Label label1;
        private Button addImageBtn;
    }
}
