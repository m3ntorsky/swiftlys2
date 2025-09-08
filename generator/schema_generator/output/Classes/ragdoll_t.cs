using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ragdoll_t : SchemaClass, Iragdoll_t {

  public ragdoll_t(nint handle) : base(handle) {
  }

  public ref CUtlVector List {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xC7E89F530CFB5881));
  }
  public ref CUtlVector HierarchyJoints {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xC7E89F534421F4B5));
  }
  public ref CUtlVector<int> BoneIndex {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0xC7E89F534FEF9075));
  }
  public ref bool AllowStretch {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC7E89F5350E37D6F));
  }
  public ref bool Unused {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC7E89F5385CF281B));
  }


}