using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundAreaEntitySphere : CSoundAreaEntityBase, ISoundAreaEntitySphere {

  public CSoundAreaEntitySphere(nint handle) : base(handle) {
  }

  public CSoundAreaEntitySphere(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2FF7C1D65ACFC08D));
  }

  public void RadiusUpdated() {
    Schema.Update(_Handle, 0x2FF7C1D65ACFC08D);
  }
}