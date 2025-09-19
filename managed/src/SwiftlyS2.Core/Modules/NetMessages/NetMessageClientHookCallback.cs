using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Extensions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Core.NetMessages;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate bool NetMessageClientHookCallbackDelegate(int playerId, int msgId, nint pMessage);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
internal delegate bool NetMessageServerHookCallbackDelegate(nint pPlayerMask, int msgId, nint pMessage);

internal abstract class NetMessageHookCallback : IDisposable {

  public Guid Guid { get; init; }

  public abstract void Dispose();

}

internal class NetMessageClientHookCallback<T> : NetMessageHookCallback where T : ITypedProtobuf<T>, INetMessage<T>, IDisposable {

  private INetMessageService.ClientNetMessageHandler<T> _callback;
  private NetMessageClientHookCallbackDelegate _unmanagedCallback;
  private nint _unmanagedCallbackPtr;
  private ulong _nativeListenerId;
  private ILogger<NetMessageClientHookCallback<T>> _logger;


  public NetMessageClientHookCallback(INetMessageService.ClientNetMessageHandler<T> callback, ILoggerFactory loggerFactory) {
    Guid = Guid.NewGuid();
    _logger = loggerFactory.CreateLogger<NetMessageClientHookCallback<T>>();

    _callback = callback;

    _unmanagedCallback = (playerId, msgId, pMessage) => {
      if (msgId != T.MessageId) return true;
      try
      {
        var msg = T.Wrap(pMessage, false);
        _callback(msg, playerId);
        return true;
      } catch (Exception e) {
        _logger.LogError(e, "Error in net message client hook callback for {MessageType}", typeof(T).Name);
        return false;
      }
    };
    _unmanagedCallbackPtr = Marshal.GetFunctionPointerForDelegate(_unmanagedCallback);
    _nativeListenerId = NativeNetMessages.AddNetMessageClientHook(_unmanagedCallbackPtr);

  }

  public override void Dispose() {
    NativeNetMessages.RemoveNetMessageClientHook(_nativeListenerId);
  }

}

internal class NetMessageServerHookCallback<T> : NetMessageHookCallback where T : ITypedProtobuf<T>, INetMessage<T>, IDisposable {

  private INetMessageService.ServerNetMessageHandler<T> _callback;
  private NetMessageServerHookCallbackDelegate _unmanagedCallback;
  private nint _unmanagedCallbackPtr;
  private ulong _nativeListenerId;
  private ILogger<NetMessageServerHookCallback<T>> _logger;

  public NetMessageServerHookCallback(INetMessageService.ServerNetMessageHandler<T> callback, ILoggerFactory loggerFactory) {
    Guid = Guid.NewGuid();
    _logger = loggerFactory.CreateLogger<NetMessageServerHookCallback<T>>();

    _callback = callback;

    _unmanagedCallback = (pPlayerMask, msgId, pMessage) => {
      if (msgId != T.MessageId) return true;
      try
      {
        var msg = T.Wrap(pMessage, false);
        var mask = pPlayerMask.Read<ulong>();
        CRecipientFilter filter = CRecipientFilter.FromMask(mask);
        _callback(msg, filter);
        pPlayerMask.Write(filter.ToMask());
        return true;
      } catch (Exception e) {
        _logger.LogError(e, "Error in net message server hook callback for {MessageType}", typeof(T).Name);
        return false;
      }
    };
    _unmanagedCallbackPtr = Marshal.GetFunctionPointerForDelegate(_unmanagedCallback);
    _nativeListenerId = NativeNetMessages.AddNetMessageServerHook(_unmanagedCallbackPtr);

  }

  public override void Dispose() {
    NativeNetMessages.RemoveNetMessageServerHook(_nativeListenerId);
  }

}