using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBoneConstraintRbf : CBoneConstraintBase, IBoneConstraintRbf {

  public CBoneConstraintRbf(nint handle) : base(handle) {
  }

  public CBoneConstraintRbf(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< std::pair< CUtlString, uint32 > > InputBones {
    get => ref _Handle.AsRef<CUtlVector< std::pair< CUtlString, uint32 > >>(Schema.GetOffset(0x45CB33BF83336B6E));
  }
  public ref CUtlVector< std::pair< CUtlString, uint32 > > OutputBones {
    get => ref _Handle.AsRef<CUtlVector< std::pair< CUtlString, uint32 > >>(Schema.GetOffset(0x45CB33BF84D3A41B));
  }


}