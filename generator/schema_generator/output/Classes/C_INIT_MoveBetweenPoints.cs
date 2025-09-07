using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_MoveBetweenPoints : CParticleFunctionInitializer, IC_INIT_MoveBetweenPoints {

  public C_INIT_MoveBetweenPoints(nint handle) : base(handle) {
  }

  public C_INIT_MoveBetweenPoints(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleFloatInput SpeedMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xE2F19642B52776BE));
  }
  public IPerParticleFloatInput SpeedMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xE2F19642C7140B5C));
  }
  public IPerParticleFloatInput EndSpread {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xE2F196423D9143DB));
  }
  public IPerParticleFloatInput StartOffset {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xE2F1964269A449AA));
  }
  public IPerParticleFloatInput EndOffset {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xE2F19642C863E027));
  }
  public ref int EndControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE2F19642A9FAEC22));
  }
  public ref bool TrailBias {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE2F1964294C9A26A));
  }


}