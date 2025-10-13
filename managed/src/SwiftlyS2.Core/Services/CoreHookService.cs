using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;
using SwiftlyS2.Core.Events;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Memory;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Core.Services;

internal class CoreHookService : IDisposable {
  private ILogger<CoreHookService> _Logger { get; init; }
  private ISwiftlyCore _Core { get; init; }

  public CoreHookService(ILogger<CoreHookService> logger, ISwiftlyCore core) {
    _Logger = logger;
    _Core = core;
  
    HookCanAcquire();
    HookCommandExecute();
  }

  private delegate int CanAcquireDelegate(nint pItemServices, nint pEconItemView, nint acquireMethod, nint unk1);
  /*
    Original function in engine2.dll: __int64 sub_1C0CD0(__int64 a1, int a2, unsigned int a3, ...)
    This is a variadic function, but we only need the first two variable arguments (v55, v57)

    __int64 sub_1C0CD0(__int64 a1, int a2, unsigned int a3, ...)
    {
        ...
        
        va_list va; // [rsp+D28h] [rbp+D28h]
        __int64 v55; // [rsp+E28h] [rbp+D28h] BYREF
        va_list va1; // [rsp+E28h] [rbp+D28h]

        ...

        va_start(va1, a3);
        va_start(va, a3);
        v55 = va_arg(va1, _QWORD);
        v57 = va_arg(va1, _QWORD);

        ...
    }

    So we model it as a fixed 5-parameter function for interop purposes
  */
  private delegate nint ExecuteCommandDelegate(nint a1, int a2, uint a3, nint a4, nint a5);
  private IUnmanagedFunction<ExecuteCommandDelegate>? _ExecuteCommand;
  private Guid _ExecuteCommandGuid;
  private IUnmanagedFunction<CanAcquireDelegate>? _CanAcquire;
  private Guid _CanAcquireGuid;

  private void HookCanAcquire() {

    var address = _Core.GameData.GetSignature("CCSPlayer_ItemServices::CanAcquire");

    _Logger.LogInformation("Hooking CCSPlayer_ItemServices::CanAcquire at {Address}", address);

    _CanAcquire = _Core.Memory.GetUnmanagedFunctionByAddress<CanAcquireDelegate>(address);
    _CanAcquireGuid = _CanAcquire.AddHook(next => {

      return (pItemServices, pEconItemView, acquireMethod, unk1) =>
      {
        var result = next()(pItemServices, pEconItemView, acquireMethod, unk1);

        var itemServices = _Core.Memory.ToSchemaClass<CCSPlayer_ItemServices>(pItemServices);
        var econItemView = _Core.Memory.ToSchemaClass<CEconItemView>(pEconItemView);

        var @event = new OnItemServicesCanAcquireHookEvent {
          ItemServices = itemServices,
          EconItemView = econItemView,
          AcquireMethod = (AcquireMethod)acquireMethod,
          OriginalResult = (AcquireResult)result
        };

        EventPublisher.InvokeOnCanAcquireHook(@event);

        if (@event.Intercepted) {
          // original result is modified here.
          return (int)@event.OriginalResult;
        }

        return result;
      };
    });
  }

  private void HookCommandExecute() {

    var address = _Core.GameData.GetSignature("Cmd_ExecuteCommand");

    _Logger.LogInformation("Hooking Cmd_ExecuteCommand at {Address}", address);
    var commandNameOffset = NativeOffsets.Fetch("CommandNameOffset");

    _ExecuteCommand = _Core.Memory.GetUnmanagedFunctionByAddress<ExecuteCommandDelegate>(address);
    _ExecuteCommandGuid = _ExecuteCommand.AddHook((next) =>
    {
      return (a1, a2, a3, a4, a5) =>
      {
        var (commandName, commandPtr) = (a5 != nint.Zero && a5 < nint.MaxValue && commandNameOffset != 0) switch {
          true when Marshal.ReadIntPtr(new nint(a5 + commandNameOffset)) is var basePtr && basePtr != nint.Zero && basePtr < nint.MaxValue
            => (Marshal.PtrToStringAnsi(Marshal.ReadIntPtr(basePtr)) ?? string.Empty, Marshal.ReadIntPtr(basePtr)),
          _ => (string.Empty, nint.Zero)
        };

        var preEvent = new OnCommandExecuteHookEvent {
          OriginalName = commandName,
          HookMode = HookMode.Pre
        };
        EventPublisher.InvokeOnCommandExecuteHook(preEvent);

        if (preEvent.Intercepted && preEvent.CommandName.Length < commandName.Length) {
          var newCommandName = Encoding.ASCII.GetBytes(preEvent.CommandName + "\0");
          var maxLength = Encoding.ASCII.GetByteCount(commandName + "\0");
          
          if (newCommandName.Length <= maxLength) {
            Marshal.Copy(newCommandName, 0, commandPtr, newCommandName.Length);
          }
        }

        var result = next()(a1, a2, a3, a4, a5);
        
        var postEvent = new OnCommandExecuteHookEvent {
          OriginalName = commandName,
          HookMode = HookMode.Post
        };
        EventPublisher.InvokeOnCommandExecuteHook(postEvent);
        
        return result;
      };
    });
  }

  public void Dispose() {
    _CanAcquire!.RemoveHook(_CanAcquireGuid);
    _ExecuteCommand!.RemoveHook(_ExecuteCommandGuid);
  }
}