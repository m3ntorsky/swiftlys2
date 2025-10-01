using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Shared.Plugins;
using SwiftlyS2.Shared;

namespace SwiftlyS2.Plugin;

public partial class PluginClassName : BasePlugin {
  public PluginClassName(ISwiftlyCore core) : base(core)
  {
  }

  public override void ConfigureSharedServices(IServiceCollection sharedServices) {
  }

  public override void UseSharedServices(IServiceProvider sharedProvider) {
  }

  public override void Load(bool hotReload) {
    
  }

  public override void Unload() {
  }
} 