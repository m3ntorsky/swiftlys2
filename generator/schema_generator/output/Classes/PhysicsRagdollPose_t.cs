using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PhysicsRagdollPose_t : SchemaClass, IPhysicsRagdollPose_t {

  public PhysicsRagdollPose_t(nint handle) : base(handle) {
  }

  public ref bool SetFromDebugHistory {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x54A98BF136013F6));
  }

  public void TransformsUpdated() {
    Schema.Update(_Handle, 0x54A98BF4852CD38);
  }
  public void OwnerUpdated() {
    Schema.Update(_Handle, 0x54A98BFF6D89572);
  }
}