using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRagdollPropAttached : CRagdollProp, IRagdollPropAttached {

  public CRagdollPropAttached(nint handle) : base(handle) {
  }

  public CRagdollPropAttached(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint BoneIndexAttached {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x4601EA84AECB2AA5));
  }
  public ref uint RagdollAttachedObjectIndex {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x4601EA84D09DB439));
  }
  public ref Vector AttachmentPointBoneSpace {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x4601EA849ABB7B0E));
  }
  public ref Vector AttachmentPointRagdollSpace {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x4601EA84AD8AE911));
  }
  public ref bool ShouldDetach {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4601EA84ABADEB5D));
  }
  public ref bool ShouldDeleteAttachedActivationRecord {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4601EA84BCB3F894));
  }

  public void BoneIndexAttachedUpdated() {
    Schema.Update(_Handle, 0x4601EA84AECB2AA5);
  }
  public void RagdollAttachedObjectIndexUpdated() {
    Schema.Update(_Handle, 0x4601EA84D09DB439);
  }
  public void AttachmentPointBoneSpaceUpdated() {
    Schema.Update(_Handle, 0x4601EA849ABB7B0E);
  }
  public void AttachmentPointRagdollSpaceUpdated() {
    Schema.Update(_Handle, 0x4601EA84AD8AE911);
  }
}