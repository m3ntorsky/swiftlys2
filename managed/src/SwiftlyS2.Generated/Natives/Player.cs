#pragma warning disable CS0649

using System.Buffers;
using System.Text;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativePlayer {
  private unsafe static delegate* unmanaged<int, int, byte*, void> _SendMessage;
  public unsafe static void SendMessage(int playerid, int kind, string message) {
    var pool = ArrayPool<byte>.Shared;
    var messageLength = Encoding.UTF8.GetByteCount(message);
    var messageBuffer = pool.Rent(messageLength + 1);
    Encoding.UTF8.GetBytes(message, messageBuffer);
    messageBuffer[messageLength] = 0;
    fixed (byte* messageBufferPtr = messageBuffer) {
    _SendMessage(playerid, kind, messageBufferPtr);
    pool.Return(messageBuffer);

  }
  }
  private unsafe static delegate* unmanaged<int, bool> _IsFakeClient;
  public unsafe static bool IsFakeClient(int playerid) {
    var ret = _IsFakeClient(playerid);
    return ret;
  }
  private unsafe static delegate* unmanaged<int, bool> _IsAuthorized;
  public unsafe static bool IsAuthorized(int playerid) {
    var ret = _IsAuthorized(playerid);
    return ret;
  }
  private unsafe static delegate* unmanaged<int, uint> _GetConnectedTime;
  public unsafe static uint GetConnectedTime(int playerid) {
    var ret = _GetConnectedTime(playerid);
    return ret;
  }
  private unsafe static delegate* unmanaged<int, ulong> _GetUnauthorizedSteamID;
  public unsafe static ulong GetUnauthorizedSteamID(int playerid) {
    var ret = _GetUnauthorizedSteamID(playerid);
    return ret;
  }
  private unsafe static delegate* unmanaged<int, ulong> _GetSteamID;
  public unsafe static ulong GetSteamID(int playerid) {
    var ret = _GetSteamID(playerid);
    return ret;
  }
  private unsafe static delegate* unmanaged<int, void*> _GetController;
  public unsafe static void* GetController(int playerid) {
    var ret = _GetController(playerid);
    return ret;
  }
  private unsafe static delegate* unmanaged<int, void*> _GetPawn;
  public unsafe static void* GetPawn(int playerid) {
    var ret = _GetPawn(playerid);
    return ret;
  }
  private unsafe static delegate* unmanaged<int, void*> _GetPlayerPawn;
  public unsafe static void* GetPlayerPawn(int playerid) {
    var ret = _GetPlayerPawn(playerid);
    return ret;
  }
  private unsafe static delegate* unmanaged<int, ulong> _GetPressedButtons;
  public unsafe static ulong GetPressedButtons(int playerid) {
    var ret = _GetPressedButtons(playerid);
    return ret;
  }
  private unsafe static delegate* unmanaged<int, byte*, void> _PerformCommand;
  public unsafe static void PerformCommand(int playerid, string command) {
    var pool = ArrayPool<byte>.Shared;
    var commandLength = Encoding.UTF8.GetByteCount(command);
    var commandBuffer = pool.Rent(commandLength + 1);
    Encoding.UTF8.GetBytes(command, commandBuffer);
    commandBuffer[commandLength] = 0;
    fixed (byte* commandBufferPtr = commandBuffer) {
    _PerformCommand(playerid, commandBufferPtr);
    pool.Return(commandBuffer);

  }
  }
  private unsafe static delegate* unmanaged<byte*, int, int> _GetIPAddress;
  public unsafe static string GetIPAddress(int playerid) {
    var ret = _GetIPAddress(null, playerid);
    var pool = ArrayPool<byte>.Shared;
    var retBuffer = pool.Rent(ret+1);
    fixed (byte* retBufferPtr = retBuffer) {
    ret = _GetIPAddress(retBufferPtr, playerid);
    var retString = Encoding.UTF8.GetString(retBufferPtr, ret);
    pool.Return(retBuffer);

    return retString;
  }
  }
  private unsafe static delegate* unmanaged<byte*, int, void> _Kick;
  public unsafe static void Kick(string reason, int gamereason) {
    var pool = ArrayPool<byte>.Shared;
    var reasonLength = Encoding.UTF8.GetByteCount(reason);
    var reasonBuffer = pool.Rent(reasonLength + 1);
    Encoding.UTF8.GetBytes(reason, reasonBuffer);
    reasonBuffer[reasonLength] = 0;
    fixed (byte* reasonBufferPtr = reasonBuffer) {
    _Kick(reasonBufferPtr, gamereason);
    pool.Return(reasonBuffer);

  }
  }
}
