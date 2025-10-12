using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared;

public static class Helper
{

  private static readonly Dictionary<string, string> ColorCodes = new()
  {
    { "[default]", "\x01" },
    { "[/]", "\x01" },
    { "[white]", "\x01" },
    { "[darkred]", "\x02" },
    { "[lightpurple]", "\x03" },
    { "[green]", "\x04" },
    { "[olive]", "\x05" },
    { "[lime]", "\x06" },
    { "[red]", "\x07" },
    { "[gray]", "\x08" },
    { "[grey]", "\x08" },
    { "[lightyellow]", "\x09" },
    { "[yellow]", "\x09" },
    { "[silver]", "\x0A" },
    { "[bluegrey]", "\x0A" },
    { "[lightblue]", "\x0B" },
    { "[blue]", "\x0B" },
    { "[darkblue]", "\x0C" },
    { "[purple]", "\x0E" },
    { "[magenta]", "\x0E" },
    { "[lightred]", "\x0F" },
    { "[gold]", "\x10" },
    { "[orange]", "\x10" }
  };

  public enum ChatColors
  {
    Default = "[/]",
    White = "[white]",
    DarkRed = "[darkred]",
    Green = "[green]",
    LightYellow = "[lightyellow]",
    LightBlue = "[lightblue]",
    Olive = "[olive]",
    Lime = "[lime]",
    Red = "[red]",
    LightPurple = "[lightpurple]",
    Purple = "[purple]",
    Grey = "[grey]",
    Yellow = "[yellow]",
    Gold = "[gold]",
    Silver = "[silver]",
    Blue = "[blue]",
    DarkBlue = "[darkblue]",
    BlueGrey = "[bluegrey]",
    Magenta = "[magenta]",
    LightRed = "[lightred]",
    Orange = "[orange]",
  }

  /// <summary>
  /// Replace the color codes in the text with the corresponding color codes.
  /// </summary>
  /// <param name="text">The text to replace the color codes in.</param>
  /// <returns>The text with the color codes replaced.</returns>
  public static string Colored(this string text)
  {
    if (text.StartsWith("["))
      text = " " + text;

    foreach (var color in ColorCodes)
    {
      text = text.Replace(color.Key, color.Value);
    }

    return text;
  }

  /// <summary>
  /// Convert the pointer to the schema class.
  /// </summary>
  /// <typeparam name="T">The schema class to convert to.</typeparam>
  /// <param name="ptr">The pointer to the schema class.</param>
  /// <returns>The schema class.</returns>
  public static T AsSchema<T>(nint ptr) where T : ISchemaClass<T>
  {
    return T.From(ptr);
  }
}