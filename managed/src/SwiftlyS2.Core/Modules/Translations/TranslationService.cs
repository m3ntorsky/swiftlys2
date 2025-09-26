using System.Text.Json;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Core.Translations;

internal class TranslationService
{

  private ILogger<TranslationService> _Logger { get; init; }  
  private CoreContext _Context { get; init; }
  private TranslationResource _TranslationResource { get; set; }

  public TranslationService(ILogger<TranslationService> logger, CoreContext context)
  {
    _Logger = logger;
    _Context = context;

    var translationDir = Path.Combine(_Context.BaseDirectory, "translations");

    if (!Directory.Exists(translationDir)) {
      return;
    }

    _TranslationResource = TranslationFactory.Create(translationDir)!;
  }

  public Localizer GetLocalizer() {
    // TODO: Get server language
    var language = Language.English;
    return TranslationFactory.CreateLocalizer(_TranslationResource, language);
  }

  public Localizer GetPlayerLocalizer(IPlayer player)
  {
    return TranslationFactory.CreateLocalizer(_TranslationResource, player.PlayerLanguage);
  }
}