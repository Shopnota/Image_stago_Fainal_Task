using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                //ofd.Filter = "Image File (*.png)|.png";
                ofd.Title = "Please select a image file!!!!";
                ofd.Multiselect = false;

                string imgfile = "";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgfile = ofd.FileName;
                }


                Image image = Image.FromFile(imgfile);
                pictureBox1.Image = image;


                // string secret_message = "ABC";

                //char[] binary_secret_message = messageBinaryFormat(secret_message);

                Bitmap cover_image = new Bitmap(imgfile);
                //int W = cover_image.Width ;
                //int H = cover_image.Height;
                //int x = W / 2;
                //int y = H / 2;

                //cover_image.SetPixel(x, y, Color.Blue);



                for (int y = 0; y < 1; y++)
                {
                    for (int x = 0; x < cover_image.Width; x++)
                    {

                        cover_image.SetPixel(x, y, Color.Blue);
                    }
                }

                cover_image.Save(@"C:\Users\DCL\OneDrive\Desktop\Stego_FinalTask.png");

                MessageBox.Show("Complete!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
