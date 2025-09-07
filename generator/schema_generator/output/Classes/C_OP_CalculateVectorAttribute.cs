using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_CalculateVectorAttribute : CParticleFunctionOperator, IC_OP_CalculateVectorAttribute {

  public C_OP_CalculateVectorAttribute(nint handle) : base(handle) {
  }

  public C_OP_CalculateVectorAttribute(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector StartValue {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x447A59BC56F9B8E8));
  }
  public IParticleAttributeIndex_t FieldInput1 {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x447A59BCFDDCEC88));
  }
  public ref float InputScale1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x447A59BC66B56E68));
  }
  public IParticleAttributeIndex_t FieldInput2 {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x447A59BC00DCF141));
  }
  public ref float InputScale2 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x447A59BC69B57321));
  }
  public IControlPointReference_t ControlPointInput1 {
    get => new ControlPointReference_t(_Handle + Schema.GetOffset(0x447A59BC2FE852C3));
  }
  public ref float ControlPointScale1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x447A59BC863910DF));
  }
  public IControlPointReference_t ControlPointInput2 {
    get => new ControlPointReference_t(_Handle + Schema.GetOffset(0x447A59BC30E85456));
  }
  public ref float ControlPointScale2 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x447A59BC87391272));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x447A59BCE5729606));
  }
  public ref Vector FinalOutputScale {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x447A59BCADDD3664));
  }


}