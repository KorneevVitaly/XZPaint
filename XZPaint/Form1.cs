using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XZPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmb_PenSize.SelectedIndex = 0;
        }

        public static Bitmap _bitmapbeforeProcessing;


        bool press = false;
        int x1, y1;
        int w1, h1;
        Point one1, one2;
        Color Current = Color.Black;
        int Tolshina = 1;

        public static Bitmap bmp = new Bitmap(720, 414);

        public ToolStripMenuItem cZoom;

        public Image IMAA;
        public Size OriginalImageSize;
        public Size ModifiedImageSize;

        public static UInt32[,] pixel;


        int Rel(int[,] mas)
        {
            int sum = 0;
            int[,] relbef = new int[,] { { -2, -1, 0 }, { -1, 1, 1 }, { 0, 1, 2 } };
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    sum += mas[i, j] * relbef[i, j];
                }
            }
            if (sum < 0) sum = 0;
            if (sum > 255) sum = 255;
            return sum;
        }



        private void btn_PenColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                
                btn_PenColor.BackColor = c.Color;
                Current = c.Color;
            }
        }

        private void btn_CanvasColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btn_CanvasColor.BackColor = c.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bit2 = new Bitmap(720, 414);
            pictureBox1.BackColor = Color.White;
            pictureBox1.Width = 720;
            pictureBox1.Height = 414;
            pictureBox1.Image = bit2;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op = openFileDialog1;
            op.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bmp = new Bitmap(op.FileName);

                    IMAA = Image.FromFile(op.FileName);
                    OriginalImageSize = new Size(IMAA.Width, IMAA.Height);


                    _bitmapbeforeProcessing = new Bitmap(op.FileName);
                    this.pictureBox1.Size = bmp.Size;
                    pictureBox1.Image = bmp;
                    pictureBox1.Invalidate();
                    //получение матрицы с пикселями
                    pixel = new UInt32[bmp.Height, bmp.Width];
                    for (int y = 0; y < bmp.Height; y++)
                        for (int x = 0; x < bmp.Width; x++)
                            pixel[y, x] = (UInt32)(bmp.GetPixel(x, y).ToArgb());
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            Bitmap bit2 = new Bitmap(720, 414);
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = bit2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.radioBrush, "Brush");
            toolTip1.SetToolTip(this.radioLine, "Line");
            toolTip1.SetToolTip(this.radioRect, "Rectangle");
            toolTip1.SetToolTip(this.radioFilRect, "Filled Rectangle");
            toolTip1.SetToolTip(this.radioElipse, "Ellipse");
            toolTip1.SetToolTip(this.radioFillCir, "Filled Ellipse");
            toolTip1.SetToolTip(this.radioFill, "Fill");
            toolTip1.SetToolTip(this.radioEraser, "Eraser");
            
            
            
            Bitmap BTMP = new Bitmap(720, 414);
            Graphics graph = Graphics.FromImage(BTMP);
            Rectangle ImageSize = new Rectangle(0, 0, 720, 414);
            graph.FillRectangle(Brushes.White, ImageSize);
            pictureBox1.Image = BTMP;

            Bitmap temp = (Bitmap)pictureBox1.Image;
            Bitmap bmap = (Bitmap)temp.Clone();

            pixel = new UInt32[bmap.Height, bmap.Width];
            for (int y = 0; y < bmap.Height; y++)
                for (int x = 0; x < bmap.Width; x++)
                    pixel[y, x] = (UInt32)(bmap.GetPixel(x, y).ToArgb());


            pictureBox1.Image = (Bitmap)bmap.Clone();
            bmp = (Bitmap)bmap.Clone();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (press)
            {
                one2 = e.Location;

                if (radioBrush.Checked)
                {
                    g.DrawLine(new Pen(Current, Tolshina), one1, one2);
                    one1 = one2;
                }
                if (radioEraser.Checked)
                {
                    g.DrawLine(new Pen(btn_CanvasColor.BackColor, Tolshina), one1, one2);
                    one1 = one2;
                }
                pictureBox1.Refresh();

            }
            g.Save();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen MyPen = new Pen(Current, Tolshina);
            SolidBrush MyBrush = new SolidBrush(btn_CanvasColor.BackColor);
            Color newCol = btn_CanvasColor.BackColor;

            if (press)
            {
                x1 = Math.Min(one1.X, one2.X);
                y1 = Math.Min(one1.Y, one2.Y);
                w1 = Math.Abs(one1.X - one2.X);
                h1 = Math.Abs(one1.Y - one2.Y);

                if (radioElipse.Checked)
                {
                    e.Graphics.DrawEllipse(MyPen, x1, y1, w1, h1);
                }
                if (radioFillCir.Checked)
                {
                    e.Graphics.DrawEllipse(MyPen, x1, y1, w1, h1);
                }
                if(radioRect.Checked)
                {
                    e.Graphics.DrawRectangle(MyPen, x1, y1, w1, h1);
                }
                if (radioFilRect.Checked)
                {
                    e.Graphics.DrawRectangle(MyPen, x1, y1, w1, h1);
                }
                if(radioLine.Checked)
                {
                    e.Graphics.DrawLine(MyPen, one1, one2);
                }
                if (radioFill.Checked) {   }
                
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen MyPen = new Pen(Current, Tolshina);            
            SolidBrush MyBrush = new SolidBrush(btn_CanvasColor.BackColor);
            
            press = false;
            Graphics g = Graphics.FromImage(pictureBox1.Image);

            if (radioEraser.Checked)
            {
                MyPen = new Pen(btn_CanvasColor.BackColor, Tolshina);
            }
            if (radioElipse.Checked)
            {
                g.DrawEllipse(MyPen, x1, y1, w1, h1);
            }
            if (radioFillCir.Checked)
            {
                Rectangle rect = new Rectangle(x1, y1, w1, h1);
                g.FillEllipse(MyBrush, rect);
                g.DrawEllipse(MyPen, x1, y1, w1, h1);
            }
            if (radioRect.Checked)
            {
                g.DrawRectangle(MyPen, x1, y1, w1, h1);
            }
            if (radioFilRect.Checked)
            {
                Rectangle rect = new Rectangle(x1, y1, w1, h1);
                g.FillRectangle(MyBrush, rect);
                g.DrawRectangle(MyPen, x1, y1, w1, h1);
            }
            if (radioLine.Checked)
            {
                g.DrawLine(MyPen, one1, one2);
            }
            g.Save();



            Bitmap temp = (Bitmap)pictureBox1.Image;
            Bitmap bmap = (Bitmap)temp.Clone();

            pixel = new UInt32[bmap.Height, bmap.Width];
            for (int y = 0; y < bmap.Height; y++)
                for (int x = 0; x < bmap.Width; x++)
                    pixel[y, x] = (UInt32)(bmap.GetPixel(x, y).ToArgb());


            pictureBox1.Image = (Bitmap)bmap.Clone();
            bmp = (Bitmap)bmap.Clone();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            press = true;
            one1 = e.Location;
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            Bitmap bit2 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = bit2;
            bmp = bit2;
        }

        private void cmb_PenSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tolshina = Convert.ToInt32(cmb_PenSize.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "PNG (*.png)|*.png|JPEG (*.jpeg)|*.jpeg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(dlg.FileName);
            }
        }

        private void rotate90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1;
            bitmap1 = (Bitmap)pictureBox1.Image;
            bitmap1.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = bitmap1;
            bmp = (Bitmap)bitmap1.Clone();
            IMAA = pictureBox1.Image;
            OriginalImageSize = new Size(IMAA.Width, IMAA.Height);
        }

        private void mirrorXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1;
            bitmap1 = (Bitmap)pictureBox1.Image;
            bitmap1.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = bitmap1;
            bmp = (Bitmap)bitmap1.Clone();
            IMAA = pictureBox1.Image;
        }

        private void mirrorYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1;
            bitmap1 = (Bitmap)pictureBox1.Image;
            bitmap1.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = bitmap1;
            bmp = (Bitmap)bitmap1.Clone();
            IMAA = pictureBox1.Image;
        }


        private void brightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrightnessForm BF = new BrightnessForm(this);
            BF.ShowDialog();
        }

        private void colorBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceForm ColorBalanceForm = new BalanceForm(this);
            ColorBalanceForm.ShowDialog();
        }

        private void colorSharpeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox1.Image;
            pixel = Filter.matrix_filtration(bmp.Width, bmp.Height, pixel, Filter.N1, Filter.sharpness);
            FromPixelToBitmap();
            FromBitmapToScreen();
        }

        private void bluurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)pictureBox1.Image;
            pixel = Filter.matrix_filtration(bmp.Width, bmp.Height, pixel, Filter.N2, Filter.blur);
            FromPixelToBitmap();
            FromBitmapToScreen();
        }

        //преобразование из UINT32 to Bitmap
        public static void FromPixelToBitmap()
        {
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    _bitmapbeforeProcessing = bmp;
                    bmp.SetPixel(x, y, Color.FromArgb((int)pixel[y, x]));
                }
        }

        //преобразование из UINT32 to Bitmap по одному пикселю
        public static void FromOnePixelToBitmap(int x, int y, UInt32 pixel)
        {
            bmp.SetPixel(y, x, Color.FromArgb((int)pixel));
        }

        //вывод на экран
        public void FromBitmapToScreen()
        {
            pictureBox1.Image = bmp;
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)pictureBox1.Image;
            Bitmap bmap = (Bitmap)temp.Clone();

            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    bmap.SetPixel(i, j, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }

            pixel = new UInt32[bmap.Height, bmap.Width];
            for (int y = 0; y < bmap.Height; y++)
                for (int x = 0; x < bmap.Width; x++)
                    pixel[y, x] = (UInt32)(bmap.GetPixel(x,y).ToArgb());


            pictureBox1.Image = (Bitmap)bmap.Clone();
            bmp = (Bitmap)bmap.Clone();
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)pictureBox1.Image;
            Bitmap bmap = (Bitmap)temp.Clone();

            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);
                    bmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }

            pixel = new UInt32[bmap.Height, bmap.Width];
            for (int y = 0; y < bmap.Height; y++)
                for (int x = 0; x < bmap.Width; x++)
                    pixel[y, x] = (UInt32)(bmap.GetPixel(x, y).ToArgb());


            pictureBox1.Image = (Bitmap)bmap.Clone();
            bmp = (Bitmap)bmap.Clone();
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeForm SIFO = new SizeForm(this);
            SIFO.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (radioFill.Checked)
            {
                if ((one1.X > 0 && one1.Y > 0) && 
                    (one1.X<pictureBox1.Image.Width && one1.X<pictureBox1.Image.Height))
                {
                    Color oldC = (pictureBox1.Image as Bitmap).GetPixel(one1.X, one1.Y);
                    if (radioFill.Checked)
                    {
                        SkaFloodFill((Bitmap)pictureBox1.Image, one1, oldC, Current);
                    }
                }                
            }
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap originBitmap;
            originBitmap = (Bitmap)pictureBox1.Image;
            pixel = new UInt32[originBitmap.Height, originBitmap.Width];
            for (int y = 0; y < originBitmap.Height; y++)
                for (int x = 0; x < originBitmap.Width; x++)
                    pixel[y, x] = (UInt32)(originBitmap.GetPixel(x, y).ToArgb());

            pixel = Transform.Move(pixel, originBitmap.Width, originBitmap.Height, 10, 10);
            for( int i = 0; i < originBitmap.Height; i++)
            {
                for( int j = 0; j < originBitmap.Width; j++ )
                {
                    originBitmap.SetPixel(j, i, Color.FromArgb((int)pixel[i, j]));
                }
            }
            
            pictureBox1.Image = originBitmap;
        }

        private void rotateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap originBitmap;
            originBitmap = (Bitmap)pictureBox1.Image;
            pixel = new UInt32[originBitmap.Height, originBitmap.Width];
            for (int y = 0; y < originBitmap.Height; y++)
                for (int x = 0; x < originBitmap.Width; x++)
                    pixel[y, x] = (UInt32)(originBitmap.GetPixel(x, y).ToArgb());

            pixel = Transform.Rotate(pixel, originBitmap.Width, originBitmap.Height, DegreeToRadian(15) );
            for (int i = 0; i < originBitmap.Height; i++)
            {
                for (int j = 0; j < originBitmap.Width; j++)
                {
                    originBitmap.SetPixel(j, i, Color.FromArgb((int)pixel[i, j]));
                }
            }

            pictureBox1.Image = originBitmap;
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double scaleX = 2;
            double scaleY = 2;
            Bitmap originBitmap;
            originBitmap = (Bitmap)pictureBox1.Image;
            int newWidth = Convert.ToInt32(Convert.ToDouble(originBitmap.Width) * scaleX);
            int newHeight = Convert.ToInt32(Convert.ToDouble(originBitmap.Height) * scaleY);
            if (originBitmap.Width % 2 != 0) --newWidth;
            if (originBitmap.Height % 2 != 0) --newHeight;
            UInt32[,] pixel = new UInt32[originBitmap.Height, originBitmap.Width];
            for (int y = 0; y < originBitmap.Height; y++)
            {
                for (int x = 0; x < originBitmap.Width; x++)
                {
                    pixel[y, x] = (UInt32)(originBitmap.GetPixel(x, y).ToArgb());
                }
            }

            Bitmap newBitmap = new Bitmap(newWidth, newHeight);
            pixel = Transform.Scale(pixel, originBitmap.Width, originBitmap.Height, scaleX, scaleY);
            for (int i = 0; i < newBitmap.Height; i++)
            {
                for (int j = 0; j < newBitmap.Width; j++)
                {
                    newBitmap.SetPixel(j, i, Color.FromArgb((int)pixel[i, j]));
                }
            }

            pictureBox1.Image = newBitmap;
            pictureBox1.Width = newBitmap.Width;
            pictureBox1.Height = newBitmap.Height;
        }

        private void mirrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap originBitmap;
            originBitmap = (Bitmap)pictureBox1.Image;
            pixel = new UInt32[originBitmap.Height, originBitmap.Width];
            for (int y = 0; y < originBitmap.Height; y++)
                for (int x = 0; x < originBitmap.Width; x++)
                    pixel[y, x] = (UInt32)(originBitmap.GetPixel(x, y).ToArgb());

            pixel = Transform.MirrorX(pixel, originBitmap.Width, originBitmap.Height);
            for (int i = 0; i < originBitmap.Height; i++)
            {
                for (int j = 0; j < originBitmap.Width; j++)
                {
                    originBitmap.SetPixel(j, i, Color.FromArgb((int)pixel[i, j]));
                }
            }

            pictureBox1.Image = originBitmap;
        }        

        private void SkaFloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            targetColor = bmp.GetPixel(pt.X, pt.Y);
            if (targetColor.ToArgb().Equals(replacementColor.ToArgb()))
            {
                return;
            }

            Stack<Point> pixels = new Stack<Point>();

            pixels.Push(pt);
            while (pixels.Count != 0)
            {
                Point temp = pixels.Pop();
                int y1 = temp.Y;
                while (y1 >= 0 && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    y1--;
                }
                y1++;
                bool spanLeft = false;
                bool spanRight = false;
                while (y1 < bmp.Height && bmp.GetPixel(temp.X, y1) == targetColor)
                {
                    bmp.SetPixel(temp.X, y1, replacementColor);

                    if (!spanLeft && temp.X > 0 && bmp.GetPixel(temp.X - 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X - 1, y1));
                        spanLeft = true;
                    }
                    else if (spanLeft && temp.X - 1 == 0 && bmp.GetPixel(temp.X - 1, y1) != targetColor)
                    {
                        spanLeft = false;
                    }
                    if (!spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) == targetColor)
                    {
                        pixels.Push(new Point(temp.X + 1, y1));
                        spanRight = true;
                    }
                    else if (spanRight && temp.X < bmp.Width - 1 && bmp.GetPixel(temp.X + 1, y1) != targetColor)
                    {
                        spanRight = false;
                    }
                    y1++;
                }

            }
            pictureBox1.Refresh();

        }

        private void stampingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)pictureBox1.Image;
            Bitmap bmap = (Bitmap)temp.Clone();

            Bitmap a = new Bitmap(pictureBox1.Image);
            Bitmap b = new Bitmap(pictureBox1.Image);
            int[,] masR = new int[3, 3];
            int[,] masG = new int[3, 3];
            int[,] masB = new int[3, 3];
            int str = 0, stlb = 0;
            for (int i = 1; i < a.Width - 1; i++)
            {
                for (int j = 1; j < a.Height - 1; j++)
                {
                    str = 0;
                    stlb = 0;
                    for (int k = j - 1; k < j + 2; k++)
                    {
                        for (int l = i - 1; l < i + 2; l++)
                        {
                            masR[str, stlb] = a.GetPixel(l, k).R;
                            masG[str, stlb] = a.GetPixel(l, k).G;
                            masB[str, stlb] = a.GetPixel(l, k).B;
                            stlb++;
                        }
                        str++;
                        stlb = 0;
                    }
                    str = 0;
                    stlb = 0;
                    b.SetPixel(i, j, Color.FromArgb(Rel(masR), Rel(masG), Rel(masB)));
                }
            }
            pictureBox1.Image = b;
            bmp = b;
        }

        private void aquarelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap temp = (Bitmap)pictureBox1.Image;
            Bitmap bmap = (Bitmap)temp.Clone();

            bmap = Aqua(bmap);
            
            pictureBox1.Image = (Bitmap)bmap.Clone();
            bmp = (Bitmap)bmap.Clone();

        }

        public static Bitmap Aqua(Image loadImage)
        {
            Bitmap bimp = new Bitmap(loadImage);

            int levels = 25;
            int filterSize = 9;
            BitmapData sourceData =
                            bimp.LockBits(new Rectangle(0, 0,
                                bimp.Width, bimp.Height),
                                ImageLockMode.ReadOnly,
                                PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            bimp.UnlockBits(sourceData);

            int[] intensityBin = new int[levels];
            int[] blueBin = new int[levels];
            int[] greenBin = new int[levels];
            int[] redBin = new int[levels];

            levels = levels - 1;

            int filterOffset = (filterSize - 1) / 2;
            int byteOffset = 0;
            int calcOffset = 0;
            int currentIntensity = 0;
            int maxIntensity = 0;
            int maxIndex = 0;

            double blue = 0;
            double green = 0;
            double red = 0;

            for (int offsetY = filterOffset; offsetY < bimp.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < bimp.Width - filterOffset; offsetX++)
                {
                    blue = green = red = 0;

                    currentIntensity = maxIntensity = maxIndex = 0;

                    intensityBin = new int[levels + 1];
                    blueBin = new int[levels + 1];
                    greenBin = new int[levels + 1];
                    redBin = new int[levels + 1];

                    byteOffset = offsetY *
                    sourceData.Stride + offsetX * 4;

                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset +
                            (filterX * 4) +
                            (filterY * sourceData.Stride);

                            currentIntensity = (int)Math.Round(((double)
                            (pixelBuffer[calcOffset] +
                            pixelBuffer[calcOffset + 1] +
                            pixelBuffer[calcOffset + 2]) / 3.0 *
                            (levels)) / 255.0);

                            intensityBin[currentIntensity] += 1;
                            blueBin[currentIntensity] += pixelBuffer[calcOffset];
                            greenBin[currentIntensity] += pixelBuffer[calcOffset + 1];
                            redBin[currentIntensity] += pixelBuffer[calcOffset + 2];

                            if (intensityBin[currentIntensity] > maxIntensity)
                            {
                                maxIntensity = intensityBin[currentIntensity];
                                maxIndex = currentIntensity;
                            }
                        }
                    }

                    blue = blueBin[maxIndex] / maxIntensity;
                    green = greenBin[maxIndex] / maxIntensity;
                    red = redBin[maxIndex] / maxIntensity;

                    resultBuffer[byteOffset] = (byte)(blue > 255 ? 255 :
                    (blue < 0 ? 0 : blue));

                    resultBuffer[byteOffset + 1] = (byte)(green > 255 ? 255 :
                    (green < 0 ? 0 : green));

                    resultBuffer[byteOffset + 2] = (byte)(red > 255 ? 255 :
                    (red < 0 ? 0 : red));

                    resultBuffer[byteOffset + 3] = 255;

                }
            }

            Bitmap resultBitmap = new Bitmap(bimp.Width, bimp.Height);

            BitmapData resultData =
                resultBitmap.LockBits(new Rectangle(0, 0,
                    resultBitmap.Width, resultBitmap.Height),
                    ImageLockMode.WriteOnly,
                    PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }
    }
}
