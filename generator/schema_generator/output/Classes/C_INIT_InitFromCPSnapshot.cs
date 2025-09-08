using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_InitFromCPSnapshot : CParticleFunctionInitializer, IC_INIT_InitFromCPSnapshot {

  public C_INIT_InitFromCPSnapshot(nint handle) : base(handle) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x772EF71B3F31A6BD));
  }
  public ref CUtlString StrSnapshotSubset {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x772EF71BBD8A8E5E));
  }
  public IParticleAttributeIndex_t AttributeToRead {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x772EF71BE0F61F9E));
  }
  public IParticleAttributeIndex_t AttributeToWrite {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x772EF71B389A3CC1));
  }
  public ref int LocalSpaceCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x772EF71BC8E9CB31));
  }
  public ref bool Random {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x772EF71BD13B9DC2));
  }
  public ref bool Reverse {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x772EF71BEA4E22E5));
  }
  public IParticleCollectionFloatInput SnapShotIncrement {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x772EF71BC1AED602));
  }
  public IPerParticleFloatInput ManualSnapshotIndex {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x772EF71BA02E904D));
  }
  public ref int RandomSeed {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x772EF71B6388F067));
  }
  public ref bool LocalSpaceAngles {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x772EF71BF571F352));
  }


}