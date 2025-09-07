using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ragdollhierarchyjoint_t : SchemaClass, Iragdollhierarchyjoint_t {

  public ragdollhierarchyjoint_t(nint handle) : base(handle) {
  }

  public ragdollhierarchyjoint_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ParentIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3D7AD556FE49C863));
  }
  public ref int ChildIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3D7AD556226EC483));
  }


}