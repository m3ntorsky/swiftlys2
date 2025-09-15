using System.Buffers;
using System.Diagnostics;
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
          // if (pRules == nint.Zero)
          // {
          //   continue;
          // }

          NativeHandle h = new(pRules);

          var pool = ArrayPool<byte>.Shared;
          var buffer = pool.Rent(32);
          // _Logger.LogError("account: "+ player.InGameMoneyServices!.Account);
          // _Logger.LogError("connected: " + player.Connected);
          // _Logger.LogError("mins: " + player.Collision?.Mins.ToString());  
          // _Logger.LogError("maxs: " + player.Collision?.Maxs.ToString());
          // _Logger.LogError("steamid: " + player.SteamID);
          // _Logger.LogError("pawn: " + player.PlayerPawn.IsValid);
          // if (player.PlayerPawn.IsValid) {
          //   _Logger.LogError("pawn: " + player.PlayerPawn.Value?.CBodyComponent?.SceneNode?.AbsOrigin.ToString());
          // }

            // for (int i = 0; i < player.PlayerName.ElementCount; i++) {
            //   Console.WriteLine(player.PlayerName[i]);
            //   if (player.PlayerName[i] == 0) {
            //     break;
            //   }
            // }

          _ProfileService.StopRecording("TestService");

          }
        } catch (Exception e) {
          _Logger.LogError(e, "");
        }
      }
    });
  }
}