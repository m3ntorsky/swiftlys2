#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeEngineHelpers {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<byte*, int> _GetServerIP;
  public unsafe static string GetServerIP() {
    try {
    var ret = _GetServerIP(null);
    var pool = ArrayPool<byte>.Shared;
    var retBuffer = pool.Rent(ret+1);
    fixed (byte* retBufferPtr = retBuffer) {
        ret = _GetServerIP(retBufferPtr);
    var retString = Encoding.UTF8.GetString(retBufferPtr, ret);
    pool.Return(retBuffer);

    return retString;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<byte*, int> _GetMap;
  public unsafe static string GetMap() {
    try {
    var ret = _GetMap(null);
    var pool = ArrayPool<byte>.Shared;
    var retBuffer = pool.Rent(ret+1);
    fixed (byte* retBufferPtr = retBuffer) {
        ret = _GetMap(retBufferPtr);
    var retString = Encoding.UTF8.GetString(retBufferPtr, ret);
    pool.Return(retBuffer);

    return retString;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<byte*, bool> _IsMapValid;
  /// <summary>
  /// it can be map name, or workshop id
  /// </summary>
  public unsafe static bool IsMapValid(string map_name) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var map_nameLength = Encoding.UTF8.GetByteCount(map_name);
    var map_nameBuffer = pool.Rent(map_nameLength + 1);
    Encoding.UTF8.GetBytes(map_name, map_nameBuffer);
    map_nameBuffer[map_nameLength] = 0;
    fixed (byte* map_nameBufferPtr = map_nameBuffer) {
        var ret = _IsMapValid(map_nameBufferPtr);
    pool.Return(map_nameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int> _GetMaxPlayers;
  public unsafe static int GetMaxPlayers() {
    try {
    var ret = _GetMaxPlayers();
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<byte*, void> _ExecuteCommand;
  public unsafe static void ExecuteCommand(string command) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var commandLength = Encoding.UTF8.GetByteCount(command);
    var commandBuffer = pool.Rent(commandLength + 1);
    Encoding.UTF8.GetBytes(command, commandBuffer);
    commandBuffer[commandLength] = 0;
    fixed (byte* commandBufferPtr = commandBuffer) {
        _ExecuteCommand(commandBufferPtr);
    pool.Return(commandBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<float> _GetServerCurrentTime;
  public unsafe static float GetServerCurrentTime() {
    try {
    var ret = _GetServerCurrentTime();
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<int> _GetServerTickCount;
  /// <summary>
  /// simulation tick
  /// </summary>
  public unsafe static int GetServerTickCount() {
    try {
    var ret = _GetServerTickCount();
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<byte*, nint> _FindGameSystemByName;
  public unsafe static nint FindGameSystemByName(string name) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var nameLength = Encoding.UTF8.GetByteCount(name);
    var nameBuffer = pool.Rent(nameLength + 1);
    Encoding.UTF8.GetBytes(name, nameBuffer);
    nameBuffer[nameLength] = 0;
    fixed (byte* nameBufferPtr = nameBuffer) {
        var ret = _FindGameSystemByName(nameBufferPtr);
    pool.Return(nameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<byte*, void> _SendMessageToConsole;
  public unsafe static void SendMessageToConsole(string msg) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var msgLength = Encoding.UTF8.GetByteCount(msg);
    var msgBuffer = pool.Rent(msgLength + 1);
    Encoding.UTF8.GetBytes(msg, msgBuffer);
    msgBuffer[msgLength] = 0;
    fixed (byte* msgBufferPtr = msgBuffer) {
        _SendMessageToConsole(msgBufferPtr);
    pool.Return(msgBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
}
