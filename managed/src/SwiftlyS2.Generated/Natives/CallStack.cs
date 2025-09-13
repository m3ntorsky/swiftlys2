using System.Buffers;
using System.Text;

namespace SwiftlyS2.Natives;

public static class NativeCallStack {
  private unsafe static delegate* unmanaged<byte*, byte*, ulong> _Register;
  public unsafe static ulong Register(string pluginName, string stackMsg) {
    var pool = ArrayPool<byte>.Shared;
    var pluginNameLength = Encoding.UTF8.GetByteCount(pluginName);
    var pluginNameBuffer = pool.Rent(pluginNameLength + 1);
    Encoding.UTF8.GetBytes(pluginName, pluginNameBuffer);
    pluginNameBuffer[pluginNameLength] = 0;
    fixed (byte* pluginNameBufferPtr = pluginNameBuffer) {

    var stackMsgLength = Encoding.UTF8.GetByteCount(stackMsg);
    var stackMsgBuffer = pool.Rent(stackMsgLength + 1);
    Encoding.UTF8.GetBytes(stackMsg, stackMsgBuffer);
    stackMsgBuffer[stackMsgLength] = 0;
    fixed (byte* stackMsgBufferPtr = stackMsgBuffer) {
    var ret = _Register(pluginNameBufferPtr, stackMsgBufferPtr);
    pool.Return(pluginNameBuffer);

    pool.Return(stackMsgBuffer);

    return ret;
  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, ulong, void> _Unregister;
  public unsafe static void Unregister(string pluginName, ulong callstackId) {
    var pool = ArrayPool<byte>.Shared;
    var pluginNameLength = Encoding.UTF8.GetByteCount(pluginName);
    var pluginNameBuffer = pool.Rent(pluginNameLength + 1);
    Encoding.UTF8.GetBytes(pluginName, pluginNameBuffer);
    pluginNameBuffer[pluginNameLength] = 0;
    fixed (byte* pluginNameBufferPtr = pluginNameBuffer) {
    _Unregister(pluginNameBufferPtr, callstackId);
    pool.Return(pluginNameBuffer);

  }
  }
}
