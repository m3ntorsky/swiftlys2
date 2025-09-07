using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PhysSoftbodyDesc_t : SchemaClass, IPhysSoftbodyDesc_t {

  public PhysSoftbodyDesc_t(nint handle) : base(handle) {
  }

  public PhysSoftbodyDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< uint32 > ParticleBoneHash {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0xD390C8BBCC44F471));
  }
  public ref CUtlVector< RnSoftbodyParticle_t > Particles {
    get => ref _Handle.AsRef<CUtlVector< RnSoftbodyParticle_t >>(Schema.GetOffset(0xD390C8BB6C0747A4));
  }
  public ref CUtlVector< RnSoftbodySpring_t > Springs {
    get => ref _Handle.AsRef<CUtlVector< RnSoftbodySpring_t >>(Schema.GetOffset(0xD390C8BB1AB5EB4D));
  }
  public ref CUtlVector< RnSoftbodyCapsule_t > Capsules {
    get => ref _Handle.AsRef<CUtlVector< RnSoftbodyCapsule_t >>(Schema.GetOffset(0xD390C8BBFC27BB2D));
  }
  public ref CUtlVector< CTransform > InitPose {
    get => ref _Handle.AsRef<CUtlVector< CTransform >>(Schema.GetOffset(0xD390C8BB5E468732));
  }
  public ref CUtlVector< CUtlString > ParticleBoneName {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0xD390C8BB8D321086));
  }


}