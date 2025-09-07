using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAimConstraint : CBaseConstraint, IAimConstraint {

  public CAimConstraint(nint handle) : base(handle) {
  }

  public CAimConstraint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Quaternion AimOffset {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0x6C67AB6C43737FEA));
  }
  public ref uint UpType {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x6C67AB6C038EA2BC));
  }


}