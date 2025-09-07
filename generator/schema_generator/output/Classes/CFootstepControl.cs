using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootstepControl : CBaseTrigger, IFootstepControl {

  public CFootstepControl(nint handle) : base(handle) {
  }

  public CFootstepControl(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge Source {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x85B34315D0835C78));
  }
  public ref CUtlSymbolLarge Destination {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x85B343156E5C12DF));
  }

  public void SourceUpdated() {
    Schema.Update(_Handle, 0x85B34315D0835C78);
  }
  public void DestinationUpdated() {
    Schema.Update(_Handle, 0x85B343156E5C12DF);
  }
}