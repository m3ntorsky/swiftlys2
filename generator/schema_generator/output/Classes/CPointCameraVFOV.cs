using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointCameraVFOV : CPointCamera, IPointCameraVFOV {

  public CPointCameraVFOV(nint handle) : base(handle) {
  }

  public ref float VerticalFOV {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBDB1254E910A1908));
  }


}