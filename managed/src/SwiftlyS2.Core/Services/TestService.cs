using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.SchemaDefinitions;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Core.Services;

internal class TestService {

  private ILogger<TestService> _Logger { get; init; }
  public unsafe TestService(
    ILoggerFactory loggerFactory
  ) {
    _Logger = loggerFactory.CreateLogger<TestService>();

    CCSWeaponBase a = null!;

    Test();
  }

  public void Test()
  {
    Task.Run(async () =>
    {
      while (false)
      {
        await Task.Delay(1000);
        unsafe
        {
          var pRules = (nint)NativeTest.Test();
          _Logger.LogInformation("pPlayer: "+ pRules.ToString());
          if (pRules == nint.Zero)
          {
            continue;
          }

          CCSPlayerController player = new CCSPlayerControllerImpl(pRules);
          _Logger.LogError("playername: "+ player.PlayerName.Value);
          
          // for (int i = 0; i < player.PlayerName.ElementCount; i++) {
          //   Console.WriteLine(player.PlayerName[i]);
          //   if (player.PlayerName[i] == 0) {
          //     break;
          //   }
          // }

        }
      }
    });
  }
}