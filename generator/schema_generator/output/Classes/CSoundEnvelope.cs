using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundEnvelope : SchemaClass, ISoundEnvelope {

  public CSoundEnvelope(nint handle) : base(handle) {
  }

  public CSoundEnvelope(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Current {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDF974C315AD334FA));
  }
  public ref float Target {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDF974C31FA08A9E8));
  }
  public ref float Rate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDF974C316C5ECD07));
  }
  public ref bool Forceupdate {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDF974C3131B01C25));
  }


}