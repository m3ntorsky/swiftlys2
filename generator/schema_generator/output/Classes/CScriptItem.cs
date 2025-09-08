using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CScriptItem : CItem, IScriptItem {

  public CScriptItem(nint handle) : base(handle) {
  }

  public ref MoveType_t MoveTypeOverride {
    get => ref _Handle.AsRef<MoveType_t>(Schema.GetOffset(0x501D9DD2B4DC8A64));
  }


}