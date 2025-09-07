using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_PositionOffsetToCP : CParticleFunctionInitializer, IC_INIT_PositionOffsetToCP {

  public C_INIT_PositionOffsetToCP(nint handle) : base(handle) {
  }

  public C_INIT_PositionOffsetToCP(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumberStart {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5976F1BC33DBA947));
  }
  public ref int ControlPointNumberEnd {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5976F1BC6527E5A2));
  }
  public ref bool LocalCoords {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5976F1BC30E716DE));
  }


}