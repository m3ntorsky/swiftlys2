using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapNamedModelElementToScalar : CParticleFunctionInitializer, IC_INIT_RemapNamedModelElementToScalar {

  public C_INIT_RemapNamedModelElementToScalar(nint handle) : base(handle) {
  }

  public C_INIT_RemapNamedModelElementToScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CStrongHandle< InfoForResourceTypeCModel > Model {
    get => ref _Handle.AsRef<CStrongHandle< InfoForResourceTypeCModel >>(Schema.GetOffset(0x4717248AE100C814));
  }
  public ref CUtlVector< CUtlString > Names {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0x4717248A0DA776AF));
  }
  public ref CUtlVector< float32 > Values {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x4717248AFBEDDADB));
  }
  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4717248AAE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4717248AE5729606));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x4717248AFB53C31E));
  }
  public ref bool ModelFromRenderer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4717248AAEBA1F25));
  }


}