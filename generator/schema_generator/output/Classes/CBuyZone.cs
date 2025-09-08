using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBuyZone : CBaseTrigger, IBuyZone {

  public CBuyZone(nint handle) : base(handle) {
  }

  public ref int LegacyTeamNum {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB8D4DAC44C92565));
  }


}