using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace ImageProcessingProject
{
    internal class islemler
    {



        public Bitmap negative(Bitmap bitmap)

        {
            Bitmap sonuc = new Bitmap(bitmap.Width, bitmap.Height);
            Color ilk_renk, ikinci_renk;
            int r, g, b;



            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)


                {
                    ilk_renk = bitmap.GetPixel(i, j);
                    r = 255 - ilk_renk.R;
                    g = 255 - ilk_renk.G;
                    b = 255 - ilk_renk.B;
                    ikinci_renk = Color.FromArgb(r, g, b);
                    sonuc.SetPixel(i, j, ikinci_renk);


                }
            }
            return sonuc;
        }


       

















        public Bitmap parlaklik(Bitmap bitmap, int parlaklik_sayi)
        {
            Bitmap sonuc =  new Bitmap(bitmap.Width,bitmap.Height);
          //  int ton;
            Color color;
            Color color2;
            int r, g, b;
            for (int i = 0; i < bitmap.Width; i++)
            {

                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    if (color.R+parlaklik_sayi>255)
                    {
                        r = 255;


                    }
                    else if (color.R+parlaklik_sayi<0)
                    {
                        r =0;
                    }
                    else
                    {
                        r = color.R + parlaklik_sayi;
                    }


                    color = bitmap.GetPixel(i, j);
                    if (color.G + parlaklik_sayi > 255)
                    {
                        g = 255;


                    }
                    else if (color.G + parlaklik_sayi < 0)
                    {
                        g = 0;
                    }
                    else
                    {
                        g = color.G + parlaklik_sayi;
                    }

                    color = bitmap.GetPixel(i, j);
                    if (color.R + parlaklik_sayi > 255)
                    {
                        r = 255;


                    }
                    else if (color.R + parlaklik_sayi < 0)
                    {
                        r = 0;
                    }
                    else
                    {
                        r = color.R + parlaklik_sayi;
                    }



                    color = bitmap.GetPixel(i, j);
                    if (color.B + parlaklik_sayi > 255)
                    {
                        b = 255;


                    }
                    else if (color.B + parlaklik_sayi < 0)
                    {
                        b = 0;
                    }
                    else
                    {
                        b = color.B + parlaklik_sayi;
                    }

                    color2 = Color.FromArgb(r, g, b);
                    sonuc.SetPixel  (i, j, color2);


                }
            }
            return sonuc;

        }

        public Bitmap SiyahBeyaz(Bitmap bitmap, int esik)
        {
            Bitmap sonuc = new Bitmap(bitmap.Width,bitmap.Height);
          //  int ton;
            Color color;
            Color color2;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    if (color.R>=esik)
                    {
                        color2= Color.FromArgb(255,255,255);
                    }
                    else
                    {
                        color2= Color.FromArgb(0,0,0);
                    }

                    sonuc.SetPixel(i, j, color2);


                }
            }
            return sonuc;
           
        }


        

  



























        public Bitmap GriyeCevir(Bitmap bitmap)
        {
            Bitmap sonuc = new Bitmap(bitmap.Width, bitmap.Height);
            int ton;
            Color color;
            Color color2;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    ton = Convert.ToInt16(0.200 * color.R) + Convert.ToInt16(0.587 * color.G) + Convert.ToInt16(0.144 * color.B);
                    color2 = Color.FromArgb(ton, ton, ton);
                    sonuc.SetPixel(i, j, color2);
                }
            }
            return sonuc;
        } 
      }
    }

