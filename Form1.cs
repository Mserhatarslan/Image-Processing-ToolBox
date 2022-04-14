
using System.Drawing;
using System.Text;
using System.Data;
using System.Buffers;
using System.Collections.Generic;


namespace ImageProcessingProject
{
    public partial class Form1 : Form

    {
        islemler islemler = new islemler();

        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog openFile = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {


            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);

            }
            // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //  openFileDialog1.ShowDialog();

            //  pictureBox1.ImageLocation = openFileDialog1.FileName;


        }
        private void OpenImageFile(PictureBox picBox, TextBox txtBox)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog2.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog2.FileName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Bitmap bitmap;
            bitmap = (Bitmap)pictureBox1.Image;

            Color color = bitmap.GetPixel(e.X, e.Y);
            pictureBox2.BackColor = color;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap asil_resim = (Bitmap)Image.FromFile(openFile.FileName);
            Bitmap gelen_resim = null;
            switch (comboBox4.SelectedItem)
            {
                case "gri":
                    gelen_resim = islemler.GriyeCevir((Bitmap)asil_resim);
                    break;
                case "esikleme":
                    gelen_resim = islemler.GriyeCevir((Bitmap)asil_resim);
                    gelen_resim = islemler.SiyahBeyaz((Bitmap)gelen_resim, 120);
                    break;
                case "parlaklik":
                    gelen_resim = islemler.parlaklik((Bitmap)asil_resim, trackBar1.Value);
                    break;
            }
            resultImage.Image = gelen_resim;

        }

        private void button6_Click(PictureBox picBox, TextBox txtBox)
        {
        }   
        private void button5_Click(object sender, EventArgs e, ComboBox cbRGBComponents)
        {
           // pictureBox3.Image = cbRGBComponents(pictureBox1, textBox1);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap gelen_resim =
            islemler.negative((Bitmap)pictureBox1.Image);
            resultImage.Image = gelen_resim;
        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            label2.Text = trackBar1.Value.ToString();
        }

        private void cbRGBComponents_Click(object sender, EventArgs e)
        {

        }

        private void cbRGBComponents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbArtificialImages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbRGBComponents_CheckedChanged(object sender, EventArgs e)
        {

        }

   
       private void btnRGBComponents_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        

        private void button8_Click(PictureBox picBox, TextBox txtBox)
        {
           
        }

        private void rrbRGBComponents_CheckedChanged(object sender, EventArgs e)
        {
            if (rrbRGBComponents.Checked)
                ccbRGBComponents.Enabled = true;
            else
                ccbRGBComponents.Enabled = false;

        }

        private void rrbArtificialImages_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ccbRGBComponents_SelectedIndexChanged(object sender, EventArgs e)
        {            
       }

        private void ccbArtificialImages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RRGBComponents_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = System.IO.Path.GetFileName(openFileDialog1.FileName)+ " (" + pictureBox1.Width + " x " + pictureBox1.Height + ")";
        }

       

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        private Bitmap RGABBComponents(PictureBox picBox, TextBox txtBox)
        {
            Color rgbColor, newColor; int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage; inputImage = new Bitmap(picBox.Image); int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            resultImage = new Bitmap(imageWidth, imageHeight);

            int newR = 0, newG = 0, newB = 0; for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);

                    if (rbRGBComponents.Checked)
                    {
                        switch (cbRGBComponents.SelectedIndex)
                        {
                            case 0:
                                newR = rgbColor.R; newG = newB = 0; break;
                            case 1:
                                newG = rgbColor.G; newR = newB = 0; break;
                            case 2:
                                newB = rgbColor.B; newR = newG = 0; break;
                        }
                    }
                    else if (rbArtificialImages.Checked)
                    {
                        switch (cbArtificialImages.SelectedIndex)
                        {
                            case 0:
                                newR = rgbColor.R; newG = rgbColor.G; newB = rgbColor.B; break;
                            case 1:
                                newR = rgbColor.R; newG = rgbColor.B; newB = rgbColor.G; break;
                            case 2:
                                newR = rgbColor.G; newG = rgbColor.R; newB = rgbColor.B; break;
                            case 3:
                                newR = rgbColor.G; newG = rgbColor.B; newB = rgbColor.R; break;
                            case 4:
                                newR = rgbColor.B; newG = rgbColor.R; newB = rgbColor.G; break;
                            case 5:
                                newR = rgbColor.B; newG = rgbColor.G; newB = rgbColor.R; break;
                        }
                    }

                    R = newR; G = newG; B = newB; newColor = Color.FromArgb(R, G, B); resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")"; return resultImage;
        }

     

       

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (rbArticialImage.Checked)
                cbArtificialImage.Enabled = true;
            else
                cbArtificialImage.Enabled = false;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            // pictureBox3.Image = btnRGBComponents_Click(pictureBox3, txtBox);
            resultImage.Image = RGBComponents(pictureBox1, txtBox);

        }


        private Bitmap RGBComponents(PictureBox picBox, TextBox txtBox)
        {
            Color rgbColor, newColor; int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage; inputImage = new Bitmap(picBox.Image); int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            resultImage = new Bitmap(imageWidth, imageHeight);

            int newR = 0, newG = 0, newB = 0; for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y);

                    if (radioButton5.Checked)
                    {
                        switch (comboBox1.SelectedIndex)
                        {
                            case 0:
                                newR = rgbColor.R; newG = newB = 0; break;
                            case 1:
                                newG = rgbColor.G; newR = newB = 0; break;
                            case 2:
                                newB = rgbColor.B; newR = newG = 0; break;
                        }
                    }
                    else if (rbArticialImage.Checked)
                    {
                        switch (cbArtificialImage.SelectedIndex)
                        {
                            case 0:
                                newR = rgbColor.R; newG = rgbColor.G; newB = rgbColor.B; break;
                            case 1:
                                newR = rgbColor.R; newG = rgbColor.B; newB = rgbColor.G; break;
                            case 2:
                                newR = rgbColor.G; newG = rgbColor.R; newB = rgbColor.B; break;
                            case 3:
                                newR = rgbColor.G; newG = rgbColor.B; newB = rgbColor.R; break;
                            case 4:
                                newR = rgbColor.B; newG = rgbColor.R; newB = rgbColor.G; break;
                            case 5:
                                newR = rgbColor.B; newG = rgbColor.G; newB = rgbColor.R; break;
                        }
                    }

                    R = newR; G = newG; B = newB; newColor = Color.FromArgb(R, G, B); resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")"; return resultImage;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                comboBox1.Enabled = true;
            else
                comboBox1.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            resultImage.Image = ColorToGrayscale(pictureBox1, txtBox);

        }

        private Bitmap ColorToGrayscale(PictureBox picBox, TextBox txtBox)
        {
            Color rgbColor, grayColor; int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage; inputImage = new Bitmap(picBox.Image); int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            resultImage = new Bitmap(imageWidth, imageHeight);

            int Gray = 0;
            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y); if (rbSimpleAverage.Checked)
                    {
                        Gray = Convert.ToInt16((rgbColor.R + rgbColor.G + rgbColor.B) / 3);
                    }
                    else if (rbWeightedAverage.Checked)
                    {
                        switch (cbWeightedAverage.SelectedIndex)
                        {
                            case 0:
                                Gray = Convert.ToInt16(0.299 * rgbColor.R + 0.587 * rgbColor.G + 0.114 * rgbColor.B);
                                break;
                            case 1:
                                Gray = Convert.ToInt16(0.2126 * rgbColor.R + 0.7152 * rgbColor.G + 0.0722 * rgbColor.B); break;
                            case 2:
                                Gray = Convert.ToInt16(0.3 * rgbColor.R + 0.59 * rgbColor.G + 0.11 * rgbColor.B); break;
                        }
                    }
                    else if (rbDesaturation.Checked)
                    {
                        Gray = (Math.Max(Math.Max(rgbColor.R, rgbColor.G), rgbColor.B) + Math.Min(Math.Min(rgbColor.R,
                        rgbColor.G), rgbColor.B)) / 2;
                    }
                    else if (rbDecomposition.Checked)
                    {
                        switch (cbDecomposition.SelectedIndex)
                        {
                            case 0:
                                Gray = Math.Max(Math.Max(rgbColor.R, rgbColor.G), rgbColor.B); break;
                            case 1:
                                Gray = Math.Min(Math.Min(rgbColor.R, rgbColor.G), rgbColor.B);
                                break;
                        }
                    }
                    else if (rbSingleColorChannel.Checked)
                    {
                        switch (cbSingleColorChannel.SelectedIndex)
                        {
                            case 0:
                                Gray = rgbColor.R; break;
                            case 1:
                                Gray = rgbColor.G; break;
                            case 2:
                                Gray = rgbColor.B; break;
                        }




}

                    R = G = B = Gray;
                    grayColor = Color.FromArgb(R, G, B); resultImage.SetPixel(x, y, grayColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")"; return resultImage;
        }



        private Bitmap ArithmeticOperationsWithConstant(PictureBox picBox, TextBox txtConst, TextBox txtBox)
        {
            Color rgbColor, newColor; int R = 0, G = 0, B = 0;
            Bitmap inputImage, resultImage; inputImage = new Bitmap(picBox.Image); int imageWidth = inputImage.Width;
            int imageHeight = inputImage.Height;
            int constant = Convert.ToInt32(textBox7.Text); resultImage = new Bitmap(imageWidth, imageHeight);

            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y); switch (cbWithConstant.SelectedIndex)
                    {
                        case 0:
                            R = rgbColor.R + constant; G = rgbColor.G + constant; B = rgbColor.B + constant; break;
                        case 1:
                            R = rgbColor.R - constant; G = rgbColor.G - constant; B = rgbColor.B - constant; break;
                        case 2:
                            R = rgbColor.R * constant; G = rgbColor.G * constant; B = rgbColor.B * constant; break;
                        case 3:
                            R = rgbColor.R / constant; G = rgbColor.G / constant; B = rgbColor.B / constant; break;
                    }
                    R = Math.Max(Math.Min(R, 255), 0);
                    G = Math.Max(Math.Min(G, 255), 0);
                    B = Math.Max(Math.Min(B, 255), 0); newColor = Color.FromArgb(R, G, B); resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")";
            return resultImage;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //  pictureBox3.Image = ArithmeticOperationsWithConstant();
            resultImage.Image = ArithmeticOperationsWithConstant(pictureBox1, txtBlendPercent, txtBox);
           // resultImage.Image = LogicOperations(pictureBox1, pictureBox2, txtBox);



        }

        private Image ArithmeticOperationsWithConstant(PictureBox pictureBox1, object picBox, PictureBox pictureBox2, object picBoxSecond, TextBox textBox1, TextBox txtBlendPercent, TextBox textBox2, TextBox txtBox)
        {
            throw new NotImplementedException();
        }

        private Bitmap ArithmeticOperationsWithImage(PictureBox picBox, PictureBox picBoxSecond, TextBox txtBlendPercent, TextBox txtBox)
        {
            Color rgbColor, rgbSecondColor, newColor; int R = 0, G = 0, B = 0;
            Bitmap inputImage, inputSecondImage, resultImage; inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width; int imageHeight = inputImage.Height;
            inputSecondImage = new Bitmap(picBoxSecond.Image);
            int imageSecondWidth = inputSecondImage.Width; int imageSecondHeight = inputSecondImage.Height;
            float blendPercent = Convert.ToSingle(txtBlendPercent.Text) / 100; resultImage = new Bitmap(imageWidth, imageHeight);

            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y); rgbSecondColor = inputSecondImage.GetPixel(x, y); switch (cbWithImage.SelectedIndex)
                    {
                        case 0:
                            R = rgbColor.R + rgbSecondColor.R; G = rgbColor.G + rgbSecondColor.G; B = rgbColor.B + rgbSecondColor.B; break;
                        case 1:
                            R = rgbColor.R - rgbSecondColor.R; G = rgbColor.G - rgbSecondColor.G; B = rgbColor.B - rgbSecondColor.B; break;
                        case 2:
                            R = rgbColor.R * rgbSecondColor.R; G = rgbColor.G * rgbSecondColor.G; B = rgbColor.B * rgbSecondColor.B; break;
                        case 3:
                            R = rgbColor.R / Math.Max(Convert.ToInt32(rgbSecondColor.R), 1); G = rgbColor.G / Math.Max(Convert.ToInt32(rgbSecondColor.G), 1); B = rgbColor.B / Math.Max(Convert.ToInt32(rgbSecondColor.B), 1); break;
                        case 4:
                            R = Convert.ToInt32(rgbColor.R * blendPercent + rgbSecondColor.R * (1 - blendPercent)); G = Convert.ToInt32(rgbColor.G * blendPercent + rgbSecondColor.G * (1 - blendPercent)); B = Convert.ToInt32(rgbColor.B * blendPercent + rgbSecondColor.B * (1 - blendPercent)); break;
                    }
                    R = Math.Max(Math.Min(R, 255), 0);
                    G = Math.Max(Math.Min(G, 255), 0);
                    B = Math.Max(Math.Min(B, 255), 0); newColor = Color.FromArgb(R, G, B); resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")"; return resultImage;
        }


        private Bitmap LogicOperations(PictureBox picBox, PictureBox picBoxSecond, TextBox txtBox)
        {
            Color rgbColor, rgbSecondColor, newColor; int R = 0, G = 0, B = 0;
            Bitmap inputImage, inputSecondImage, resultImage;
            inputImage = new Bitmap(picBox.Image);
            int imageWidth = inputImage.Width; int imageHeight = inputImage.Height;
            inputSecondImage = new Bitmap(picBoxSecond.Image); int imageSecondWidth = inputSecondImage.Width;
            int imageSecondHeight = inputSecondImage.Height; resultImage = new Bitmap(imageWidth, imageHeight);

            for (int x = 0; x < imageWidth; x++)
            {
                for (int y = 0; y < imageHeight; y++)
                {
                    rgbColor = inputImage.GetPixel(x, y); rgbSecondColor = inputSecondImage.GetPixel(x, y); if (rbAnd.Checked)
                    {
                        R = rgbColor.R & rgbSecondColor.R; G = rgbColor.G & rgbSecondColor.G; B = rgbColor.B & rgbSecondColor.B;
                    }
                    else if (rbOr.Checked)
                    {
                        R = rgbColor.R | rgbSecondColor.R; G = rgbColor.G | rgbSecondColor.G; B = rgbColor.B | rgbSecondColor.B;
                    }
                    else if (rbXor.Checked)
                    {
                        R = rgbColor.R ^ rgbSecondColor.R; G = rgbColor.G ^ rgbSecondColor.G; B = rgbColor.B ^ rgbSecondColor.B;
                    }
                    else if (rbNand.Checked)
                    {
                        R = 255 - (rgbColor.R & rgbSecondColor.R); G = 255 - (rgbColor.G & rgbSecondColor.G); B = 255 - (rgbColor.B & rgbSecondColor.B);
                    }
                    else if (rbNor.Checked)
                    {
                        R = 255 - (rgbColor.R | rgbSecondColor.R); G = 255 - (rgbColor.G | rgbSecondColor.G); B = 255 - (rgbColor.B | rgbSecondColor.B);
                    }
                    else if (rbXNor.Checked)
                    {
                        R = 255 - (rgbColor.R ^ rgbSecondColor.R); G = 255 - (rgbColor.G ^ rgbSecondColor.G); B = 255 - (rgbColor.B ^ rgbSecondColor.B);
                    }
                    else if (rbNot.Checked)
                    {
                        R = 255 - rgbColor.R; G = 255 - rgbColor.G; B = 255 - rgbColor.B;
                    }
                    R = Math.Max(Math.Min(R, 255), 0);
                    G = Math.Max(Math.Min(G, 255), 0);
                    B = Math.Max(Math.Min(B, 255), 0); newColor = Color.FromArgb(R, G, B); resultImage.SetPixel(x, y, newColor);
                }
            }
            txtBox.Text = "ResultImage (" + resultImage.Width + " x " + resultImage.Height + ")"; return resultImage;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            resultImage.Image = LogicOperations(pictureBox1, pictureBox2, txtBox);
        }
    }
}


