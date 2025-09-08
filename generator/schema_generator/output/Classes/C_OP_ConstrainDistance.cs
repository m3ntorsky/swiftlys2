using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ConstrainDistance : CParticleFunctionConstraint, IC_OP_ConstrainDistance {

  public C_OP_ConstrainDistance(nint handle) : base(handle) {
  }

  public IParticleCollectionFloatInput MinDistance {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xDF3E3FA1F016B7AC));
  }
  public IParticleCollectionFloatInput MaxDistance {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xDF3E3FA1844E396A));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDF3E3FA13F31A6BD));
  }
  public ref Vector CenterOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDF3E3FA108F7D41F));
  }
  public ref bool GlobalCenter {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDF3E3FA1196669C3));
  }


}