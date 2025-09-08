using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderScreenShake : CParticleFunctionRenderer, IC_OP_RenderScreenShake {

  public C_OP_RenderScreenShake(nint handle) : base(handle) {
  }

  public ref float DurationScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x37508849776D4203));
  }
  public ref float RadiusScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x37508849A7A20159));
  }
  public ref float FrequencyScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x375088494B5C34F7));
  }
  public ref float AmplitudeScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x37508849BF90DF5A));
  }
  public IParticleAttributeIndex_t RadiusField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x375088494B15FC11));
  }
  public IParticleAttributeIndex_t DurationField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x37508849B21EDAAB));
  }
  public IParticleAttributeIndex_t FrequencyField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x37508849DDA055AF));
  }
  public IParticleAttributeIndex_t AmplitudeField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x37508849F8F54FD2));
  }
  public ref int FilterCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x375088499304E130));
  }


}