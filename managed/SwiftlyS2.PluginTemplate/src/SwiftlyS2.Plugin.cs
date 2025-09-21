using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Shared.Plugins;
using SwiftlyS2.Shared;

namespace SwiftlyS2.Plugin;

public partial class PluginClassName : BasePlugin {

  /// You can use this attribute to receive the core instance and assign it to a **static** field.
  /// or you can also get it through Load method parameter.
  [SwiftlyInject]
  private static ISwiftlyCore _Core = null!;

  public override void ConfigureSharedServices(IServiceCollection sharedServices) {
  }

  public override void UseSharedServices(IServiceProvider sharedProvider) {
  }

  public override void Load(ISwiftlyCore core)
  {
    // Check examples folder for more information. Don't forget to delete the folder after reading.
  }

  public override void Unload() {
  }
} 