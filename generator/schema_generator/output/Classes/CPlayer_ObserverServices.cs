using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayer_ObserverServices : CPlayerPawnComponent, IPlayer_ObserverServices {

  public CPlayer_ObserverServices(nint handle) : base(handle) {
  }

  public ref ObserverMode_t ObserverLastMode {
    get => ref _Handle.AsRef<ObserverMode_t>(Schema.GetOffset(0x1611315A555EDA49));
  }
  public ref bool ForcedObserverMode {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1611315A276632E1));
  }

  public void ObserverModeUpdated() {
    Schema.Update(_Handle, 0x1611315ADAB57B35);
  }
  public void ObserverTargetUpdated() {
    Schema.Update(_Handle, 0x1611315A24779C4C);
  }
}