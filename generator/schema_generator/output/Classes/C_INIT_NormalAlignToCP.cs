using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_NormalAlignToCP : CParticleFunctionInitializer, IC_INIT_NormalAlignToCP {

  public C_INIT_NormalAlignToCP(nint handle) : base(handle) {
  }

  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xFA0441643A9ED669));
  }
  public ref ParticleControlPointAxis_t ControlPointAxis {
    get => ref _Handle.AsRef<ParticleControlPointAxis_t>(Schema.GetOffset(0xFA04416471763CFD));
  }


}