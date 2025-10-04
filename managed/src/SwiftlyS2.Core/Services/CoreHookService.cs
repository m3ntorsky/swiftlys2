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
  }

  private delegate int CanAcquireDelegate(nint pItemServices, nint pEconItemView, nint acquireMethod, nint unk1);
  private IUnmanagedFunction<CanAcquireDelegate> _CanAcquire;
  private Guid _CanAcquireGuid;

  private void HookCanAcquire() {

    var address = _Core.GameData.GetSignature("CCSPlayer_ItemServices::CanAcquire");

    _Logger.LogInformation("Hooking CCSPlayer_ItemServices::CanAcquire at {Address}", address);

    _CanAcquire = _Core.Memory.GetUnmanagedFunctionByAddress<CanAcquireDelegate>(address);
    _CanAcquireGuid = _CanAcquire.AddHook(next => {

      return (pItemServices, pEconItemView, acquireMethod, unk1) => {

        var itemServices = _Core.Memory.ToSchemaClass<CCSPlayer_ItemServices>(pItemServices);
        var econItemView = _Core.Memory.ToSchemaClass<CEconItemView>(pEconItemView);

        var @event = new OnItemServicesCanAcquireHookEvent {
          ItemServices = itemServices,
          EconItemView = econItemView,
          AcquireMethod = (AcquireMethod)acquireMethod,
          Result = AcquireResult.Allowed
        };

        EventPublisher.InvokeOnCanAcquireHook(@event);

        if (@event.Intercepted) {
          return (int)@event.Result;
        }

        return next()(pItemServices, pEconItemView, acquireMethod, unk1);
      };
    });
  }

  public void Dispose() {
    _CanAcquire.RemoveHook(_CanAcquireGuid);
  }
}