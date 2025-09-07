using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundEventParameter : CBaseEntity, ISoundEventParameter {

  public CSoundEventParameter(nint handle) : base(handle) {
  }

  public CSoundEventParameter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge ParamName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xEFEED49AFF6F4311));
  }
  public ref float FloatValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEFEED49A80BDA558));
  }


}