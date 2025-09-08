using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapSDFDistanceToVectorAttribute : CParticleFunctionOperator, IC_OP_RemapSDFDistanceToVectorAttribute {

  public C_OP_RemapSDFDistanceToVectorAttribute(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t VectorFieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x11284F6408261D8B));
  }
  public IParticleAttributeIndex_t VectorFieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x11284F64588D910E));
  }
  public IParticleCollectionFloatInput MinDistance {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x11284F6492BCAD06));
  }
  public IParticleCollectionFloatInput MaxDistance {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x11284F6498893360));
  }
  public ref Vector ValueBelowMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x11284F64D483132D));
  }
  public ref Vector ValueAtMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x11284F645FAB2125));
  }
  public ref Vector ValueAtMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x11284F6469BEB89B));
  }
  public ref Vector ValueAboveMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x11284F646976A65F));
  }


}