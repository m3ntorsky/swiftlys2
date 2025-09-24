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
using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.Memory;
using YamlDotNet.Core.Tokens;

namespace TestPlugin;


public class TestConfig {
  public string Name { get; set; }
  public int Age { get; set; }
}

public class TestPlugin : BasePlugin {

  public TestPlugin(ISwiftlyCore core) : base(core) {
  }

  public override void ConfigureSharedServices(IServiceCollection sharedServices) {
    // Register plugin-specific services here if needed
  }

  public override void UseSharedServices(IServiceProvider sharedProvider) {
    // Use plugin-specific services here if needed
  }

  CancellationTokenSource? token2 = null;

  delegate void Test(int a, int b);

  public override void Load() {
    // _Core = core;
    // var root = _Core.Configuration
    //   .InitializeJson<TestConfig>("test.jsonc") // generate addons/swiftly/configs/xxx/test.jsonc by type TestConfig if not exists
    //   .InitializeByTemplate("test2.jsonc", "test2.template.jsonc") 
    //   // copy addons/swiftly/plugins/xxx/templates/test2.template.jsonc to addons/swiftly/configs/xxx/test2.jsonc if not exists
    //   .Configure(builder => {
    //     builder.AddJsonFile("test.jsonc", optional: false, reloadOnChange: true);
    //   })
    //   .Root;

    // var config = new TestConfig();

    // throw new Exception("TestPlugin loaded");

    token2 = Core.Scheduler.AddTimer(10, () => {
      Console.WriteLine("TestPlugin Timer");
    });

    Core.Logger.LogInformation(Core.GameData.GetSignature("Test").ToString());



    Core.Logger.LogInformation("TestPlugin loaded");

    // var func = Core.Memory.GetUnmanagedFunctionByAddress<Test>(Core.Memory.GetAddressBySignature(Library.Server, "AAAAA")!.Value);
    
    // func.CallOriginal(1, 2);

    // func.Call(1, 2);

    // func.AddHook((next) => {
    //   return (a, b) => {
    //     Console.WriteLine("TestPlugin Hook " + a + " " + b);
    //     next()(a, b);
    //   };
    // });


    // Entrypoint

    // Core.Event.OnTick += () => {
    //   Console.WriteLine("TestPlugin OnTick ");
    // };

    // Core.Event.OnClientConnected += (@event) => {
    //   Console.WriteLine("TestPlugin OnClientConnected " + @event.PlayerId);
    // };

    // Core.Event.OnClientPutInServer += (@event) => {
    //   Console.WriteLine("TestPlugin OnClientPutInServer " + @event.PlayerId);
    // };

    Core.Event.OnClientDisconnected += (@event) => {
      Console.WriteLine("TestPlugin OnClientDisconnected " + @event.PlayerId);
    };

    // Core.Event.OnClientProcessUsercmds += (@event) => {
    //   foreach(var usercmd in @event.Usercmds) {
    //     usercmd.Base.ButtonsPb.Buttonstate1 &= 1UL << (int)GameButtons.Ctrl;
    //     usercmd.Base.ButtonsPb.Buttonstate2 &= 1UL << (int)GameButtons.Ctrl;
    //     usercmd.Base.ButtonsPb.Buttonstate3 &= 1UL << (int)GameButtons.Ctrl;
    //   }
    // };

    // Core.NetMessage.HookClientMessage<CCLCMsg_Move>((msg, id) => {
    //   Console.WriteLine("TestPlugin OnClientMove ");
    //   Console.WriteLine(BitConverter.ToString(msg.Data));
    //   return HookResult.Continue;
    // });

    // Core.Event.OnEntityTakeDamage += (@event) => {
    //   Console.WriteLine("TestPlugin OnEntityTakeDamage " + @event.Entity.Entity?.DesignerName + " " + @event.Info.HitGroupId);
    // };

    // Core.Event.OnTick += () => {

    //   Console.WriteLine("TestPlugin OnTick");
    // };

    // Core.Event.OnEntityCreated += (ev) => {
    //   var entity = ev.Entity;
    //   entity.Entity.DesignerName = "a";
    //   Console.WriteLine("TestPlugin OnEntityCreated " + ev.Entity.Entity?.DesignerName);
    // };


    using CEntityKeyValues kv = new();

    kv.SetBool("test", true);

    Console.WriteLine(kv.Get<bool>("test2"));


    CUtlStringToken token = new("hello");
    Console.WriteLine($"2");
  }

  CEntityKeyValues kv { get; set; }
  CEntityInstance entity { get; set; }


  [Command("tt")]
  public void TestCommand(ICommandContext context) {
    token2?.Cancel();
    // kv = new();
    // kv.SetString("test", "SAFE");



    // _Core.Logger.LogInformation("!@#");

    // _Core.Logger.LogInformation(_Core.GameData.GetSignature("CEntityInstance::AcceptInput").ToString());

    // entity = _Core.EntitySystem.CreateEntityByDesignerName<CPointWorldText>("point_worldtext");
    // entity.DispatchSpawn(kv);
    // Console.WriteLine("Spawned entity with keyvalues");

    var cvar = Core.ConVar.Find<bool>("sv_cheats")!;
    Console.WriteLine(cvar);
    Console.WriteLine(cvar.Value);
    var cvar2 = Core.ConVar.Find<bool>("sv_autobunnyhopping")!;
    Console.WriteLine(cvar2);
    Console.WriteLine(cvar2.Value);

    var cvar3 = Core.ConVar.Create<string>("sw_test_cvar", "Test cvar", "ABCDEFG");
    Console.WriteLine(cvar3);
    Console.WriteLine(cvar3.Value);

    var cvar4 = Core.ConVar.Find<bool>("r_drawworld")!;

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
    var dispatchspawn = Core.GameData.GetSignature("CBaseEntity::DispatchSpawn");
    /*Core.Hook.Hook<DispatchSpawnDelegate>(dispatchspawn, (next) => {
      return (nint pEntity, nint pKV) => {
        Console.WriteLine("TestPlugin DispatchSpawn " + order++);
        return next()(pEntity, pKV);
      };
    });*/
  }

  Guid _hookId = Guid.Empty;

  [Command("h2")]
  public void TestCommand3(ICommandContext context)
  {
    /*var dispatchspawn = Core.GameData.GetSignature("CBaseEntity::DispatchSpawn");
    _hookId = Core.Hook.Hook<DispatchSpawnDelegate>(dispatchspawn, (next) =>
    {
      return (nint pEntity, nint pKV) =>
      {
        Console.WriteLine("TestPlugin DispatchSpawn2 " + order++);
        return next()(pEntity, pKV);
      };
    });

    Core.Hook.Hook<DispatchSpawnDelegate>(dispatchspawn, (next) =>
    {
      return (nint pEntity, nint pKV) =>
      {
        var original  = next();
        Console.WriteLine("TestPlugin DispatchSpawn3 " + order++);
        return original(pEntity, pKV);
      };
    });*/
  }

  [Command("tt3")]
  public void TestCommand33(ICommandContext context) {

    var entity = Core.EntitySystem.CreateEntity<CPointWorldText>();
    entity.DispatchSpawn();
  }

  [Command("tt4")]
  public void TestCommand4(ICommandContext context) {
    //Core.Hook.Unhook(_hookId);
  }

  // [GameEventHandler(HookMode.Pre)]
  // public HookResult TestGameEventHandler(EventPlayerJump @e) {
  //   Console.WriteLine("TestPlugin GameEventHandler");
  //   return HookResult.Continue;
  // }

  [ServerNetMessageHandler]
  public HookResult TestServerNetMessageHandler(CCSUsrMsg_SendPlayerItemDrops msg) {

    Console.WriteLine("FIRED");
    // foreach(var item in msg.Accessor) {
    //   Console.WriteLine($"TestPlugin ServerNetMessageHandler: {item.EconItem.Defindex}");
    // }
    return HookResult.Continue;
  }

  public override void Unload() {
    Console.WriteLine("TestPlugin unloaded");
  }
}