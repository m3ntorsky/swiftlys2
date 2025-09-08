using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_MovementMoveAlongSkinnedCPSnapshot : CParticleFunctionOperator, IC_OP_MovementMoveAlongSkinnedCPSnapshot {

  public C_OP_MovementMoveAlongSkinnedCPSnapshot(nint handle) : base(handle) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBF34A6C93F31A6BD));
  }
  public ref int SnapshotControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBF34A6C929D3EEDD));
  }
  public ref bool SetNormal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBF34A6C9542722AC));
  }
  public ref bool SetRadius {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBF34A6C9918808D1));
  }
  public IPerParticleFloatInput Interpolation {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xBF34A6C9CF55B987));
  }
  public IPerParticleFloatInput TValue {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xBF34A6C9B4CE908E));
  }


}