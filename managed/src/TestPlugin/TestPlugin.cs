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
using System.Runtime.InteropServices;

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

    var cvar = _Core.ConVar.Find<bool>("sv_cheats")!;
    Console.WriteLine(cvar);
    Console.WriteLine(cvar.Value);
    var cvar2 = _Core.ConVar.Find<bool>("sv_autobunnyhopping")!;
    Console.WriteLine(cvar2);
    Console.WriteLine(cvar2.Value);

    var cvar3 = _Core.ConVar.Create<string>("sw_test_cvar", "Test cvar", "ABCDEFG");
    Console.WriteLine(cvar3);
    Console.WriteLine(cvar3.Value);

    var cvar4 = _Core.ConVar.Find<bool>("r_drawworld")!;

    cvar2.ReplicateToClient(0, true);

    cvar4.QueryClient(0, (value) => {
      Console.WriteLine("QueryCallback " +value);
    });
  }

  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  delegate nint DispatchSpawnDelegate(nint pEntity, nint pKV);
  int order = 0;

  [Command("h1")]
  public void TestCommand2(ICommandContext context)
  {
    var dispatchspawn = _Core.GameData.GetSignature("CBaseEntity::DispatchSpawn");
    _Core.Hook.Hook<DispatchSpawnDelegate>(dispatchspawn, (next) => {
      return (nint pEntity, nint pKV) => {
        Console.WriteLine("TestPlugin DispatchSpawn " + order++);
        return next()(pEntity, pKV);
      };
    });
  }

  Guid _hookId = Guid.Empty;

  [Command("h2")]
  public void TestCommand3(ICommandContext context)
  {
    var dispatchspawn = _Core.GameData.GetSignature("CBaseEntity::DispatchSpawn");
    _hookId = _Core.Hook.Hook<DispatchSpawnDelegate>(dispatchspawn, (next) =>
    {
      return (nint pEntity, nint pKV) =>
      {
        Console.WriteLine("TestPlugin DispatchSpawn2 " + order++);
        return next()(pEntity, pKV);
      };
    });

    _Core.Hook.Hook<DispatchSpawnDelegate>(dispatchspawn, (next) =>
    {
      return (nint pEntity, nint pKV) =>
      {
        var original  = next();
        Console.WriteLine("TestPlugin DispatchSpawn3 " + order++);
        return original(pEntity, pKV);
      };
    });
  }

  [Command("tt3")]
  public void TestCommand33(ICommandContext context) {

    var entity = _Core.EntitySystem.CreateEntity<CPointWorldText>();
    entity.DispatchSpawn();
  }

  [Command("tt4")]
  public void TestCommand4(ICommandContext context) {
    _Core.Hook.Unhook(_hookId);
  }

  // [GameEventHandler(HookMode.Pre)]
  // public HookResult TestGameEventHandler(EventPlayerJump @e) {
  //   Console.WriteLine("TestPlugin GameEventHandler");
  //   return HookResult.Continue;
  // }

  [ServerNetMessageHandler]
  public HookResult TestServerNetMessageHandler(CCSUsrMsg_SendPlayerLoadout msg) {
    Console.WriteLine("FIRED");
    foreach(var item in msg.Loadout) {
      Console.WriteLine($"TestPlugin ServerNetMessageHandler: {item.EconItem.Defindex}");
    }
    return HookResult.Continue;
  }

  public override void Unload() {
    Console.WriteLine("TestPlugin unloaded");
  }
}