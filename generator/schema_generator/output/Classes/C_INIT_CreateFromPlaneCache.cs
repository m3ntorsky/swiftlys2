using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_CreateFromPlaneCache : CParticleFunctionInitializer, IC_INIT_CreateFromPlaneCache {

  public C_INIT_CreateFromPlaneCache(nint handle) : base(handle) {
  }

  public C_INIT_CreateFromPlaneCache(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector OffsetMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x349002765EE9C8FE));
  }
  public ref Vector OffsetMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x3490027670D65D9C));
  }
  public ref bool UseNormal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x349002769FA2D197));
  }


}