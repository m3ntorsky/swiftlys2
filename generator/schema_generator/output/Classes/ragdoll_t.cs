using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ragdoll_t : SchemaClass, Iragdoll_t {

  public ragdoll_t(nint handle) : base(handle) {
  }

  public ragdoll_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< ragdollelement_t > List {
    get => ref _Handle.AsRef<CUtlVector< ragdollelement_t >>(Schema.GetOffset(0xC7E89F530CFB5881));
  }
  public ref CUtlVector< ragdollhierarchyjoint_t > HierarchyJoints {
    get => ref _Handle.AsRef<CUtlVector< ragdollhierarchyjoint_t >>(Schema.GetOffset(0xC7E89F534421F4B5));
  }
  public ref CUtlVector< int32 > BoneIndex {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0xC7E89F534FEF9075));
  }
  public ref bool AllowStretch {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC7E89F5350E37D6F));
  }
  public ref bool Unused {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC7E89F5385CF281B));
  }


}