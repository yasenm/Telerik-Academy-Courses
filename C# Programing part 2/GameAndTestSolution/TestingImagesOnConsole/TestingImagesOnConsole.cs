using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;

namespace TestingImagesOnConsole
{
    class TestingImagesOnConsole
    {
        static void Main()
        {

            //----------- Set console field, game field and score screen width and height.
            Console.WindowHeight = 50;
            Console.BufferHeight = 50;          // buffers should be equal to the value you want to set
            Console.WindowWidth = 100;          // for more convinience
            Console.BufferWidth = 100;
            
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            //----------- ImagePrinting algo
            Image picture = Image.FromFile(@"C:\Users\Yasen\Desktop\snakeWord2.jpg");
            Console.SetBufferSize((picture.Width * 0x2), (picture.Height * 0x2));
            FrameDimension dimension = new FrameDimension(picture.FrameDimensionsList[0x0]);
            int FrameCount = picture.GetFrameCount(dimension);
            int left = Console.WindowLeft, top = Console.WindowTop;
            char[] chars = { '#', '#', '@', '%', '=', '+', '*', ':', '-', '.', ' ' };
            picture.SelectActiveFrame(dimension, 0x0);
            for (int i = 0x0; i < picture.Height; i++)
            {
                for (int x = 0x0; x < picture.Width; x++)
                {
                    Color color = ((Bitmap)picture).GetPixel(x, i);
                    int black = (color.R + color.G + color.B) / 0x3;
                    int index = (black * (chars.Length - 0x1)) / 0xFF;
                    Console.Write(chars[index]);
                }
                Console.Write('\n');
            }
            Console.SetCursorPosition(left, top);
            Console.Read();
        }
    }
}
