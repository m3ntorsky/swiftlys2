using System.Runtime.InteropServices;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Shared.Modules.Commands;

namespace SwiftlyS2.Core.Commands;

internal delegate void CommandCallbackDelegate(int playerId, nint args, nint commandName, nint prefix, bool slient);

internal delegate HookResult ClientCommandListenerCallbackDelegate(int playerId, nint commandLine);

internal delegate HookResult ClientChatListenerCallbackDelegate(int playerId, nint text, bool teamonly);

internal abstract class CommandCallbackBase : IDisposable {

  public Guid Guid { get; protected init; }

  public abstract void Dispose();

}

internal class CommandCallback : CommandCallbackBase {

  public string CommandName { get; protected init; }

  private ICommandService.CommandListener _handler;
  private CommandCallbackDelegate _unmanagedCallback;

  private nint _unmanagedCallbackPtr;
  private ulong _nativeListenerId;

  public CommandCallback(string commandName, bool registerRaw, ICommandService.CommandListener handler)
  {
    Guid = Guid.NewGuid();

    CommandName = commandName;

    _handler = handler;

    _unmanagedCallback = (playerId, argsPtr, commandNamePtr, prefixPtr, slient) => {

      var argsString = Marshal.PtrToStringUTF8(argsPtr)!;
      var commandNameString = Marshal.PtrToStringUTF8(commandNamePtr)!;
      var prefixString = Marshal.PtrToStringUTF8(prefixPtr)!;

      var args = argsString.Split('\x01');
      var context = new CommandContext(playerId, args, commandNameString, prefixString, slient);
      _handler(context);
    };

    _unmanagedCallbackPtr = Marshal.GetFunctionPointerForDelegate(_unmanagedCallback);

    _nativeListenerId = NativeCommands.RegisterCommand(commandName, _unmanagedCallbackPtr, registerRaw);
  }

  public override void Dispose()
  {
    NativeCommands.UnregisterCommand(_nativeListenerId);
  }
}

internal class ClientCommandListenerCallback : CommandCallbackBase {

  private ICommandService.ClientCommandHandler _handler;
  private ClientCommandListenerCallbackDelegate _unmanagedCallback;
  private nint _unmanagedCallbackPtr;
  private ulong _nativeListenerId;

  public ClientCommandListenerCallback(ICommandService.ClientCommandHandler handler)
  {
    Guid = Guid.NewGuid();

    _handler = handler;

    _unmanagedCallback = (playerId, commandLinePtr) => {
      var commandLineString = Marshal.PtrToStringUTF8(commandLinePtr)!;
      return _handler(playerId, commandLineString);
    };

    _unmanagedCallbackPtr = Marshal.GetFunctionPointerForDelegate(_unmanagedCallback);

    _nativeListenerId = NativeCommands.RegisterClientCommandsListener(_unmanagedCallbackPtr);

  }

  public override void Dispose()
  {
    NativeCommands.UnregisterClientCommandsListener(_nativeListenerId);
  }
}

internal class ClientChatListenerCallback : CommandCallbackBase {

  private ICommandService.ClientChatHandler _handler;
  private ClientChatListenerCallbackDelegate _unmanagedCallback;
  private nint _unmanagedCallbackPtr;
  private ulong _nativeListenerId;

  public ClientChatListenerCallback(ICommandService.ClientChatHandler handler) 
  {
    Guid = Guid.NewGuid();

    _handler = handler;

    _unmanagedCallback = (playerId, textPtr, teamonly) => {
      var textString = Marshal.PtrToStringUTF8(textPtr)!;
      return _handler(playerId, textString, teamonly);
    };

    _unmanagedCallbackPtr = Marshal.GetFunctionPointerForDelegate(_unmanagedCallback);

    _nativeListenerId = NativeCommands.RegisterClientChatListener(_unmanagedCallbackPtr);

  }

  public override void Dispose()
  {
    NativeCommands.UnregisterClientChatListener(_nativeListenerId);
  }
}