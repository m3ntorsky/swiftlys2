using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_MovementSkinnedPositionFromCPSnapshot : CParticleFunctionOperator, IC_OP_MovementSkinnedPositionFromCPSnapshot {

  public C_OP_MovementSkinnedPositionFromCPSnapshot(nint handle) : base(handle) {
  }

  public C_OP_MovementSkinnedPositionFromCPSnapshot(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int SnapshotControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6BA7A3C29D3EEDD));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6BA7A3C3F31A6BD));
  }
  public ref bool Random {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6BA7A3CD13B9DC2));
  }
  public ref int RandomSeed {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6BA7A3C6388F067));
  }
  public ref bool SetNormal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6BA7A3C542722AC));
  }
  public ref bool SetRadius {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6BA7A3C918808D1));
  }
  public ref SnapshotIndexType_t IndexType {
    get => ref _Handle.AsRef<SnapshotIndexType_t>(Schema.GetOffset(0x6BA7A3CDEEB271F));
  }
  public IPerParticleFloatInput ReadIndex {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x6BA7A3C7E9602C9));
  }
  public IParticleCollectionFloatInput Increment {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x6BA7A3CB3721674));
  }
  public IParticleCollectionFloatInput FullLoopIncrement {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x6BA7A3C278D3497));
  }
  public IParticleCollectionFloatInput SnapShotStartPoint {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x6BA7A3CA7DF116B));
  }
  public IPerParticleFloatInput Interpolation {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x6BA7A3CCF55B987));
  }


}