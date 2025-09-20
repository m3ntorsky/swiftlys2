using System.Runtime.InteropServices;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Shared.Commands;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Shared.Profiler;

namespace SwiftlyS2.Core.Commands;

internal delegate void CommandCallbackDelegate(int playerId, nint args, nint commandName, nint prefix, bool slient);

internal delegate HookResult ClientCommandListenerCallbackDelegate(int playerId, nint commandLine);

internal delegate HookResult ClientChatListenerCallbackDelegate(int playerId, nint text, bool teamonly);

internal abstract class CommandCallbackBase : IDisposable {

  public Guid Guid { get; protected init; }

  public required IContextedProfilerService Profiler { get; set; }

  public required ILoggerFactory LoggerFactory { get; set; }

  public abstract void Dispose();

}

internal class CommandCallback : CommandCallbackBase {

  public string CommandName { get; protected init; }

  private ICommandService.CommandListener _handler;
  private CommandCallbackDelegate _unmanagedCallback;

  private nint _unmanagedCallbackPtr;
  private ulong _nativeListenerId;

  private ILogger<CommandCallback> _logger;

  public CommandCallback(string commandName, bool registerRaw, ICommandService.CommandListener handler)
  {
    _logger = LoggerFactory!.CreateLogger<CommandCallback>();
    Guid = Guid.NewGuid();

    CommandName = commandName;

    _handler = handler;

    _unmanagedCallback = (playerId, argsPtr, commandNamePtr, prefixPtr, slient) => {
      try {
        var category = "CommandCallback::" + CommandName;
        Profiler!.StartRecording(category);
        var argsString = Marshal.PtrToStringUTF8(argsPtr)!;
        var commandNameString = Marshal.PtrToStringUTF8(commandNamePtr)!;
        var prefixString = Marshal.PtrToStringUTF8(prefixPtr)!;

        var args = argsString.Split('\x01');
        var context = new CommandContext(playerId, args, commandNameString, prefixString, slient);
        _handler(context);
        Profiler!.StopRecording(category);
      } catch (Exception e) {
        _logger.LogError(e, "Failed to handle command {0}.", commandName);
      } 
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
  private ILogger<ClientCommandListenerCallback> _logger;

  public ClientCommandListenerCallback(ICommandService.ClientCommandHandler handler)
  {
    _logger = LoggerFactory!.CreateLogger<ClientCommandListenerCallback>();
    Guid = Guid.NewGuid();

    _handler = handler;

    _unmanagedCallback = (playerId, commandLinePtr) => {
      try {
        var category = "ClientCommandListenerCallback";
        Profiler!.StartRecording(category);
        var commandLineString = Marshal.PtrToStringUTF8(commandLinePtr)!;
        var result = _handler(playerId, commandLineString);
        Profiler!.StopRecording(category);
        return result;
      } catch (Exception e) {
        _logger.LogError(e, "Failed to handle client command listener.");
        return HookResult.Continue;
      }
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
  private ILogger<ClientChatListenerCallback> _logger;

  public ClientChatListenerCallback(ICommandService.ClientChatHandler handler) 
  {
    _logger = LoggerFactory!.CreateLogger<ClientChatListenerCallback>();
    Guid = Guid.NewGuid();

    _handler = handler;

    _unmanagedCallback = (playerId, textPtr, teamonly) => {
      try {
        var category = "ClientChatListenerCallback";
        Profiler!.StartRecording(category);
        var textString = Marshal.PtrToStringUTF8(textPtr)!;
        var result = _handler(playerId, textString, teamonly);
        Profiler!.StopRecording(category);
        return result;
      } catch (Exception e) {
        _logger.LogError(e, "Failed to handle client chat listener.");
        return HookResult.Continue;
      }
    };

    _unmanagedCallbackPtr = Marshal.GetFunctionPointerForDelegate(_unmanagedCallback);

    _nativeListenerId = NativeCommands.RegisterClientChatListener(_unmanagedCallbackPtr);

  }

  public override void Dispose()
  {
    NativeCommands.UnregisterClientChatListener(_nativeListenerId);
  }
}