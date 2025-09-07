using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CollisionGroupContext_t : SchemaClass, ICollisionGroupContext_t {

  public CollisionGroupContext_t(nint handle) : base(handle) {
  }

  public CollisionGroupContext_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CollisionGroupNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF923B00A9115013F));
  }


}