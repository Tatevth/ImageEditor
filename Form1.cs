using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image file,file2,file3;
        Boolean opened = false;

        private void OpenImage()
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
           
            if (dialogResult==DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox.Image = file;
                opened = true;

            }
            
        }
        private void OpenImage2()
        {
            DialogResult dialogResult2 = openFileDialog2.ShowDialog();

            if (dialogResult2 == DialogResult.OK)
            {
                txtPath2.Text = openFileDialog2.FileName;
                file2 = Image.FromFile(openFileDialog2.FileName);
                pictureBox1.Image = file2;
                opened = true;

            }

        }
        private void OpenImage3()
        {
            DialogResult dialogResult3 = openFileDialog3.ShowDialog();

            if (dialogResult3 == DialogResult.OK)
            {
                txtPath3.Text = openFileDialog3.FileName;
                file3 = Image.FromFile(openFileDialog3.FileName);
                pictureBox2.Image = file3;
                opened = true;

            }

        }

        private void SaveImage()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Images|*.png;*.bmp;*jpg";
            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                string ext = Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;

                }
                pictureBox.Image.Save(saveFileDialog.FileName, format);
            }
            else
            {
                MessageBox.Show("Upload the image");
            }
        }

        private void SaveImage2()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Images|*.png;*.bmp;*jpg";
            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;

                }
                pictureBox1.Image.Save(saveFileDialog.FileName, format);
            }
            else
            {
                MessageBox.Show("Upload the image");
            }
        }

        private void SaveImage3()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Images|*.png;*.bmp;*jpg";
            ImageFormat format = ImageFormat.Png;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;

                }
                pictureBox2.Image.Save(saveFileDialog.FileName, format);
            }
            else
            {
                MessageBox.Show("Upload the image");
            }
        }

        private void Reload()
        {
            if (!opened)
            {

            }
            else
            {
                if (opened)
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox.Image = file;
                    opened = true;
                }
            }
        }
        private void Reload2()
        {
            if (!opened)
            {

            }
            else
            {
                if (opened)
                {
                    file2 = Image.FromFile(openFileDialog2.FileName);
                    pictureBox1.Image = file2;
                    opened = true;
                }
            }
        }
        private void Reload3()
        {
            if (!opened)
            {

            }
            else
            {
                if (opened)
                {
                    file3 = Image.FromFile(openFileDialog3.FileName);
                    pictureBox2.Image = file3;
                    opened = true;
                }
            }
        }
        private void Filter1()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox.Image;                            
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);  
                                                                        

                ImageAttributes ia = new ImageAttributes();                
                ColorMatrix cmPicture = new ColorMatrix(new float[][]      
                {
                    new float[]{.393f, .349f, .272f+1.3f, 0, 0},
            new float[]{.769f, .686f+0.5f, .534f, 0, 0},
            new float[]{.189f+2.3f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);         
                Graphics g = Graphics.FromImage(bmpInverted);  
                                                            
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox.Image = bmpInverted;

            }
        }

        private void Filter1_2()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f, .272f+1.3f, 0, 0},
            new float[]{.769f, .686f+0.5f, .534f, 0, 0},
            new float[]{.189f+2.3f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }

        private void Filter1_3()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox2.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f, .272f+1.3f, 0, 0},
            new float[]{.769f, .686f+0.5f, .534f, 0, 0},
            new float[]{.189f+2.3f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox2.Image = bmpInverted;

            }
        }

        private void Filter2()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
            new float[]{.769f+0.3f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox.Image = bmpInverted;

            }
        }
        private void Filter2_2()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
            new float[]{.769f+0.3f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }
        private void Filter2_3()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox2.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
            new float[]{.769f+0.3f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                pictureBox2.Image = bmpInverted;

            }
        }

        void grayscale()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox.Image;                            
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   
                                                                        

                ImageAttributes ia = new ImageAttributes();                
                ColorMatrix cmPicture = new ColorMatrix(new float[][]   
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });
                ia.SetColorMatrix(cmPicture);         
                Graphics g = Graphics.FromImage(bmpInverted); 
                                                          

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


               
                g.Dispose();                          
                pictureBox.Image = bmpInverted;
               
            }
        }

        void grayscale2()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);


                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);



                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }
        void grayscale3()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                Image img = pictureBox2.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);


                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);


                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);



                g.Dispose();
                pictureBox2.Image = bmpInverted;

            }
        }

        new Image Resize(Image file, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.DrawImage(file, 0, 0, w, h);
            graphics.Dispose();

            return bmp;

        }
         Image Resize2(Image file2, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.DrawImage(file2, 0, 0, w, h);
            graphics.Dispose();

            return bmp;

        }
         Image Resize3(Image file3, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.DrawImage(file3, 0, 0, w, h);
            graphics.Dispose();

            return bmp;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void Filt1Btn(object sender, EventArgs e)
        {
            Reload();
            Filter1();
        }

        private void Filt2Btn(object sender, EventArgs e)
        {
            Reload();
            Filter2();
        }

        private void ResetBtn(object sender, EventArgs e)
        {
            Reload();
        }

        private void resizeBtn_Click(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(width_txt.Text), h = Convert.ToInt32(height_txt.Text);
            file = Resize(file, w, h);
            pictureBox.Image = file;
            width_txt.Text = "";
            height_txt.Text = "";
           
            MessageBox.Show("Image successfully resized!");

        }

        private void filter3Btn(object sender, EventArgs e)
        {
            Reload();
            grayscale();
        }

        private void openImg2Btn(object sender, EventArgs e)
        {
            OpenImage2();
        }

       
        private void openImg3Btn(object sender, EventArgs e)
        {
            OpenImage3();
        }

        private void filter1img2Btn(object sender, EventArgs e)
        {
            Reload2();
            Filter1_2();
        }

        private void filter2img2Btn(object sender, EventArgs e)
        {
            Reload2();
            Filter2_2();

        }

        private void filter3img2_Click(object sender, EventArgs e)
        {
            Reload2();
            grayscale2();
        }

        private void resetimg2_Click(object sender, EventArgs e)
        {
            Reload2();
                               
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void resizeimg2Btn_Click(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(width2_txt.Text), h = Convert.ToInt32(height2_txt.Text);
            file2 = Resize2(file2, w, h);
            pictureBox1.Image = file2;
            width2_txt.Text = "";
            height2_txt.Text = "";

            MessageBox.Show("Image successfully resized!");
        }

        private void saveimg2Btn(object sender, EventArgs e)
        {
            SaveImage2();
        }

        private void resizeimg3Btn_Click(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(width3_txt.Text), h = Convert.ToInt32(height3_txt.Text);
            file3 = Resize3(file3, w, h);
            pictureBox2.Image = file3;
            width3_txt.Text = "";
            height3_txt.Text = "";

            MessageBox.Show("Image successfully resized!");
        }

        private void saveimg3Btn(object sender, EventArgs e)
        {
            SaveImage3();

        }

        private void filter1img3Btn(object sender, EventArgs e)
        {
            Reload3();
            Filter1_3();
        }

        private void filter2img3Btn(object sender, EventArgs e)
        {
            Reload3();
            Filter2_3();
        }

        private void filter3img3Btn(object sender, EventArgs e)
        {
            Reload3();
            grayscale3();
        }

        private void resetimg3Btn(object sender, EventArgs e)
        {
            Reload3();
        }
    }
}
