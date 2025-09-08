using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ConstrainDistanceToPath : CParticleFunctionConstraint, IC_OP_ConstrainDistanceToPath {

  public C_OP_ConstrainDistanceToPath(nint handle) : base(handle) {
  }

  public ref float MinDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8146F787F016B7AC));
  }
  public ref float MaxDistance0 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8146F7876FFBC6F0));
  }
  public ref float MaxDistanceMid {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8146F7872D2B1E5A));
  }
  public ref float MaxDistance1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8146F78770FBC883));
  }
  public IPathParameters PathParameters {
    get => new CPathParameters(_Handle + Schema.GetOffset(0x8146F7878C111646));
  }
  public ref float TravelTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8146F7870228B67A));
  }
  public IParticleAttributeIndex_t FieldScale {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x8146F787BE94CE93));
  }
  public IParticleAttributeIndex_t ManualTField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x8146F7871190C51B));
  }


}