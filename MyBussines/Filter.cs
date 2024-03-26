using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.UI;
using System.Drawing;
using System.Diagnostics.Eventing.Reader;

namespace MyBussines
{      
    public class Filter
    {
        Image<Bgr, Byte> My_Image;
        Image<Bgr, Byte> editedImage;
        OpenFileDialog Openfile = new OpenFileDialog();
        HistogramViewer v = new HistogramViewer();

       

        public Image<Gray, byte> applyGray()
        {
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                My_Image = new Image<Bgr, byte>(Openfile.FileName);
                Image<Gray, byte> gray_image = My_Image.Convert<Gray, byte>();  
                 gray_image[0, 0] = new Gray(200);


                return gray_image;
            }
            return null;
        }

        public void showHisto(Image<Bgr,Byte> image)
        {
            v.HistogramCtrl.GenerateHistograms(image, 255);
            v.Show();

        }

        public Image<Bgr, byte> biasApp()
        {
            

            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                My_Image = new Image<Bgr, byte>(Openfile.FileName);

                for (int i = 0; i < My_Image.Width; i++)
                {
                    for (int j = 0; j < My_Image.Height; j++)
                    {
                        // Get the current pixel's color
                        Bgr currentColor = My_Image[j, i];

                        // Increase brightness by adding a value to each channel (R, G, B)
                        currentColor.Blue += 50; // Example: increase blue channel brightness by 50
                        currentColor.Green += 50; // Example: increase green channel brightness by 50
                        currentColor.Red += 50; // Example: increase red channel brightness by 50

                        // Set the modified color back to the pixel
                        My_Image[j, i] = currentColor;
                    }
                }
                return My_Image;
                    
            }
             return null;
             
        }

        public Image<Bgr, Byte> Rotate()
        {
           Bgr color= new Bgr(255, 255, 255);
            editedImage = My_Image.Rotate(30, color, true);
            return editedImage;

        }
        public Image<Bgr, Byte> Resize()
        {
            editedImage = My_Image.Resize(1, Emgu.CV.CvEnum.Inter.Cubic);
            return editedImage;


        }


    }
}
