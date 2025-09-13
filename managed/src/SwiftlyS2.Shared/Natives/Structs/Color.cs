using System.Drawing;
using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Sequential, Size = 4)]
public struct Color {
  public byte R;
  public byte G;
  public byte B;
  public byte A;

  public Color(byte r, byte g, byte b, byte a) {
    R = r;
    G = g;
    B = b;
    A = a;
  }

  public Color(byte r, byte g, byte b) : this(r, g, b, 255) {
  }

  public Color(char r, char g, char b, char a) : this((byte)r, (byte)g, (byte)b, (byte)a) {
  }

  public Color(char r, char g, char b) : this((byte)r, (byte)g, (byte)b, 255) {
  }

  public static Color FromBuiltin(System.Drawing.Color color) {
    return new Color(color.R, color.G, color.B, color.A);
  }

  public System.Drawing.Color ToBuiltin() {
    return System.Drawing.Color.FromArgb(A, R, G, B);
  }

  public static Color FromHex(string hex) {
    if (hex.StartsWith("#")) {
      hex = hex.Substring(1);
    }
    if (hex.Length == 6) {
      return new Color((byte)int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber), (byte)int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber), (byte)int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber), 255);
    }
    if (hex.Length == 8) {
      return new Color((byte)int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber), (byte)int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber), (byte)int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber), (byte)int.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber));
    }
    throw new ArgumentException("Hex color must be 6 or 8 characters long.");
  }

  public string ToHex(bool includeAlpha = false) {
    return $"#{R:X2}{G:X2}{B:X2}{(includeAlpha ? $"{A:X2}" : "")}";
  }

  public override string ToString() {
    return $"Color({R}, {G}, {B}, {A})";
  }

  public int ToInt32() {
    return (R << 24) | (G << 16) | (B << 8) | A;
  }

  public static Color FromInt32(int color) {
    return new Color((byte)(color >> 24), (byte)(color >> 16), (byte)(color >> 8), (byte)color);
  }
}