using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSingleplayRules : CGameRules, ISingleplayRules {

  public CSingleplayRules(nint handle) : base(handle) {
  }

  public CSingleplayRules(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool SinglePlayerGameEnding {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x633D071BAD9EAF1D));
  }


}