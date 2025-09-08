using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderVRHapticEvent : CParticleFunctionRenderer, IC_OP_RenderVRHapticEvent {

  public C_OP_RenderVRHapticEvent(nint handle) : base(handle) {
  }

  public ref ParticleVRHandChoiceList_t Hand {
    get => ref _Handle.AsRef<ParticleVRHandChoiceList_t>(Schema.GetOffset(0xB83C5242D49ECB4C));
  }
  public ref int OutputHandCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB83C52428D35D26A));
  }
  public ref int OutputField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB83C5242324F6F74));
  }
  public IPerParticleFloatInput Amplitude {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xB83C5242B44B0E18));
  }


}