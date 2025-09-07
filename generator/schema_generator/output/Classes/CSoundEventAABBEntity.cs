using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundEventAABBEntity : CSoundEventEntity, ISoundEventAABBEntity {

  public CSoundEventAABBEntity(nint handle) : base(handle) {
  }

  public CSoundEventAABBEntity(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Mins {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9E5B084A421BB730));
  }
  public ref Vector Maxs {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9E5B084AC0C1CE6A));
  }

  public void MinsUpdated() {
    Schema.Update(_Handle, 0x9E5B084A421BB730);
  }
  public void MaxsUpdated() {
    Schema.Update(_Handle, 0x9E5B084AC0C1CE6A);
  }
}