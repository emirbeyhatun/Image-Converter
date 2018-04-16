using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image img;
        Image ScaleByPercent(Image imgPhoto, float Percent)
        {
            float nPercent = ((float)Percent / 100);

            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;

            int destX = 0;
            int destY = 0;
            int destWidth = (int)(sourceWidth * nPercent);
            int destHight = (int)(sourceHeight * nPercent);


            Bitmap bmPhoto = new Bitmap(destWidth, destHight, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            #region ForTheBorderProblem
            grPhoto.CompositingMode = CompositingMode.SourceCopy;
            grPhoto.PixelOffsetMode = PixelOffsetMode.Half;
            grPhoto.InterpolationMode = InterpolationMode.NearestNeighbor;
            grPhoto.DrawImage(imgPhoto, new Rectangle(destX, destY, destWidth, destHight), new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight), GraphicsUnit.Pixel);
            #endregion
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
            grPhoto.DrawImage(imgPhoto, new Rectangle(destX, destY, destWidth, destHight), new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight), GraphicsUnit.Pixel);
            grPhoto.Dispose();
            return bmPhoto;









        }

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFD = new OpenFileDialog();
            OpenFD.Title = "Select Files";
            OpenFD.Filter = "Jpg|*.jpg|Jpge|*.jpge|Gif|*.gif|Png|*.png";
            OpenFD.FileName = null;
            string fileName;
            if(OpenFD.ShowDialog()== DialogResult.OK)
            {
                fileName = OpenFD.FileName;
                try
                {
                    img = Image.FromFile(OpenFD.FileName);
                    pictureBox1.Image = img;
                    AndroidBtn.Enabled = true;
                    ResizeBtn.Enabled = true;
                    IosBtn.Enabled = true;
                    #region DisplayStats
                    HeightLbl.Text = img.Height.ToString();
                    WidthLbl.Text = img.Width.ToString();
                    VerticleDpiLbl.Text = img.VerticalResolution.ToString();
                    HorizontalDpiLbl.Text = img.HorizontalResolution.ToString();
                    #endregion
                }catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message.ToString());
                } 
            }
        }

        private void AndroidBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.Filter = "JPeg image|*.jpg|Png|*.png";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName!= "")
            {
                System.IO.FileStream fs;
                Image imgPhoto = null;
                string temp = saveFileDialog1.FileName;
                string[] extensions = new string[] { ".jpg", ".png" };
                string[] androidVersions = new string[] { "-ldpi", "-mdpi", "-hdpi", "-xhdpi", "-xxhdpi" };
                float[] androidRatios = new float[] { 18.75f, 25f, 37.5f, 50f, 75f };
                ImageFormat[] format = new ImageFormat[] { System.Drawing.Imaging.ImageFormat.Jpeg, System.Drawing.Imaging.ImageFormat.Png };

                try
                {
                    for (int i = 0; i < androidVersions.Length; i++)
                    {
                        imgPhoto = ScaleByPercent(img, androidRatios[i]);
                        saveFileDialog1.FileName = temp;
                        if (saveFileDialog1.FileName.EndsWith(extensions[saveFileDialog1.FilterIndex-1]))
                        {
                            saveFileDialog1.FileName = saveFileDialog1.FileName.Substring(0, saveFileDialog1.FileName.Length - extensions[saveFileDialog1.FilterIndex - 1].Length);
                            saveFileDialog1.FileName += androidVersions[i] + extensions[saveFileDialog1.FilterIndex - 1];
                        }
                        fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                        imgPhoto.Save(fs, format[saveFileDialog1.FilterIndex - 1]);
                        fs.Close();

                    }
                }
                catch (Exception ae)
                {
                    
                    throw new Exception(ae.Message.ToString());
                }
            }
        }

        private void IosBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.Filter = "JPeg image|*.jpg|Png|*.png";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs;
                Image imgPhoto = null;
                string temp = saveFileDialog1.FileName;
                string[] extensions = new string[] { ".jpg", ".png" };
                string[] iosVersions = new string[] { "@1x", "@2x" };
                float[] iosRatios = new float[] { 33.3f, 66.6f };
                ImageFormat[] format = new ImageFormat[] { System.Drawing.Imaging.ImageFormat.Jpeg, System.Drawing.Imaging.ImageFormat.Png };

                try
                {
                    for (int i = 0; i < iosVersions.Length; i++)
                    {
                        imgPhoto = ScaleByPercent(img, iosRatios[i]);
                        saveFileDialog1.FileName = temp;
                        if (saveFileDialog1.FileName.EndsWith(extensions[saveFileDialog1.FilterIndex - 1]))
                        {
                            saveFileDialog1.FileName = saveFileDialog1.FileName.Substring(0, saveFileDialog1.FileName.Length - extensions[saveFileDialog1.FilterIndex - 1].Length);
                            saveFileDialog1.FileName += iosVersions[i] + extensions[saveFileDialog1.FilterIndex - 1];
                        }
                        fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                        imgPhoto.Save(fs, format[saveFileDialog1.FilterIndex - 1]);
                        fs.Close();

                    }
                }
                catch (Exception ae)
                {

                    throw new Exception(ae.Message.ToString());
                }
            }
        }

        private void ResizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image==null)
                {
                    throw new Exception("First select a picture");
                }
                img = pictureBox1.Image;
                float ratio = float.Parse(ResizeText.Text.ToString());
                img = ScaleByPercent(img, ratio);
                #region DisplayStats
                HeightLbl.Text = img.Height.ToString();
                WidthLbl.Text = img.Width.ToString();
                VerticleDpiLbl.Text = img.VerticalResolution.ToString();
                HorizontalDpiLbl.Text = img.HorizontalResolution.ToString();

                #endregion
                pictureBox1.Image = img;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message.ToString());
            }
        }
    }
}
