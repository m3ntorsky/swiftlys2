using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_CreateAlongPath : CParticleFunctionInitializer, IC_INIT_CreateAlongPath {

  public C_INIT_CreateAlongPath(nint handle) : base(handle) {
  }

  public ref float MaxDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x655F7B0C844E396A));
  }
  public IPathParameters PathParams {
    get => new CPathParameters(_Handle + Schema.GetOffset(0x655F7B0C3C10092C));
  }
  public ref bool UseRandomCPs {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x655F7B0CA15D9A41));
  }
  public ref Vector EndOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x655F7B0C5BBD1959));
  }
  public ref bool SaveOffset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x655F7B0C43F64E5B));
  }


}