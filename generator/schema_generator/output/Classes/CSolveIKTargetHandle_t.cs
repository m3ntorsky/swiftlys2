using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSolveIKTargetHandle_t : SchemaClass, ISolveIKTargetHandle_t {

  public CSolveIKTargetHandle_t(nint handle) : base(handle) {
  }

  public CSolveIKTargetHandle_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IAnimParamHandle PositionHandle {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xC2940485B066E3D4));
  }
  public IAnimParamHandle OrientationHandle {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xC294048597E9518F));
  }


}