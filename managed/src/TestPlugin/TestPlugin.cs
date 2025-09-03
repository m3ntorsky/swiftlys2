using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Plugins;

namespace TestPlugin;

public class TestPlugin : BasePlugin {

  public override string PluginId => "test-plugin";

  public override string PluginName => "Test Plugin";

  public override string PluginVersion => "1.0.0";

  public override void ConfigureSharedServices(IServiceCollection sharedServices) {
    // Register plugin-specific services here if needed
  }

  public override void InjectSharedServices(IServiceProvider sharedProvider) {
    // Inject plugin-specific services here if needed
  }

  public override void Load(ISwiftlyCore core) {

    core.CustomEvents.OnTick += () => {
      Console.WriteLine("TestPlugin on tick");
    };

  }

  public override void Unload() {
    Console.WriteLine("TestPlugin unloaded");
  }
} 