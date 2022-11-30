using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace ImageMaster
{
    public partial class frmImageMaster : Form
    {
        private readonly string[] ImgaeExtension = new string[] { ".jpg", ".png", "jpeg", "jfif" };
        private string selectedPicture { get; set; }
        private Mat ConvertedImg { get; set; }
        enum EdgeFilterType
        {
            Canny,
            Sobel,
            Laplace
        }
        private double ratio = 1.0;
        private float ratio_c = 0f;
        public frmImageMaster()
        {
            InitializeComponent();
            setInitProperty();
        }
        private void setInitProperty()
        {
            foreach (var i in Enum.GetValues(typeof(ThresholdTypes)))
            {
                cbThresholdFlag.Items.Add(i.ToString());
            }
            foreach (var i in Enum.GetValues(typeof(EdgeFilterType)))
            {
                cbEdgeFilter.Items.Add(i.ToString());
            }
            foreach (var i in Enum.GetValues(typeof(MorphTypes)))
            {
                cbMorphology.Items.Add(i.ToString());
            }
            cbExtension.Items.Add(".png");
            cbExtension.Items.Add(".jpg");
        }
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdAddImages = new FolderBrowserDialog();
            var rv = fbdAddImages.ShowDialog();
            if (rv == DialogResult.OK)
            {
                var FolderName = fbdAddImages.SelectedPath;
                var di = new System.IO.DirectoryInfo(FolderName);
                foreach (var file in di.GetFiles())
                {
                    if (ImgaeExtension.Contains(file.Extension.ToLower()))
                    {
                        if (!lsbPicture.Items.Contains(file.FullName))
                        {
                            lsbPicture.Items.Add(file.FullName);
                        }
                    }
                }
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAddImage = new OpenFileDialog();
            var rv = ofdAddImage.ShowDialog();
            if (rv == DialogResult.OK)
            {
                var FileNames = ofdAddImage.FileNames;

                foreach (var file in FileNames)
                {
                    var buf = file.Substring(file.Length - 5);
                    if (ImgaeExtension.Contains(file.Substring(file.Length - 4)))
                    {
                        if (!lsbPicture.Items.Contains(file))
                        {
                            lsbPicture.Items.Add(file);

                        }
                    }
                }
            }
        }

        private void lsbPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pbOrigin.Image != null)
            {
                pbOrigin.Image.Dispose();
            }
            selectedPicture = lsbPicture.SelectedItem.ToString();
            pbOrigin.Load(selectedPicture);
            pbOrigin.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsbPicture.SelectedIndex == -1)
            {
                MessageBox.Show("Select item");
            }
            else
            {
                lsbPicture.Items.RemoveAt(lsbPicture.SelectedIndex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsbPicture.Items.Clear();
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pbOrigin.Image.Dispose();
            selectedPicture = string.Empty;
        }

        private void btnConvertImage_Click(object sender, EventArgs e)
        {
            if(pbResult.Image != null)
            {
                pbResult.Image.Dispose();
            }
            if (!string.IsNullOrWhiteSpace(selectedPicture))
            {
                var img = ConvertImg(selectedPicture);
                ConvertedImg = img;
                var retureImg = img.ToMemoryStream();
                pbResult.Image = Bitmap.FromStream(retureImg);
                pbResult.SizeMode = PictureBoxSizeMode.StretchImage;
                img.Dispose();
            }
        }
        private Mat ConvertImg(string path)
        {
            var img = Cv2.ImRead(path);
            if (cbGray.Checked)
            {
                Cv2.CvtColor(img, img, ColorConversionCodes.RGB2GRAY);
            }

            if (cbUseEdgeFilter.Checked)
            {
                if (cbEdgeFilter.SelectedIndex != -1)
                {
                    if (Enum.TryParse(cbEdgeFilter.SelectedItem.ToString(), out EdgeFilterType EdgeFilter))
                    {
                        if (!Double.TryParse(tbEdgeThr1.Text, out double thr1))
                        {
                            MessageBox.Show("Insert EdgeThr1");
                            return null;
                        }
                        if (!Double.TryParse(tbEdgeThr2.Text, out double thr2))
                        {
                            MessageBox.Show("Insert tbEdgeThr2");
                            return null;
                        }

                        var buf = new Mat(img.Size(), MatType.CV_8UC1);
                        if (EdgeFilter == EdgeFilterType.Canny)
                        {
                            Cv2.Canny(img, buf, thr1, thr1);
                        }
                        else if (EdgeFilter == EdgeFilterType.Sobel)
                        {
                            Cv2.Sobel(img, buf, MatType.CV_8UC1, Convert.ToInt32(thr1), Convert.ToInt32(thr2));
                        }
                        else if (EdgeFilter == EdgeFilterType.Laplace)
                        {
                            Cv2.Laplacian(img, buf, MatType.CV_8UC1);
                        }
                        img = buf;

                    }
                }
            }

            if (cbUseMorphology.Checked)
            {
                if (cbMorphology.SelectedIndex != -1)
                {
                    if (Enum.TryParse(cbMorphology.SelectedItem.ToString(), out MorphTypes morphTypes))
                    {
                        var buf = new Mat(5, 5, MatType.CV_8UC1);
                        Cv2.MorphologyEx(img, img, morphTypes, buf);
                    }
                }
            }
            if (cbUseTreshold.Checked)
            {
                if (cbThresholdFlag.SelectedIndex != -1)
                {
                    if (Enum.TryParse(cbThresholdFlag.SelectedItem.ToString(), out ThresholdTypes thresholdTypes))
                    {
                        if (!Double.TryParse(tbThreshold.Text, out double thresh))
                        {
                            MessageBox.Show("Insert Threashold");
                            return null;
                        }
                        if (!Double.TryParse(tbRV.Text, out double rv))
                        {
                            MessageBox.Show("Insert Return Value");
                            return null;
                        }
                        Cv2.Threshold(img, img, thresh, rv, thresholdTypes);
                    }
                }
            }
            return img;
        }
        private void btnSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdSaveImagePath = new FolderBrowserDialog();
            var rv = fbdSaveImagePath.ShowDialog();
            if (rv == DialogResult.OK)
            {
                var FolderName = fbdSaveImagePath.SelectedPath;
                tbSavePath.Text = FolderName;
            }
        }

        private void btnSaveOne_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.DefaultExt = "png";
            saveFileDialog1.Filter = "png files(*.png)|*.png";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK&& ConvertedImg != null)
            {
                var fileName = saveFileDialog1.FileName.ToString();
                Cv2.ImWrite(fileName, ConvertedImg);
            }           
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (!string.IsNullOrWhiteSpace(tbSavePath.Text) && System.IO.Directory.Exists(tbSavePath.Text)&& cbExtension.SelectedIndex != -1)
            {
                foreach(var file in lsbPicture.Items)
                {
                    var selectedFile = file.ToString();
                    var img = ConvertImg(selectedFile);

                    var filename = "";
                    if (!cbChangeName.Checked)
                    {
                        var buf = selectedFile.Split('\\');
                        filename = buf[buf.Length - 1].Split('.')[0];

                    }
                    else
                    {
                        filename = string.Format("{0}_{1}", tbSaveFileName.Text, i++);
                    }

                    var path = System.IO.Path.Combine(tbSavePath.Text, filename+cbExtension.SelectedItem.ToString());
                    Cv2.ImWrite(path, img);
                    img.Dispose();
                }
            }
            else if (string.IsNullOrWhiteSpace(tbSavePath.Text))
            {
                MessageBox.Show("Not Exists SavePath ");
            }
            else if (cbExtension.SelectedIndex != -1)
            {
                MessageBox.Show(" Choose Extension ");
            }
            MessageBox.Show("Save Done !!!");

        }
        //private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    int lines = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
        //    PictureBox pb = (PictureBox)sender;

        //    if (lines > 0)
        //    {
        //        ratio *= 1.1F;
        //        if (ratio > 100.0) ratio = 100.0f;

        //        imgRect.Width = (int)Math.Round(pictureBox1.Width * ratio);
        //        imgRect.Height = (int)Math.Round(pictureBox1.Height * ratio);
        //        imgRect.X = -(int)Math.Round(1.1F * (imgPoint.X - imgRect.X) - imgPoint.X);
        //        imgRect.Y = -(int)Math.Round(1.1F * (imgPoint.Y - imgRect.Y) - imgPoint.Y);
        //    }
        //    else if (lines < 0)
        //    {
        //        ratio *= 0.9F;
        //        if (ratio < 1) ratio = 1;

        //        imgRect.Width = (int)Math.Round(pictureBox1.Width * ratio);
        //        imgRect.Height = (int)Math.Round(pictureBox1.Height * ratio);
        //        imgRect.X = -(int)Math.Round(0.9F * (imgPoint.X - imgRect.X) - imgPoint.X);
        //        imgRect.Y = -(int)Math.Round(0.9F * (imgPoint.Y - imgRect.Y) - imgPoint.Y);
        //    }

        //    if (imgRect.X > 0) imgRect.X = 0;
        //    if (imgRect.Y > 0) imgRect.Y = 0;
        //    if (imgRect.X + imgRect.Width < pictureBox1.Width) imgRect.X = pictureBox1.Width - imgRect.Width;
        //    if (imgRect.Y + imgRect.Height < pictureBox1.Height) imgRect.Y = pictureBox1.Height - imgRect.Height;
        //    pictureBox1.Invalidate();
        //}

    }
}