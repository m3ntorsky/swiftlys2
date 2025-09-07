using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseTrigger : CBaseToggle, IBaseTrigger {

  public CBaseTrigger(nint handle) : base(handle) {
  }

  public CBaseTrigger(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput OnStartTouch {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x96DE10B1B4E38193));
  }
  public IEntityIOOutput OnStartTouchAll {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x96DE10B1BE1133C6));
  }
  public IEntityIOOutput OnEndTouch {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x96DE10B15D181B48));
  }
  public IEntityIOOutput OnEndTouchAll {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x96DE10B1A5526E0B));
  }
  public IEntityIOOutput OnTouching {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x96DE10B1CD69EB01));
  }
  public IEntityIOOutput OnTouchingEachEntity {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x96DE10B1CBC29227));
  }
  public IEntityIOOutput OnNotTouching {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x96DE10B19603AF34));
  }
  public ref CUtlVector< CHandle< CBaseEntity > > TouchingEntities {
    get => ref _Handle.AsRef<CUtlVector< CHandle< CBaseEntity > >>(Schema.GetOffset(0x96DE10B1070A5E2D));
  }
  public ref CUtlSymbolLarge FilterName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x96DE10B109C86445));
  }
  public ref CHandle< CBaseFilter > Filter {
    get => ref _Handle.AsRef<CHandle< CBaseFilter >>(Schema.GetOffset(0x96DE10B145D9E0B1));
  }
  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x96DE10B13A7C5965));
  }
  public ref bool UseAsyncQueries {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x96DE10B1DDD8EB18));
  }

  public void DisabledUpdated() {
    Schema.Update(_Handle, 0x96DE10B13A7C5965);
  }
}