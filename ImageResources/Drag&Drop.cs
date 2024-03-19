using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ImageResources
{
    public partial class Drag_Drop : Form
    {
        protected bool validData;

        string path;
        protected System.Drawing.Image image;
        protected Thread getImageThread;
        public Drag_Drop()
        {
            InitializeComponent();
        }

        private void Drag_Drop_DragEnter(object sender, DragEventArgs e)

        {
            string filename;
            validData = GetFilename(out filename, e);
            if (validData)
            {
                path = filename;
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }
        private bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                Array data = ((IDataObject)e.Data).GetData("FileDrop") as Array;
                if (data != null)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }
        private void Drag_Drop_DragDrop(object sender, DragEventArgs e)

        {
            if (validData)
            {
                while (getImageThread.IsAlive)
                {
                    System.Windows.Forms.Application.DoEvents();
                    Thread.Sleep(0);
                }
                dnd_Box.SizeMode = PictureBoxSizeMode.StretchImage;
                dnd_Box.Image = image;
            }
        }
        protected void LoadImage()

        {
            image = new Bitmap(path);
        }

    }
}
