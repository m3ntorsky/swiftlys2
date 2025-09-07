using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseConstraint : CBoneConstraintBase, IBaseConstraint {

  public CBaseConstraint(nint handle) : base(handle) {
  }

  public CBaseConstraint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xE972C2844D8F5786));
  }
  public ref Vector UpVector {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xE972C28487645F1B));
  }
  public ref CUtlLeanVector< CConstraintSlave > Slaves {
    get => ref _Handle.AsRef<CUtlLeanVector< CConstraintSlave >>(Schema.GetOffset(0xE972C284A62BA9E9));
  }
  public ref CUtlVector< CConstraintTarget > Targets {
    get => ref _Handle.AsRef<CUtlVector< CConstraintTarget >>(Schema.GetOffset(0xE972C28436A2FF01));
  }


}