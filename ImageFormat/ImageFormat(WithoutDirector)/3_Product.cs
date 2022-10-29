using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
        

       /*https://stackoverflow.com/questions/4367723/get-enum-from-description-attribute */
        private string ToDescription(Enum EnumValue)
        {
            FieldInfo fi = EnumValue.GetType().GetField(EnumValue.ToString());
            DescriptionAttribute da = Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return da == null ? EnumValue.ToString() : da.Description;
        }

        public override string ToString()
        {
            return FormatName + "; " + FileExtension + "; " + MaxColours + "; " +ToDescription(MonochromeModes) + "; " + 
                ToDescription(CompressionMethod) + "; " +ToDescription(CompressionType)+ "\n";
        }
    }
}
