#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeVoiceManager {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<int, int, int, void> _SetClientListenOverride;
  public unsafe static void SetClientListenOverride(int playerid, int targetid, int listenOverride) {
    try {
    _SetClientListenOverride(playerid, targetid, listenOverride);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, int, int> _GetClientListenOverride;
  public unsafe static int GetClientListenOverride(int playerid, int targetid) {
    try {
    var ret = _GetClientListenOverride(playerid, targetid);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, int, void> _SetClientVoiceFlags;
  public unsafe static void SetClientVoiceFlags(int playerid, int flags) {
    try {
    _SetClientVoiceFlags(playerid, flags);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, int> _GetClientVoiceFlags;
  public unsafe static int GetClientVoiceFlags(int playerid) {
    try {
    var ret = _GetClientVoiceFlags(playerid);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
}
