using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvSplash : CPointEntity, IEnvSplash {

  public CEnvSplash(nint handle) : base(handle) {
  }

  public CEnvSplash(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7DD98956B731A42F));
  }


}