//Siphiwe Ngubane
//2018530325
//CSIS2664 Project 3
//14-Aug-2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //List of formats
            List<ImageFormat> lstFormats = new List<ImageFormat>();
            lstFormats.Add(new BMPBuilder().GetImageFormat());
            lstFormats.Add(new GIFBuilder().GetImageFormat());
            lstFormats.Add(new PNGBuilder().GetImageFormat());
            lstFormats.Add(new JPGBuilder().GetImageFormat());
            lstFormats.Add(new TIFFBuilder().GetImageFormat());
            //List all formats
            foreach (ImageFormat format in lstFormats)
                Console.WriteLine("\t" + format);
            //Exit application
            Console.Write("\n\tPress any key to exit ...");
            Console.ReadKey();
        }
    }
}
