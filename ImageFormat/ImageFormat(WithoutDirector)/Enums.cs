//Siphiwe Ngubane
//2018530325
//CSIS2664 Project 3
//14-Aug-2022

using System.ComponentModel;

public enum CompressionMethod
{
    [Description("None, RLE")]NoneRLE, 
    LZW, 
    Deflate, 
    JPEG, 
    [Description("None, CCITT, LZW, JPEG")]NoneCcittLzwJpeg
}

public enum CompressionType
{
    Lossless, Lossy
}

public enum MonochromeModes
{
    None,
    [Description("2 colours")]TwoColours,
    [Description("2 colours, B&W")]TwoColoursBW,
    [Description("B&W")]BW, 
    
}
