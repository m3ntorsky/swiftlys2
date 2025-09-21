#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativePlayerManager {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<int, bool> _IsPlayerOnline;
  public unsafe static bool IsPlayerOnline(int playerid) {
    try {
    var ret = _IsPlayerOnline(playerid);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int> _GetPlayerCount;
  public unsafe static int GetPlayerCount() {
    try {
    var ret = _GetPlayerCount();
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int> _GetPlayerCap;
  public unsafe static int GetPlayerCap() {
    try {
    var ret = _GetPlayerCap();
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, byte*, void> _SendMessage;
  public unsafe static void SendMessage(int kind, string message) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
        _SendMessage(kind, messageBufferPtr);
    pool.Return(messageBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, bool, void> _ShouldBlockTransmitEntity;
  public unsafe static void ShouldBlockTransmitEntity(int entityidx, bool shouldBlockTransmit) {
    try {
    _ShouldBlockTransmitEntity(entityidx, shouldBlockTransmit);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
}
