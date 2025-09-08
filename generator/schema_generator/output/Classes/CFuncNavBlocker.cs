using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncNavBlocker : CBaseModelEntity, IFuncNavBlocker {

  public CFuncNavBlocker(nint handle) : base(handle) {
  }

  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3F066D113A7C5965));
  }
  public ref int BlockedTeamNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3F066D11B33D3543));
  }


}