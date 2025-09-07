using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundEventOBBEntity : CSoundEventEntity, ISoundEventOBBEntity {

  public CSoundEventOBBEntity(nint handle) : base(handle) {
  }

  public CSoundEventOBBEntity(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Mins {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x470330BB421BB730));
  }
  public ref Vector Maxs {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x470330BBC0C1CE6A));
  }

  public void MinsUpdated() {
    Schema.Update(_Handle, 0x470330BB421BB730);
  }
  public void MaxsUpdated() {
    Schema.Update(_Handle, 0x470330BBC0C1CE6A);
  }
}