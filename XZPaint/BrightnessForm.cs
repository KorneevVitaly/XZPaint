using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XZPaint
{
    public partial class BrightnessForm : Form
    {
        Form1 OwnerForm;
        public BrightnessForm(Form1 ownerForm)
        {
            this.OwnerForm = ownerForm;
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(BrightnessFormClosing);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            

            UInt32 p;
            for (int i = 0; i < Form1.bmp.Height; i++)
                for (int j = 0; j < Form1.bmp.Width; j++)
                {
                    p = BrightnessContrast.Brightness(Form1.pixel[i, j], trackBar1.Value, trackBar1.Maximum);
                    Form1.FromOnePixelToBitmap(i, j, p);
                }

            FromBitmapToScreen();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            UInt32 p;
            for (int i = 0; i < Form1.bmp.Height; i++)
                for (int j = 0; j < Form1.bmp.Width; j++)
                    {
                        p = BrightnessContrast.Contrast(Form1.pixel[i, j], trackBar2.Value, trackBar2.Maximum);
                        Form1.FromOnePixelToBitmap(i, j, p);
                    }

                FromBitmapToScreen();
        }


        //сохранение изменений яркости или контрастности
        private void button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.bmp.Height; i++)
                for (int j = 0; j < Form1.bmp.Width; j++)
                    Form1.pixel[i, j] = (UInt32)(Form1.bmp.GetPixel(j, i).ToArgb());
                trackBar1.Value = 0;
                trackBar2.Value = 0;
        }

        //вывод изображения на экран
        void FromBitmapToScreen()
        {
            OwnerForm.FromBitmapToScreen();
        }

        //обновление изображения в Bitmap и pictureBox при закрытии окна
        private void BrightnessFormClosing(object sender, System.EventArgs e)
        {
            Form1.FromPixelToBitmap();
                FromBitmapToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.bmp.Height; i++)
                for (int j = 0; j < Form1.bmp.Width; j++)
                    Form1.pixel[i, j] = (UInt32)(Form1.bmp.GetPixel(j, i).ToArgb());
                trackBar1.Value = 0;
                trackBar2.Value = 0;

            this.Close();
        }


    }
}
