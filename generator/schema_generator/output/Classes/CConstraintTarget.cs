using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CConstraintTarget : SchemaClass, IConstraintTarget {

  public CConstraintTarget(nint handle) : base(handle) {
  }

  public CConstraintTarget(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Quaternion Offset {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0x8A562794DB445327));
  }
  public ref Vector Offset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x8A562794FE159136));
  }
  public ref uint BoneHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x8A562794D4010F03));
  }
  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x8A56279463D22D49));
  }
  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8A5627947B81E7AB));
  }
  public ref bool IsAttachment {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8A562794794BF658));
  }


}