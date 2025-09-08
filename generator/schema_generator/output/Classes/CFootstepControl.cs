using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootstepControl : CBaseTrigger, IFootstepControl {

  public CFootstepControl(nint handle) : base(handle) {
  }



  public void SourceUpdated() {
    Schema.Update(_Handle, 0x85B34315D0835C78);
  }
  public void DestinationUpdated() {
    Schema.Update(_Handle, 0x85B343156E5C12DF);
  }
}