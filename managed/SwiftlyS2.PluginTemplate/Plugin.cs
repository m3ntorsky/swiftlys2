using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Shared.Plugins;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Commands;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Plugin;

public class PluginClassName : BasePlugin {
  public override string PluginId => "PluginId";

  public override string PluginName => "PluginName";

  public override string PluginVersion => "PluginVersion";

  public override void ConfigureSharedServices(IServiceCollection sharedServices) {
  }

  public override void UseSharedServices(IServiceProvider sharedProvider) {
  }

  public override void Load(ISwiftlyCore core) {
  }

  public override void Unload() {
  }
} 