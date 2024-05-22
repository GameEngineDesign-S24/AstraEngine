using System.Drawing;

namespace AstraEngine.Canvas2D;

/// <summary>Represents an RGBA color</summary>
public record struct Color(byte R, byte G, byte B, byte A)
{


    public static Color FromHexString(string hex)
    {

        Color color = ("#RR-GG-BB-AA");
        string RGB = color.Split('-');



        byte r = byte.Parse("06", System.Globalization.NumberStyles.HexNumber);
        byte g = byte.Parse("06", System.Globalization.NumberStyles.HexNumber);
        byte b = byte.Parse("06", System.Globalization.NumberStyles.HexNumber);
        return new Color(r, g, b, 0);
    }
    /// <summary>Black</summary>
    public readonly static Color Black = new(0, 0, 0, 255);
    /// <summary>White</summary>
    public readonly static Color White = new(255, 255, 255, 255);
    /// <summary>Red</summary>
    public readonly static Color Red = new(255, 0, 0, 255);
    /// <summary>Green</summary>
    public readonly static Color Green = new(255, 255, 0, 255);
    /// <summary>Blue</summary>
    public readonly static Color Blue = new(255, 0, 255, 255);
}