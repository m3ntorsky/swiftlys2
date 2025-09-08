using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CReplicationParameters : SchemaClass, IReplicationParameters {

  public CReplicationParameters(nint handle) : base(handle) {
  }

  public ref ParticleReplicationMode_t ReplicationMode {
    get => ref _Handle.AsRef<ParticleReplicationMode_t>(Schema.GetOffset(0xFA909F20C8967832));
  }
  public ref bool ScaleChildParticleRadii {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFA909F207842F3CC));
  }
  public IParticleCollectionFloatInput MinRandomRadiusScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xFA909F208CBF88EE));
  }
  public IParticleCollectionFloatInput MaxRandomRadiusScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xFA909F2022697B5C));
  }
  public IParticleCollectionVecInput MinRandomDisplacement {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xFA909F20808FB77F));
  }
  public IParticleCollectionVecInput MaxRandomDisplacement {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xFA909F20FF279F49));
  }
  public IParticleCollectionFloatInput ModellingScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xFA909F20BE93B72A));
  }


}