using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBtActionCombatPositioning : CBtNode, IBtActionCombatPositioning {

  public CBtActionCombatPositioning(nint handle) : base(handle) {
  }

  public CBtActionCombatPositioning(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString SensorInputKey {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x3FB29123D2B0D4C1));
  }
  public ref CUtlString IsAttackingKey {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x3FB29123BFC6462B));
  }
  public ICountdownTimer ActionTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x3FB291238777F414));
  }
  public ref bool Crouching {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3FB291232DA51BAD));
  }


}