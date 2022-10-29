//Siphiwe Ngubane

using System;

namespace Project3
{
    class Client
    {
        static void Main(string[] args)
        {
            //Black text on white background
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Director director = new Director();
            IImageFormatBuilder bmpBuilder = new BMPBuilder();
            director.DefineImageFormat(bmpBuilder);
            ImageFormat imageFormat1 = bmpBuilder.GetImageFormat();
            Console.WriteLine(imageFormat1);

            IImageFormatBuilder gifBuilder = new GIFBuilder();
            director.DefineImageFormat(gifBuilder);
            ImageFormat imageFormat2 = gifBuilder.GetImageFormat();
            Console.WriteLine(imageFormat2);

            IImageFormatBuilder pngBuilder = new PNGBuilder();
            director.DefineImageFormat(pngBuilder);
            ImageFormat imageFormat3 = pngBuilder.GetImageFormat();
            Console.WriteLine(imageFormat3);

            IImageFormatBuilder jpgbBuilder = new JPGBuilder();
            director.DefineImageFormat(jpgbBuilder);
            ImageFormat imageFormat4 = jpgbBuilder.GetImageFormat();
            Console.WriteLine(imageFormat4);

            IImageFormatBuilder tiffBuilder = new TIFFBuilder();
            director.DefineImageFormat(tiffBuilder);
            ImageFormat imageFormat5 = tiffBuilder.GetImageFormat();
            Console.WriteLine(imageFormat5);

            ////Exit application
            Console.Write("\n\tPress any key to exit ...");
            Console.ReadKey();
        }
    }
}
 