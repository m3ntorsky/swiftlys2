using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_PinParticleToCP : CParticleFunctionOperator, IC_OP_PinParticleToCP {

  public C_OP_PinParticleToCP(nint handle) : base(handle) {
  }

  public C_OP_PinParticleToCP(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE4FC73983F31A6BD));
  }
  public IParticleCollectionVecInput Offset {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xE4FC7398BD25CC2A));
  }
  public ref bool OffsetLocal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE4FC7398F07D31C1));
  }
  public ref ParticleSelection_t ParticleSelection {
    get => ref _Handle.AsRef<ParticleSelection_t>(Schema.GetOffset(0xE4FC7398A2307EA7));
  }
  public IParticleCollectionFloatInput ParticleNumber {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xE4FC739812F26402));
  }
  public ref ParticlePinDistance_t PinBreakType {
    get => ref _Handle.AsRef<ParticlePinDistance_t>(Schema.GetOffset(0xE4FC73981D66F607));
  }
  public IParticleCollectionFloatInput BreakDistance {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xE4FC7398AD760DA9));
  }
  public IParticleCollectionFloatInput BreakSpeed {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xE4FC739817DB9AD5));
  }
  public IParticleCollectionFloatInput Age {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xE4FC73984F7B4AF6));
  }
  public ref int BreakControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE4FC739817C1EFA0));
  }
  public ref int BreakControlPointNumber2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE4FC7398F84C22D6));
  }
  public IParticleCollectionFloatInput BreakValue {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xE4FC7398D120F44B));
  }
  public IPerParticleFloatInput Interpolation {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xE4FC7398CF55B987));
  }
  public ref bool RetainInitialVelocity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE4FC73981B3893D3));
  }


}