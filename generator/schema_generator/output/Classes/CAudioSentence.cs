using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAudioSentence : SchemaClass, IAudioSentence {

  public CAudioSentence(nint handle) : base(handle) {
  }

  public CAudioSentence(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool ShouldVoiceDuck {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x25F8D719C546CD15));
  }
  public ref CUtlVector< CAudioPhonemeTag > RunTimePhonemes {
    get => ref _Handle.AsRef<CUtlVector< CAudioPhonemeTag >>(Schema.GetOffset(0x25F8D719C0434838));
  }
  public ref CUtlVector< CAudioEmphasisSample > EmphasisSamples {
    get => ref _Handle.AsRef<CUtlVector< CAudioEmphasisSample >>(Schema.GetOffset(0x25F8D7194EBE8F82));
  }
  public IAudioMorphData MorphData {
    get => new CAudioMorphData(_Handle + Schema.GetOffset(0x25F8D719A8207F65));
  }


}