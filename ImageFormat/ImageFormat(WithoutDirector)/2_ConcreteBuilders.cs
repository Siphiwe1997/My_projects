//Siphiwe Ngubane
//2018530325
//CSIS2664 Project 3
//14-Aug-2022

namespace Project3
{
    public abstract class AImageFormatBuilder : IImageFormatBuilder
    {
        protected ImageFormat imageFormat;
        public AImageFormatBuilder()
        {
            imageFormat = new ImageFormat();
            SetAttributes();
        }

        protected abstract void SetAttributes();

        public ImageFormat GetImageFormat()
        {
            return imageFormat;
        }
    }

    public class BMPBuilder : AImageFormatBuilder
    {
        public BMPBuilder() { }
        protected override void SetAttributes()
        {
            imageFormat.FormatName = "Bitmap";
            imageFormat.FileExtension = "bmp";
            imageFormat.MaxColours = "16M";
            imageFormat.MonochromeModes = MonochromeModes.TwoColours;
            imageFormat.CompressionMethod = CompressionMethod.NoneRLE;
            imageFormat.CompressionType = CompressionType.Lossless;
        }
    }

    public class GIFBuilder : AImageFormatBuilder
    {
        public GIFBuilder() { }
        protected override void SetAttributes()
        {
            imageFormat.FormatName = "Graphics Interchange Format";
            imageFormat.FileExtension = "gif";
            imageFormat.MaxColours = "256";
            imageFormat.MonochromeModes = MonochromeModes.TwoColours;
            imageFormat.CompressionMethod = CompressionMethod.LZW;
            imageFormat.CompressionType = CompressionType.Lossless;
        }
    }

    public class PNGBuilder : AImageFormatBuilder
    {
        public PNGBuilder() { }
        protected override void SetAttributes()
        {
            imageFormat.FormatName = "Portable Network Graphics";
            imageFormat.FileExtension = "png";
            imageFormat.MaxColours = "256T";
            imageFormat.MonochromeModes = MonochromeModes.TwoColoursBW;
            imageFormat.CompressionMethod = CompressionMethod.Deflate;
            imageFormat.CompressionType = CompressionType.Lossless;
        }
    }

    public class JPGBuilder : AImageFormatBuilder
    {
        public JPGBuilder() { }
        protected override void SetAttributes()
        {
            imageFormat.FormatName = "Joint Photographic Experts Group";
            imageFormat.FileExtension = "jpg";
            imageFormat.MaxColours = "16M";
            imageFormat.MonochromeModes = MonochromeModes.None;
            imageFormat.CompressionMethod = CompressionMethod.JPEG;
            imageFormat.CompressionType = CompressionType.Lossy;
        }
    }

    public class TIFFBuilder : AImageFormatBuilder
    {
        public TIFFBuilder() { }
        protected override void SetAttributes()
        {
            imageFormat.FormatName = "Tagged Image File";
            imageFormat.FileExtension = "tiff";
            imageFormat.MaxColours = "16M";
            imageFormat.MonochromeModes = MonochromeModes.BW;
            imageFormat.CompressionMethod = CompressionMethod.NoneCcittLzwJpeg;
            imageFormat.CompressionType = CompressionType.Lossless;
        }
    }
}
