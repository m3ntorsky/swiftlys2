using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundEventSphereEntity : CSoundEventEntity, ISoundEventSphereEntity {

  public CSoundEventSphereEntity(nint handle) : base(handle) {
  }

  public CSoundEventSphereEntity(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x12CB958D5ACFC08D));
  }

  public void RadiusUpdated() {
    Schema.Update(_Handle, 0x12CB958D5ACFC08D);
  }
}