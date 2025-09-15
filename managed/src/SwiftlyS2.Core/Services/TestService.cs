using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Core.SchemaDefinitions;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Core.Services;

internal class TestService {

  private ILogger<TestService> _Logger { get; init; }
  private ProfileService _ProfileService { get; init; }
  public unsafe TestService(
    ILoggerFactory loggerFactory,
    ProfileService profileService
  ) {
    _Logger = loggerFactory.CreateLogger<TestService>();
    _ProfileService = profileService;


    Test();
  }

  

  public void Test()
  {
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

          CCSPlayerController player = new CCSPlayerControllerImpl(pRules);
          _Logger.LogInformation("player: " + player.PlayerName.Value);

          

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