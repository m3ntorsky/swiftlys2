using System.Text.Json;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Core.Translations;

internal class TranslationResource {
  public Dictionary<Language, Dictionary<string, string>> Resources { get; set; } = new();
}

internal class TranslationFactory
{

  /// <summary>
  /// Creates a new <see cref="TranslationResource"/> from the specified resource directory.
  /// </summary>
  /// <param name="resourceDir">The directory containing the translation files.</param>
  /// <returns>A <see cref="TranslationResource"/> containing the translation files.</returns>
  /// <exception cref="Exception">Thrown when the language is not recognized.</exception>
  public static TranslationResource Create(string resourceDir) {

    var resource = new TranslationResource();

    var translationFiles = Directory.GetFiles(resourceDir, "*.jsonc");

    foreach (var translationFile in translationFiles) {
      var language = Path.GetFileNameWithoutExtension(translationFile);
      if (!Language.RecognizedLanguages.Contains(language)) {
        throw new Exception($"Invalid language: {language}");
      }

      var options = new JsonSerializerOptions() {
        AllowTrailingCommas = true,
        ReadCommentHandling = JsonCommentHandling.Skip,
      };

      var translation = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(translationFile), options) ?? new();
      foreach (var translationEntry in translation) {
        translation[translationEntry.Key] = ReplaceColor(translationEntry.Value);
      }
      resource.Resources[new Language(language)] = translation;
    }

    if (resource.Resources.Count == 0) {
      throw new Exception("No translation files found.");
    }

    if (!resource.Resources.ContainsKey(Language.English)) {
      throw new Exception("English primary translation file not found.");
    }

    return resource;
  }

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

  private static string ReplaceColor(string original) {
    foreach (var color in ColorCodes) {
      original = original.Replace(color.Key, color.Value);
    }
    return original;
  }


  public static Localizer CreateLocalizer(TranslationResource resource, Language language) {

    var defaultResource = resource.Resources[Language.English];

    if (!resource.Resources.ContainsKey(language)) {
      return new Localizer(defaultResource, defaultResource);
    }

    return new Localizer(resource.Resources[language], defaultResource);
  }
}