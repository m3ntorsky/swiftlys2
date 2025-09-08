using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_TurbulenceForce : CParticleFunctionForce, IC_OP_TurbulenceForce {

  public C_OP_TurbulenceForce(nint handle) : base(handle) {
  }

  public ref float NoiseCoordScale0 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCAE57FA75C19EC96));
  }
  public ref float NoiseCoordScale1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCAE57FA75D19EE29));
  }
  public ref float NoiseCoordScale2 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCAE57FA75A19E970));
  }
  public ref float NoiseCoordScale3 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCAE57FA75B19EB03));
  }
  public ref Vector NoiseAmount0 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xCAE57FA767BF95F7));
  }
  public ref Vector NoiseAmount1 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xCAE57FA766BF9464));
  }
  public ref Vector NoiseAmount2 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xCAE57FA769BF991D));
  }
  public ref Vector NoiseAmount3 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xCAE57FA768BF978A));
  }


}