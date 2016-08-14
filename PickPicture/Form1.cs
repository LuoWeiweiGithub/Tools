using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PickPicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadPic_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtPicPath.Text))
            {
                picOriginal.Load(txtPicPath.Text);
                picOriginal.Size = picOriginal.Image.Size;
            }
        }

        private void txtPicPath_DoubleClick(object sender, EventArgs e)
        {
            if (openPicDialog.ShowDialog() == DialogResult.OK)
                txtPicPath.Text = openPicDialog.FileName;
        }

        private void picOriginal_MouseClick(object sender, MouseEventArgs e)
        {
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            Bitmap original = picOriginal.Image as Bitmap;
            int x1 = int.Parse(txtX1.Text);
            int x2 = int.Parse(txtX2.Text);
            int y1 = int.Parse(txtY1.Text);
            int y2 = int.Parse(txtY2.Text);
            Rectangle srcRect = new Rectangle(x1, y1, x2 - x1, y2 - y1);
            Bitmap cropped = (Bitmap)original.Clone(srcRect, original.PixelFormat);
            picPicked.Image = cropped;
            picPicked.Size = cropped.Size;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                picPicked.Image.Save(saveFileDialog.FileName);
        }
    }
}
