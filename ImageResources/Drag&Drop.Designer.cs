namespace ImageResources
{
    partial class Drag_Drop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drag_Drop));
            dnd_Box = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dnd_Box).BeginInit();
            SuspendLayout();
            // 
            // dnd_Box
            // 
            dnd_Box.Location = new Point(24, 12);
            dnd_Box.Name = "dnd_Box";
            dnd_Box.Size = new Size(403, 327);
            dnd_Box.TabIndex = 0;
            dnd_Box.TabStop = false;
            // 
            // Drag_Drop
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 425);
            Controls.Add(dnd_Box);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Drag_Drop";
            Text = "Drag Your Image Here";
            DragDrop += Drag_Drop_DragDrop;
            DragEnter += Drag_Drop_DragEnter;
            ((System.ComponentModel.ISupportInitialize)dnd_Box).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox dnd_Box;
    }
}