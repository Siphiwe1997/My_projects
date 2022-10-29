using System;
using System.ComponentModel;
using System.Reflection;

namespace Project3
{
    public class ImageFormat
    {
        public string FormatName { get; set; }
        public string FileExtension { get; set; }
        public string MaxColours { get; set; }
        public MonochromeModes MonochromeModes { get; set; }
        public CompressionMethod CompressionMethod { get; set; }
        public CompressionType CompressionType { get; set; }

        public ImageFormat() { }

        private string ToDescription(Enum EnumValue)
        {
            FieldInfo fi = EnumValue.GetType().GetField(EnumValue.ToString());
            DescriptionAttribute da = Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return da == null ? EnumValue.ToString() : da.Description;
        }

        public override string ToString()
        {
            return FormatName + "; " + FileExtension + "; " + MaxColours + "; " + ToDescription(MonochromeModes) + "; " +
                ToDescription(CompressionMethod) + "; " + ToDescription(CompressionType) + "\n";
        }
    }
}
