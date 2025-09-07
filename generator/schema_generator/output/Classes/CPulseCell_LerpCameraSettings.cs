using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_LerpCameraSettings : CPulseCell_BaseLerp, IPulseCell_LerpCameraSettings {

  public CPulseCell_LerpCameraSettings(nint handle) : base(handle) {
  }

  public CPulseCell_LerpCameraSettings(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Seconds {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA4A5850773C6938C));
  }
  public IPointCameraSettings_t Start {
    get => new PointCameraSettings_t(_Handle + Schema.GetOffset(0xA4A58507FF7CBA5F));
  }
  public IPointCameraSettings_t End {
    get => new PointCameraSettings_t(_Handle + Schema.GetOffset(0xA4A58507F624CF2A));
  }


}