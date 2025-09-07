using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_QuantizeCPComponent : CParticleFunctionPreEmission, IC_OP_QuantizeCPComponent {

  public C_OP_QuantizeCPComponent(nint handle) : base(handle) {
  }

  public C_OP_QuantizeCPComponent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleCollectionFloatInput InputValue {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xDE980890EEDF8362));
  }
  public ref int CPOutput {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDE9808902077C953));
  }
  public ref int OutVectorField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDE980890F9041E74));
  }
  public IParticleCollectionFloatInput QuantizeValue {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xDE98089065E1A349));
  }


}