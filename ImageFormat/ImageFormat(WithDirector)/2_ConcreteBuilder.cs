//Siphiwe Ngubane

namespace Project3
{
    public abstract class AImageFormatBuilder : IImageFormatBuilder
    {
        protected ImageFormat imageFormat;
        public AImageFormatBuilder()
        {
            imageFormat = new ImageFormat();
      
        }

        public ImageFormat GetImageFormat()
        {
            return imageFormat;
        }

        public abstract void SetFormatName();
        public abstract void SeFileExtension();
        public abstract void SetColourProperties();
        public abstract void SetCompressionProperties();
    }

    public class BMPBuilder : AImageFormatBuilder
    {
        public BMPBuilder() { }


        public override void SetFormatName()
        {
            imageFormat.FormatName = "Bitmap";
        }

        public override void SeFileExtension()
        {
            imageFormat.FileExtension = "bmp";
        }

        public override void SetColourProperties()
        {
            imageFormat.MaxColours = "16M";
            imageFormat.MonochromeModes = MonochromeModes.TwoColours;
        }

        public override void SetCompressionProperties()
        {
            imageFormat.CompressionMethod = CompressionMethod.NoneRLE;
            imageFormat.CompressionType = CompressionType.Lossless;
        }

    }

    public class GIFBuilder : AImageFormatBuilder
    {
        public GIFBuilder() { }

        public override void SetFormatName()
        {
            imageFormat.FormatName = "Graphics Interchange Format";
        }

        public override void SeFileExtension()
        {
            imageFormat.FileExtension = "gif";
        }

        public override void SetColourProperties()
        {
            imageFormat.MaxColours = "256";
            imageFormat.MonochromeModes = MonochromeModes.TwoColours;
        }

        public override void SetCompressionProperties()
        {
            imageFormat.CompressionMethod = CompressionMethod.LZW;
            imageFormat.CompressionType = CompressionType.Lossless;
        }

    }

    public class PNGBuilder : AImageFormatBuilder
    {
        public PNGBuilder() { }

        public override void SetFormatName()
        {
            imageFormat.FormatName = "Portable Network Graphics";
        }

        public override void SeFileExtension()
        {
            imageFormat.FileExtension = "png";
        }

        public override void SetColourProperties()
        {
            imageFormat.MaxColours = "256T";
            imageFormat.MonochromeModes = MonochromeModes.TwoColours;
        }

        public override void SetCompressionProperties()
        {
            imageFormat.CompressionMethod = CompressionMethod.Deflate;
            imageFormat.CompressionType = CompressionType.Lossless;
        }
      
    }

    public class JPGBuilder : AImageFormatBuilder
    {
        public JPGBuilder() { }

        public override void SetFormatName()
        {
            imageFormat.FormatName = "Joint Photographic Experts Group";
        }

        public override void SeFileExtension()
        {
            imageFormat.FileExtension = "jpg";
        }

        public override void SetColourProperties()
        {
            imageFormat.MaxColours = "16M";
            imageFormat.MonochromeModes = MonochromeModes.None;
        }

        public override void SetCompressionProperties()
        {
            imageFormat.CompressionMethod = CompressionMethod.JPEG;
            imageFormat.CompressionType = CompressionType.Lossy;
        }

    }

    public class TIFFBuilder : AImageFormatBuilder
    {
        public TIFFBuilder() { }

        public override void SetFormatName()
        {
            imageFormat.FormatName = "Tagged Image File";
        }

        public override void SeFileExtension()
        {
            imageFormat.FileExtension = "tiff";
        }

        public override void SetColourProperties()
        {
            imageFormat.MaxColours = "16M";
            imageFormat.MonochromeModes = MonochromeModes.BW;
        }

        public override void SetCompressionProperties()
        {
            imageFormat.CompressionMethod = CompressionMethod.NoneCcittLzwJpeg;
            imageFormat.CompressionType = CompressionType.Lossless;
        }
    }
}
