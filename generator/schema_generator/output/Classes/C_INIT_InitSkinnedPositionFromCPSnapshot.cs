using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_InitSkinnedPositionFromCPSnapshot : CParticleFunctionInitializer, IC_INIT_InitSkinnedPositionFromCPSnapshot {

  public C_INIT_InitSkinnedPositionFromCPSnapshot(nint handle) : base(handle) {
  }

  public ref int SnapshotControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD1B6E41429D3EEDD));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD1B6E4143F31A6BD));
  }
  public ref bool Random {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD1B6E414D13B9DC2));
  }
  public ref int RandomSeed {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD1B6E4146388F067));
  }
  public ref bool Rigid {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD1B6E414F9ED9C8C));
  }
  public ref bool SetNormal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD1B6E414542722AC));
  }
  public ref bool IgnoreDt {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD1B6E414330C0603));
  }
  public ref float MinNormalVelocity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD1B6E414C1D5AB05));
  }
  public ref float MaxNormalVelocity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD1B6E4147D5C16C3));
  }
  public ref SnapshotIndexType_t IndexType {
    get => ref _Handle.AsRef<SnapshotIndexType_t>(Schema.GetOffset(0xD1B6E414DEEB271F));
  }
  public IPerParticleFloatInput ReadIndex {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xD1B6E4147E9602C9));
  }
  public ref float Increment {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD1B6E414B3721674));
  }
  public ref int FullLoopIncrement {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD1B6E414278D3497));
  }
  public ref int SnapShotStartPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD1B6E414A7DF116B));
  }
  public ref float BoneVelocity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD1B6E414B06BD382));
  }
  public ref float BoneVelocityMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD1B6E41434585F64));
  }
  public ref bool CopyColor {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD1B6E41429F0EAEB));
  }
  public ref bool CopyAlpha {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD1B6E41443B2B278));
  }
  public ref bool SetRadius {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD1B6E414918808D1));
  }


}