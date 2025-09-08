using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetFromCPSnapshot : CParticleFunctionOperator, IC_OP_SetFromCPSnapshot {

  public C_OP_SetFromCPSnapshot(nint handle) : base(handle) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5B4435183F31A6BD));
  }
  public ref CUtlString StrSnapshotSubset {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x5B443518BD8A8E5E));
  }
  public IParticleAttributeIndex_t AttributeToRead {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x5B443518E0F61F9E));
  }
  public IParticleAttributeIndex_t AttributeToWrite {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x5B443518389A3CC1));
  }
  public ref int LocalSpaceCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5B443518C8E9CB31));
  }
  public ref bool Random {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5B443518D13B9DC2));
  }
  public ref bool Reverse {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5B443518EA4E22E5));
  }
  public ref int RandomSeed {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5B4435186388F067));
  }
  public IParticleCollectionFloatInput SnapShotStartPoint {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x5B443518A7DF116B));
  }
  public IParticleCollectionFloatInput SnapShotIncrement {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x5B443518C1AED602));
  }
  public IPerParticleFloatInput Interpolation {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x5B443518CF55B987));
  }
  public ref bool SubSample {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5B4435185021E837));
  }
  public ref bool Prev {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5B4435189E5B9F10));
  }


}