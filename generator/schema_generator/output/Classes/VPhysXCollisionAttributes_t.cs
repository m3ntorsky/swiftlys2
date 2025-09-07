using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VPhysXCollisionAttributes_t : SchemaClass, IVPhysXCollisionAttributes_t {

  public VPhysXCollisionAttributes_t(nint handle) : base(handle) {
  }

  public VPhysXCollisionAttributes_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint CollisionGroup {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xBD3263AF91BF7016));
  }
  public ref CUtlVector< uint32 > InteractAs {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0xBD3263AF4FBB627B));
  }
  public ref CUtlVector< uint32 > InteractWith {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0xBD3263AFAD426A97));
  }
  public ref CUtlVector< uint32 > InteractExclude {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0xBD3263AFC5ECE843));
  }
  public ref CUtlString CollisionGroupString {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xBD3263AFCF0517E7));
  }
  public ref CUtlVector< CUtlString > InteractAsStrings {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0xBD3263AF7A4D07B7));
  }
  public ref CUtlVector< CUtlString > InteractWithStrings {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0xBD3263AF691AB483));
  }
  public ref CUtlVector< CUtlString > InteractExcludeStrings {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0xBD3263AF97DC23CF));
  }


}