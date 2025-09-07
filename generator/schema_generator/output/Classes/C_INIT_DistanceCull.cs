using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_DistanceCull : CParticleFunctionInitializer, IC_INIT_DistanceCull {

  public C_INIT_DistanceCull(nint handle) : base(handle) {
  }

  public C_INIT_DistanceCull(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x78EE30C90D0DDF8C));
  }
  public IParticleCollectionFloatInput Distance {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x78EE30C900DC4A68));
  }
  public ref bool CullInside {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x78EE30C9293E00AD));
  }


}