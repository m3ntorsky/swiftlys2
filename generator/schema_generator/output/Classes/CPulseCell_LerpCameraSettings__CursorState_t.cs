using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_LerpCameraSettings__CursorState_t : CPulseCell_BaseLerp::CursorState_t, IPulseCell_LerpCameraSettings__CursorState_t {

  public CPulseCell_LerpCameraSettings__CursorState_t(nint handle) : base(handle) {
  }

  public ref CHandle<CPointCamera> Camera {
    get => ref _Handle.AsRef<CHandle<CPointCamera>>(Schema.GetOffset(0x84AB53FD538EFB98));
  }
  public IPointCameraSettings_t OverlaidStart {
    get => new PointCameraSettings_t(_Handle + Schema.GetOffset(0x84AB53FD54E9A76F));
  }
  public IPointCameraSettings_t OverlaidEnd {
    get => new PointCameraSettings_t(_Handle + Schema.GetOffset(0x84AB53FD3CDFDEFA));
  }


}