using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqIKLock : SchemaClass, ISeqIKLock {

  public CSeqIKLock(nint handle) : base(handle) {
  }

  public CSeqIKLock(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float PosWeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9813F59E9CC6C04B));
  }
  public ref float AngleWeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9813F59E51DFB6EE));
  }
  public ref short LocalBone {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x9813F59EC2F7B8CA));
  }
  public ref bool BonesOrientedAlongPositiveX {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9813F59ED3FDAB3A));
  }


}