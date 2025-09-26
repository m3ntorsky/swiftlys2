namespace SwiftlyS2.Core.Translations;

internal class Localizer
{
  private Dictionary<string, string> _Resource { get; init; }

  public Localizer(Dictionary<string, string> resource)
  {
    _Resource = resource;
  }

  public string this[string key] => _Resource[key];

  public string this[string key, params object[] args] => string.Format(this[key], args);
}