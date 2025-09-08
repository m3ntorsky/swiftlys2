using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_PercentageBetweenTransformsVector : CParticleFunctionOperator, IC_OP_PercentageBetweenTransformsVector {

  public C_OP_PercentageBetweenTransformsVector(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x481FA5ADE5729606));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x481FA5ADE88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x481FA5ADD6766901));
  }
  public ref Vector OutputMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x481FA5AD2EFED678));
  }
  public ref Vector OutputMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x481FA5AD451280D2));
  }
  public IParticleTransformInput TransformStart {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x481FA5ADD94FA7F9));
  }
  public IParticleTransformInput TransformEnd {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x481FA5AD0C3277C8));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x481FA5ADFB53C31E));
  }
  public ref bool ActiveRange {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x481FA5AD3FA53B84));
  }
  public ref bool RadialCheck {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x481FA5AD496187DE));
  }


}