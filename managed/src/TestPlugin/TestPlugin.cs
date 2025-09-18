using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.GameEventDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.Plugins;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace TestPlugin;


public class TestConfig {
  public string Name { get; set; }
  public int Age { get; set; }
}

public class TestPlugin : BasePlugin {

  public override string PluginId => "testplugin";

  public override string PluginName => "Test Plugin";

  public override string PluginVersion => "1.0.0";

  public override void ConfigureSharedServices(IServiceCollection sharedServices) {
    // Register plugin-specific services here if needed
  }

  public override void UseSharedServices(IServiceProvider sharedProvider) {
    // Use plugin-specific services here if needed
  }

  public override void Load(ISwiftlyCore core) {

    core.Event.OnTick += () => {
      Console.WriteLine("TestPlugin on tick");
    };

    var root = core.Configuration
      .InitializeJson<TestConfig>("test.jsonc")
      .Configure(builder => {
        builder.AddJsonFile("test.jsonc", optional: false, reloadOnChange: true);
      })
      .Root;

    var config = new TestConfig();

    var logger = core.LoggerFactory.CreateLogger<TestPlugin>();

    logger.LogInformation("TestPlugin jump loaded");


        CUtlStringToken token = new("hello");
        Console.WriteLine($"Hash: {token.HashCode}");
  }

  public override void Unload() {
    Console.WriteLine("TestPlugin unloaded");
  }
}