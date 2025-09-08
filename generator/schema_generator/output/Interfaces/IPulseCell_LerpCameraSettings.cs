using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_LerpCameraSettings : IPulseCell_BaseLerp {

  public ref float Seconds { get; }
  
  public IPointCameraSettings_t Start { get; }
  
  public IPointCameraSettings_t End { get; }
  
}