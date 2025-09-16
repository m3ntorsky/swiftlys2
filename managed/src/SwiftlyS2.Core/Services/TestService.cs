using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Core.SchemaDefinitions;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Core.Services;

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

          CBaseEntity ent = new CBaseEntityImpl(pRules);
          
          Stopwatch sw = Stopwatch.StartNew();
          for (int i = 0; i < 100000; i++) {
            CCSPlayerController player = ent.As<CCSPlayerController>();
          }
          sw.Stop();
          _Logger.LogInformation("Time taken: " + sw.ElapsedMilliseconds + "ms");

          

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