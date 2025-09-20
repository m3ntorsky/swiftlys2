using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Commands;
using SwiftlyS2.Shared.GameEventDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.Plugins;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.ProtobufDefinitions;
using System.Diagnostics.CodeAnalysis;

namespace TestPlugin;


public class TestConfig {
  public string Name { get; set; }
  public int Age { get; set; }
}

public class TestPlugin : BasePlugin {

  [SwiftlyInject]
  [NotNull]
  private static ISwiftlyCore? _Core = null!;

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
    // _Core = core;
    var root = _Core.Configuration
      .InitializeJson<TestConfig>("test.jsonc")
      .Configure(builder => {
        builder.AddJsonFile("test.jsonc", optional: false, reloadOnChange: true);
      })
      .Root;

    var config = new TestConfig();


    using CEntityKeyValues kv = new();

    kv.SetBool("test", true);

    Console.WriteLine(kv.Get<bool>("test2"));


    CUtlStringToken token = new("hello");
    Console.WriteLine($"Hash: {token.HashCode}");
  }

  CEntityKeyValues kv { get; set; }
  CEntityInstance entity { get; set; }

  [Command("tt")]
  public void TestCommand(ICommandContext context) {
    // kv = new();
    // kv.SetString("test", "SAFE");



    // _Core.Logger.LogInformation("!@#");

    // _Core.Logger.LogInformation(_Core.GameData.GetSignature("CEntityInstance::AcceptInput").ToString());

    // entity = _Core.EntitySystem.CreateEntityByDesignerName<CPointWorldText>("point_worldtext");
    // entity.DispatchSpawn(kv);
    // Console.WriteLine("Spawned entity with keyvalues");

    _Core.EntitySystem.GetAllEntitiesByClass<CVoteController>().ToList().ForEach((entity) => {
      Console.WriteLine(entity.Entity.DesignerName.Value);
    });
  }

  [Command("tt2")]
  public void TestCommand2(ICommandContext context) {
    entity.Despawn();
    Console.WriteLine("Deleted entity");
  }

  [Command("tt3")]
  public void TestCommand3(ICommandContext context) {

    Console.WriteLine("Accessing keyvalues after entity deleted (This should be fine)");
    Console.WriteLine(kv.GetString("test"));
    Console.WriteLine("Releasing keyvalues");
    kv.Dispose();
    Console.WriteLine("Releasing successful");
    Console.WriteLine("Accessing keyvalues after releasing (This should be crashing)");
    Console.WriteLine(kv.GetString("test"));
  }

  // [GameEventHandler(HookMode.Pre)]
  // public HookResult TestGameEventHandler(EventPlayerJump @e) {
  //   Console.WriteLine("TestPlugin GameEventHandler");
  //   return HookResult.Continue;
  // }

  // [ServerNetMessageHandler]
  // public HookResult TestServerNetMessageHandler(CMsgSosStartSoundEvent msg, CRecipientFilter filter) {
  //   Console.WriteLine($"TestPlugin ServerNetMessageHandler: {msg.SoundeventHash}");
  //   return HookResult.Continue;
  // }

  public override void Unload() {
    Console.WriteLine("TestPlugin unloaded");
  }
}