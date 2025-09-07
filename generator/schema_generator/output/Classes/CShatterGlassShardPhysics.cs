using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CShatterGlassShardPhysics : CPhysicsProp, IShatterGlassShardPhysics {

  public CShatterGlassShardPhysics(nint handle) : base(handle) {
  }

  public CShatterGlassShardPhysics(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool Debris {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC24E779865054BBA));
  }
  public ref uint ParentShard {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xC24E7798E3717B41));
  }
  public Ishard_model_desc_t ShardDesc {
    get => new shard_model_desc_t(_Handle + Schema.GetOffset(0xC24E77982CBF17C6));
  }

  public void ShardDescUpdated() {
    Schema.Update(_Handle, 0xC24E77982CBF17C6);
  }
}