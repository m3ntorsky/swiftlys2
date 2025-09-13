using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Plugins;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace TestPlugin;


public class TestConfig {
  public string Name { get; set; }
  public int Age { get; set; }
}

public class TestPlugin : BasePlugin {

  public override string PluginId => "test-plugin";

  public override string PluginName => "Test Plugin";

  public override string PluginVersion => "1.0.0";

  public override void ConfigureSharedServices(IServiceCollection sharedServices) {
    // Register plugin-specific services here if needed
  }

  public override void UseSharedServices(IServiceProvider sharedProvider) {
    // Use plugin-specific services here if needed
  }

  public override void Load(ISwiftlyCore core) {

    core.Events.OnTick += () => {
      Console.WriteLine("TestPlugin on tick");
    };

    var root = core.Configuration
      .InitializeJson<TestConfig>("test.json")
      .InitializeByTemplate("test2.json", "test2.template.json")
      .Configure(builder => {
        builder.AddJsonFile("test3.jsonc", optional: false, reloadOnChange: true);
        builder.AddYamlFile("test2.yaml", optional: false, reloadOnChange: true);
      })
      .Root;

    CCSPlayerController player = null!;
    CWeaponAWP awp = null!;

    var config = new TestConfig();
    core.Configuration.Root.GetSection("Test").Bind(config);


  
  }

  public override void Unload() {
    Console.WriteLine("TestPlugin unloaded");
  }
}