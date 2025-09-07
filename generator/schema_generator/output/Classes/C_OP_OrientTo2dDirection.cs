using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_OrientTo2dDirection : CParticleFunctionOperator, IC_OP_OrientTo2dDirection {

  public C_OP_OrientTo2dDirection(nint handle) : base(handle) {
  }

  public C_OP_OrientTo2dDirection(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float RotOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2AC61F04D1EA9CDF));
  }
  public ref float SpinStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2AC61F0412520F26));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x2AC61F04E5729606));
  }


}