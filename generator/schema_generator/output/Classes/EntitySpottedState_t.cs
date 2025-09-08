using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EntitySpottedState_t : SchemaClass, IEntitySpottedState_t {

  public EntitySpottedState_t(nint handle) : base(handle) {
  }



  public void SpottedUpdated() {
    Schema.Update(_Handle, 0x6E33B0176DE4F1CA);
  }
  public void SpottedByMaskUpdated() {
    Schema.Update(_Handle, 0x6E33B0170BD77207);
  }
}