//Siphiwe Ngubane

namespace Project3
{
    class Director
    {
        public void DefineImageFormat(IImageFormatBuilder imageFormatBuilder)
        {
            imageFormatBuilder.SetFormatName();
            imageFormatBuilder.SeFileExtension();
            imageFormatBuilder.SetColourProperties();
            imageFormatBuilder.SetCompressionProperties();
        }
    }
}
