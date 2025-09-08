using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RepeatedTriggerChildGroup : CParticleFunctionPreEmission, IC_OP_RepeatedTriggerChildGroup {

  public C_OP_RepeatedTriggerChildGroup(nint handle) : base(handle) {
  }

  public ref int ChildGroupID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3D9A0D4E3F3C965));
  }
  public IParticleCollectionFloatInput ClusterRefireTime {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x3D9A0D47E6BEEAB));
  }
  public IParticleCollectionFloatInput ClusterSize {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x3D9A0D4A7549FF6));
  }
  public IParticleCollectionFloatInput ClusterCooldown {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x3D9A0D4753687EA));
  }
  public ref bool LimitChildCount {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3D9A0D4EA978249));
  }


}