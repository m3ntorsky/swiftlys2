using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_LerpCameraSettings__CursorState_t : IPulseCell_BaseLerp::CursorState_t {

  public CHandle<IPointCamera> Camera { get; }
  
  public IPointCameraSettings_t OverlaidStart { get; }
  
  public IPointCameraSettings_t OverlaidEnd { get; }
  
}