namespace ImageResources
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
            pictureBox1 = new PictureBox();
            nextBtn = new Button();
            prevBtn = new Button();
            imageCount = new Label();
            startBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            nextBtn.Location = new Point(246, 380);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(75, 41);
            nextBtn.TabIndex = 1;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += StartBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            prevBtn.Location = new Point(99, 380);
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
            imageCount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            imageCount.Location = new Point(199, 381);
            imageCount.Name = "imageCount";
            imageCount.Size = new Size(24, 30);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 486);
            Controls.Add(startBtn);
            Controls.Add(imageCount);
            Controls.Add(prevBtn);
            Controls.Add(nextBtn);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button nextBtn;
        private Button prevBtn;
        private Label imageCount;
        private Button startBtn;
    }
}
