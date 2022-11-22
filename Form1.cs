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
            pbOrigin.Image = null;
            selectedPicture = string.Empty;
        }

        private void btnConvertImage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(selectedPicture))
            {
                var img = ConvertImg(selectedPicture);
                ConvertedImg = img;
                var retureImg = img.ToMemoryStream();
                pbResult.Image = Bitmap.FromStream(retureImg);
                pbResult.SizeMode = PictureBoxSizeMode.StretchImage;
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
            if (!string.IsNullOrWhiteSpace(tbSavePath.Text) && System.IO.Directory.Exists(tbSavePath.Text)&& cbExtension.SelectedIndex != -1)
            {
                foreach(var file in lsbPicture.Items)
                {
                    var selectedFile = file.ToString();
                    var img = ConvertImg(selectedFile);

                    var filename = (selectedFile.Split('\\')[selectedFile.Split('\\').Length - 1]).Split('.')[0];
                    var path = System.IO.Path.Combine(tbSavePath.Text, filename+cbExtension.SelectedItem.ToString());
                    Cv2.ImWrite(path, img);
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
        }
    }
}