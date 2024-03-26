using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using Emgu.CV.UI;
using MyBussines;
using static System.Net.Mime.MediaTypeNames;

namespace EditareAudioVideo1
{
    public partial class Form1 : Form
    {
       
        OpenFileDialog Openfile = new OpenFileDialog();
        Image<Bgr, Byte> My_Image;
        Filter myFilter=new Filter();
        double gamma1;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = myFilter.applyGray().ToBitmap();


        }

        private void histo_Click(object sender, EventArgs e)
        {
           

            if (Openfile.ShowDialog() == DialogResult.OK)
            {   My_Image= new Image<Bgr, byte>(Openfile.FileName);
                pictureBox2.Image = My_Image.ToBitmap();
                myFilter.showHisto(My_Image);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = myFilter.biasApp().ToBitmap();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Double.TryParse(gamma.Text, out double gamma1))
            {
                Image<Bgr, byte> imagine = new Image<Bgr, byte>("C:\\Users\\Andrei\\Desktop\\banana.bmp");
                imagine._GammaCorrect(gamma1);
                pictureBox1.Image = imagine.ToBitmap();

            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = myFilter.Rotate().ToBitmap();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=myFilter.Resize().ToBitmap();
        }
    }
}


         

   
