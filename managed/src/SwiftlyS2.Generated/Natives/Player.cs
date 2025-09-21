#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativePlayer {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<int, int, byte*, void> _SendMessage;
  public unsafe static void SendMessage(int playerid, int kind, string message) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
        _SendMessage(playerid, kind, messageBufferPtr);
    pool.Return(messageBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, bool> _IsFakeClient;
  public unsafe static bool IsFakeClient(int playerid) {
    try {
    var ret = _IsFakeClient(playerid);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, bool> _IsAuthorized;
  public unsafe static bool IsAuthorized(int playerid) {
    try {
    var ret = _IsAuthorized(playerid);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, uint> _GetConnectedTime;
  public unsafe static uint GetConnectedTime(int playerid) {
    try {
    var ret = _GetConnectedTime(playerid);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, ulong> _GetUnauthorizedSteamID;
  public unsafe static ulong GetUnauthorizedSteamID(int playerid) {
    try {
    var ret = _GetUnauthorizedSteamID(playerid);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, ulong> _GetSteamID;
  public unsafe static ulong GetSteamID(int playerid) {
    try {
    var ret = _GetSteamID(playerid);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, nint> _GetController;
  public unsafe static nint GetController(int playerid) {
    try {
    var ret = _GetController(playerid);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, nint> _GetPawn;
  public unsafe static nint GetPawn(int playerid) {
    try {
    var ret = _GetPawn(playerid);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, nint> _GetPlayerPawn;
  public unsafe static nint GetPlayerPawn(int playerid) {
    try {
    var ret = _GetPlayerPawn(playerid);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, ulong> _GetPressedButtons;
  public unsafe static ulong GetPressedButtons(int playerid) {
    try {
    var ret = _GetPressedButtons(playerid);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, byte*, void> _PerformCommand;
  public unsafe static void PerformCommand(int playerid, string command) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var commandLength = Encoding.UTF8.GetByteCount(command);
    var commandBuffer = pool.Rent(commandLength + 1);
    Encoding.UTF8.GetBytes(command, commandBuffer);
    commandBuffer[commandLength] = 0;
    fixed (byte* commandBufferPtr = commandBuffer) {
        _PerformCommand(playerid, commandBufferPtr);
    pool.Return(commandBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<byte*, int, int> _GetIPAddress;
  public unsafe static string GetIPAddress(int playerid) {
    try {
    var ret = _GetIPAddress(null, playerid);
    var pool = ArrayPool<byte>.Shared;
    var retBuffer = pool.Rent(ret+1);
    fixed (byte* retBufferPtr = retBuffer) {
        ret = _GetIPAddress(retBufferPtr, playerid);
    var retString = Encoding.UTF8.GetString(retBufferPtr, ret);
    pool.Return(retBuffer);

    return retString;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, byte*, int, void> _Kick;
  public unsafe static void Kick(int playerid, string reason, int gamereason) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var reasonLength = Encoding.UTF8.GetByteCount(reason);
    var reasonBuffer = pool.Rent(reasonLength + 1);
    Encoding.UTF8.GetBytes(reason, reasonBuffer);
    reasonBuffer[reasonLength] = 0;
    fixed (byte* reasonBufferPtr = reasonBuffer) {
        _Kick(playerid, reasonBufferPtr, gamereason);
    pool.Return(reasonBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, int, bool, void> _ShouldBlockTransmitEntity;
  public unsafe static void ShouldBlockTransmitEntity(int playerid, int entityidx, bool shouldBlockTransmit) {
    try {
    _ShouldBlockTransmitEntity(playerid, entityidx, shouldBlockTransmit);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int, int, bool> _IsTransmitEntityBlocked;
  public unsafe static bool IsTransmitEntityBlocked(int playerid, int entityidx) {
    try {
    var ret = _IsTransmitEntityBlocked(playerid, entityidx);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
}
