using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderSound : CParticleFunctionRenderer, IC_OP_RenderSound {

  public C_OP_RenderSound(nint handle) : base(handle) {
  }

  public C_OP_RenderSound(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float DurationScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBDBBFDFC776D4203));
  }
  public ref float SndLvlScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBDBBFDFC19AAA97E));
  }
  public ref float PitchScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBDBBFDFCBBEE57F3));
  }
  public ref float VolumeScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBDBBFDFCDFBFD5FD));
  }
  public IParticleAttributeIndex_t SndLvlField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xBDBBFDFC17E2BD46));
  }
  public IParticleAttributeIndex_t DurationField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xBDBBFDFCB21EDAAB));
  }
  public IParticleAttributeIndex_t PitchField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xBDBBFDFC6E37791F));
  }
  public IParticleAttributeIndex_t VolumeField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xBDBBFDFC3F07D465));
  }
  public ref int Channel {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBDBBFDFCC4CD80F8));
  }
  public ref int CPReference {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBDBBFDFC1349FFE7));
  }
  public ISchemaFixedString SoundName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xBDBBFDFC26D82A1A));
  }
  public ref bool SuppressStopSoundEvent {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBDBBFDFC76AD7797));
  }


}