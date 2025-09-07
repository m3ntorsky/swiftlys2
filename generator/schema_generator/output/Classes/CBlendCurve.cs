using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBlendCurve : SchemaClass, IBlendCurve {

  public CBlendCurve(nint handle) : base(handle) {
  }

  public CBlendCurve(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float ControlPoint1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x837A0008CD928165));
  }
  public ref float ControlPoint2 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x837A0008CA927CAC));
  }


}