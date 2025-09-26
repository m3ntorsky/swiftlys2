#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeServerHelpers {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<byte*, int> _GetServerLanguage;
  public unsafe static string GetServerLanguage() {
    try {
    var ret = _GetServerLanguage(null);
    var pool = ArrayPool<byte>.Shared;
    var retBuffer = pool.Rent(ret+1);
    fixed (byte* retBufferPtr = retBuffer) {
        ret = _GetServerLanguage(retBufferPtr);
    var retString = Encoding.UTF8.GetString(retBufferPtr, ret);
    pool.Return(retBuffer);

    return retString;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<bool> _UsePlayerLanguage;
  public unsafe static bool UsePlayerLanguage() {
    try {
    var ret = _UsePlayerLanguage();
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<bool> _IsFollowingServerGuidelines;
  public unsafe static bool IsFollowingServerGuidelines() {
    try {
    var ret = _IsFollowingServerGuidelines();
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
}
