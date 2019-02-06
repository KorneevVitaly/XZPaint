using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XZPaint
{
    struct myPoint
    {
        public double x;
        public double y;
        public UInt32 color;
    }

    class Transform
    {
        static double[,] MatrixMultiplication(double[,] a, double[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            double[,] r = new double[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }

        static double[,] GetTranslationMatrix(double x, double y)
        {
            return new double[,]{   {1, 0, 0},
                                    {0, 1, 0},
                                    {x, y, 1}};
        }

        static double[,] GetRotationMatrix(double angle)
        {
            return new double[,]{   {Math.Cos(angle), Math.Sin(angle), 0},
                                    {-Math.Sin(angle), Math.Cos(angle), 0},
                                    {0, 0, 1}};
        }

        static double[,] GetScalingMatrix(double scaleX, double scaleY)
        {
            return new double[,]{   {scaleX, 0, 0},
                                    {0, scaleY, 0},
                                    {0, 0, 1}};
        }

        static double[,] GetReflectionMatrix(double angle)
        {
            return new double[,]{   {Math.Cos(2*angle), Math.Sin(2*angle), 0},
                                    {Math.Sin(2*angle), -Math.Cos(2*angle), 0},
                                    {0, 0, 1}};
        }

        static bool CheckLimit(int x, int y, int width, int height)
        {
            return (x >= 0 && x < width && y >= 0 & y < height) ? true : false;
        }

        static public UInt32[,] Move( UInt32[,] imageMatrix, int width, int height, int moveX, int moveY )
        {
            UInt32[,] newImage = new UInt32[height, width];
            for( int i = 0; i < height; i++ )
            {
                for( int j = 0; j < width; j++)
                {
                    newImage[i, j] = 0;
                }
            }

            double[,] translation = GetTranslationMatrix(moveX, moveY);

            for ( int i = 0; i < height; i++ )
            {
                for( int j = 0; j < width; j++ )
                {
                    UInt32 color = imageMatrix[i, j];
                    double[,] vector = { { j, i, 1 } };
                    double[,] result = MatrixMultiplication(vector, translation);

                    int x = (int)result[0, 0];
                    int y = (int)result[0, 1];
                    
                    if( CheckLimit(x, y, width, height) )
                    {
                        newImage[y, x] = color;
                    }
                }
            }

            return newImage;
        }

        static public UInt32[,] Rotate(UInt32[,] imageMatrix, int width, int height, double angle)
        {
            myPoint[,] imgDoubleCoord = new myPoint[height, width];
            UInt32[,] newImage = new UInt32[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    newImage[i, j] = 0;
                }
            }

            double[,] rotation = GetRotationMatrix(angle);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    double[,] vector = { { j-width/2, i-height/2, 1 } };
                    double[,] result = MatrixMultiplication(vector, rotation);
                    double[,] translation = GetTranslationMatrix(width / 2, height / 2);
                    result = MatrixMultiplication(result, translation);

                    double x = result[0, 0];
                    double y = result[0, 1];

                    int x0 = (int)Math.Floor(x);
                    int x1 = x0 + 1;
                    int y0 = (int)Math.Floor(y);
                    int y1 = y0 +1;

                    UInt32 color1 = 0, color2 = 0, color3 = 0, color4 = 0;
                    if (CheckLimit(x0, y0, width, height)) color1 = imageMatrix[y0, x0];
                    if (CheckLimit(x1, y0, width, height)) color2 = imageMatrix[y0, x1];
                    if (CheckLimit(x0, y1, width, height)) color3 = imageMatrix[y1, x0];
                    if (CheckLimit(x1, y1, width, height)) color4 = imageMatrix[y1, x1];

                    double dx = x - x0;
                    double dy = y - y0;

                    UInt32 resColor = (color1 + Convert.ToUInt32(dx) * (color2 - color1) + Convert.ToUInt32(dy) * (color3 - color1) + Convert.ToUInt32(dx) * Convert.ToUInt32(dy) * (color4 + color1 - color2 - color3));

                    newImage[i, j] = resColor;
                }
            }

            return newImage;
        }

        static public UInt32[,] Scale(UInt32[,] imageMatrix, int width, int height, double scaleX, double scaleY)
        {
            int newWidth = (int)(width * scaleX);
            int newHeight = (int)(height * scaleY);

            UInt32[,] newImage = new UInt32[newHeight, newWidth];
            for (int i = 0; i < newHeight; i++)
            {
                for (int j = 0; j < newWidth; j++)
                {
                    newImage[i, j] = 0;
                }
            }

            double[,] scaling = GetScalingMatrix(1 / scaleX, 1 / scaleY);

            for (int i = 0; i < newHeight; i++)
            {
                for (int j = 0; j < newWidth; j++)
                {
                    double[,] vector = { { j, i, 1 } };
                    double[,] result = MatrixMultiplication(vector, scaling);

                    double x = result[0, 0];
                    double y = result[0, 1];

                    int x0 = (int)Math.Floor(x);
                    int x1 = x0 + 1;
                    int y0 = (int)Math.Floor(y);
                    int y1 = y0 + 1;

                    UInt32 color1 = 0, color2 = 0, color3 = 0, color4 = 0;
                    if (CheckLimit(x0, y0, width, height)) color1 = imageMatrix[y0, x0];
                    if (CheckLimit(x1, y0, width, height)) color2 = imageMatrix[y0, x1];
                    if (CheckLimit(x0, y1, width, height)) color3 = imageMatrix[y1, x0];
                    if (CheckLimit(x1, y1, width, height)) color4 = imageMatrix[y1, x1];

                    double dx = x - x0;
                    double dy = y - y0;

                    UInt32 resColor = (color1 + Convert.ToUInt32(dx) * (color2 - color1) + Convert.ToUInt32(dy) * (color3 - color1) + Convert.ToUInt32(dx) * Convert.ToUInt32(dy) * (color4 + color1 - color2 - color3));

                    newImage[i, j] = resColor;
                }
            }

            return newImage;
        }

        static public UInt32[,] MirrorX(UInt32[,] imageMatrix, int width, int height)
        {
            UInt32[,] newImage = new UInt32[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    newImage[i, j] = 0;
                }
            }

            double[,] reflection = GetReflectionMatrix(Math.PI * 90 / 180.0);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    UInt32 color = imageMatrix[i, j];
                    double[,] vector = { { j - width / 2, i - height / 2, 1 } };
                    double[,] result = MatrixMultiplication(vector, reflection);
                    double[,] translation = GetTranslationMatrix(width / 2, height / 2);
                    result = MatrixMultiplication(result, translation);

                    double x = result[0, 0];
                    double y = result[0, 1];

                    int x0 = (int)Math.Floor(x);
                    int x1 = x0 + 1;
                    int y0 = (int)Math.Floor(y);
                    int y1 = y0 + 1;

                    UInt32 color1 = 0, color2 = 0, color3 = 0, color4 = 0;
                    if (CheckLimit(x0, y0, width, height)) color1 = imageMatrix[y0, x0];
                    if (CheckLimit(x1, y0, width, height)) color2 = imageMatrix[y0, x1];
                    if (CheckLimit(x0, y1, width, height)) color3 = imageMatrix[y1, x0];
                    if (CheckLimit(x1, y1, width, height)) color4 = imageMatrix[y1, x1];

                    double dx = x - x0;
                    double dy = y - y0;

                    UInt32 resColor = (color1 + Convert.ToUInt32(dx) * (color2 - color1) + Convert.ToUInt32(dy) * (color3 - color1) + Convert.ToUInt32(dx) * Convert.ToUInt32(dy) * (color4 + color1 - color2 - color3));

                    newImage[i, j] = resColor;
                }
            }

            return newImage;
        }
    }
}
