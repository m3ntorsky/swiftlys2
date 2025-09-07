using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_PercentageBetweenTransformLerpCPs : CParticleFunctionOperator, IC_OP_PercentageBetweenTransformLerpCPs {

  public C_OP_PercentageBetweenTransformLerpCPs(nint handle) : base(handle) {
  }

  public C_OP_PercentageBetweenTransformLerpCPs(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x96404634E5729606));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x96404634E88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x96404634D6766901));
  }
  public IParticleTransformInput TransformStart {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x96404634D94FA7F9));
  }
  public IParticleTransformInput TransformEnd {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x964046340C3277C8));
  }
  public ref int OutputStartCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x96404634E2225D8F));
  }
  public ref int OutputStartField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x96404634BEFE1578));
  }
  public ref int OutputEndCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x96404634A30AF91E));
  }
  public ref int OutputEndField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x964046344B3EC3AF));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x96404634FB53C31E));
  }
  public ref bool ActiveRange {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x964046343FA53B84));
  }
  public ref bool RadialCheck {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x96404634496187DE));
  }


}