using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNavVolumeSphere : CNavVolume, INavVolumeSphere {

  public CNavVolumeSphere(nint handle) : base(handle) {
  }

  public ref Vector Center {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x8FB5B6B8C82A5908));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8FB5B6B85ACFC08D));
  }


}