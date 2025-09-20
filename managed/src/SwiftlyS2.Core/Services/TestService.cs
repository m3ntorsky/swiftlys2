using System.Buffers;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Core.SchemaDefinitions;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.GameEventDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Core.Services;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate nint DispatchSpawnHook(nint entity, nint kv);

internal class TestService {

  private ILogger<TestService> _Logger { get; init; }
  private ProfileService _ProfileService { get; init; }
  private ISwiftlyCore _Core { get; init; }
  public unsafe TestService(
    ILogger<TestService> logger,
    ProfileService profileService,
    ISwiftlyCore core
  ) {
    _ProfileService = profileService;
    _Core = core;
    _Logger = logger;

    Test();
  }

  private DispatchSpawnHook callback;

  private DispatchSpawnHook callback2;


  public T SetCallback<T>(nint hook, Func<Func<T>, T> callbackGetter) where T : Delegate
  {
    return callbackGetter(() => {
      var originalPtr = NativeHooks.GetHookOriginal(hook);
      var original = Marshal.GetDelegateForFunctionPointer<T>(originalPtr);
      return original;
    });

  }


  public void Test()
  {
    // try {

    //   _Core.GameEvent.HookPre<EventTest>((@event) => {
    //   throw new Exception("WTF");
    //   return false;
    // });


    // } catch (Exception e) {
    //   _Logger.LogError(e, "");
    // }



    // var addr = _Core.GameData.GetSignature("CBaseEntity::DispatchSpawn");
    // _Logger.LogInformation("addr: " + addr);
    // var hook = NativeHooks.AllocateHook();
    // List<Delegate> hooks = new();

    // var callback = SetCallback<DispatchSpawnHook>(hook, (originalFuncGetter) =>
    // {
    //   return (nint entity, nint kv) =>
    //   {
    //     Console.WriteLine("DispatchSpawnHook " + entity);
    //     var originalFunc = originalFuncGetter();
    //     originalFunc(entity, kv);
    //     return 0;
    //   };
    // });
    // var callbackAddr = Marshal.GetFunctionPointerForDelegate(callback);
    // NativeHooks.SetHook(hook, addr, callbackAddr);
    // NativeHooks.EnableHook(hook);


    
    // var hook2 = NativeHooks.AllocateHook();
    // var callback2 = SetCallback<DispatchSpawnHook>(hook2, (originalFuncGetter) =>
    // {
    //   return (nint entity, nint kv) =>
    //   {
    //     Console.WriteLine("DispatchSpawnHook2 " + entity);
    //     return originalFuncGetter()(entity, kv);
    //   };
    // });
    // var callbackAddr2 = Marshal.GetFunctionPointerForDelegate(callback2); 
    // NativeHooks.SetHook(hook2, addr, callbackAddr2);
    // NativeHooks.EnableHook(hook2);





    _Core.GameEvent.HookPre<EventPlayerTeam>((eventObj) =>
    {
      Console.WriteLine(eventObj.GetHashCode());
      Console.WriteLine("EventPlayerJump " + eventObj.UserIdController.PlayerPawn.Value);
      return HookResult.Continue;
    });

    _Core.Command.RegisterCommand("test", (context) =>
    {
      Console.WriteLine(context.Prefix);
      Console.WriteLine("test");
    });

    _Core.Command.RegisterCommandAlias("sw_test", "test2");

    _Core.Command.HookClientCommand((playerId, commandLine) =>
    {
      Console.WriteLine("ClientCommandHook " + playerId);
      Console.WriteLine("ClientCommandHook " + commandLine);
      return HookResult.Continue;
    });

    _Core.Command.HookClientChat((playerId, text, teamonly) =>
    {
      Console.WriteLine("ClientChatHook " + playerId);
      Console.WriteLine("ClientChatHook " + text);
      Console.WriteLine("ClientChatHook " + teamonly);
      return HookResult.Continue;
    });


    // _Core.NetMessage.HookServerMessage<CMsgSosStartSoundEvent>((msg, filter) =>
    // {
    //   msg.PackedParams = new byte[0];
    //   Console.WriteLine("CMsgSosStartSoundEvent " + msg.PackedParams.Length);
    //   Console.WriteLine("CMsgSosStartSoundEvent " + msg.SoundeventHash);
    //   Console.WriteLine("CMsgSosStartSoundEvent " + msg.SourceEntityIndex);
    //   Console.WriteLine("CMsgSosStartSoundEvent " + msg.Seed);
    //   Console.WriteLine("CMsgSosStartSoundEvent " + msg.StartTime);
    //   using var shake = _Core.NetMessage.Create<CUserMessageShake>();
    //   shake.Duration = 10;
    //   shake.Amplitude = 10;
    //   shake.Frequency = 10;
    //   shake.Command = 0;

    //   // GC.Collect();

    //   // shake.SendToPlayer(0);
      
    //   return HookResult.Continue;
    // });

    Task.Run(async () =>
    {
      while (true)
      {
        try {
        await Task.Delay(2000);
        unsafe
        {

          _ProfileService.StartRecording("TestService");

          var pRules = (nint)NativeTest.Test();
          _Logger.LogInformation("pPlayer: "+ pRules.ToString());
          if (pRules == nint.Zero)
          {
            continue;
          }


          CCSPlayerController ent = new CCSPlayerControllerImpl(pRules);

          Console.WriteLine(ent.PlayerPawn.Value?.CBodyComponent?.SceneNode?.AbsOrigin);
          ent.Clan.Value = "testtt";
          ent.ClanUpdated();

            // _Core.GameEvent.FireToPlayer<EventShowSurvivalRespawnStatus>(0, eventObj => {
            //   eventObj.Duration = 10;
            //   eventObj.LocToken = "testtt";
            // });









          unsafe {

            // NativeEntitySystem.Despawn((void*)player.PlayerPawn.Value.GetHandle(), "SetScale", null, null, true, 0);
            // var handle = NativeSounds.CreateSoundEvent();
            // NativeSounds.AddAllClients(handle);
            // NativeSounds.SetName(handle, "Weapon_AK47.Single");
            // NativeSounds.SetFloat(handle, "public.volume", 5.0f);
            // NativeSounds.SetSourceEntityIndex(handle, (int)player.PlayerPawn.EntityIndex);
            // NativeSounds.Emit(handle);


            }


          _ProfileService.StopRecording("TestService");

          }
        } catch (Exception e) {
          _Logger.LogError(e, "");
        }
      }
    });
  }
}