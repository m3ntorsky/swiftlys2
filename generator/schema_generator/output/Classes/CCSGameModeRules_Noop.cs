using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGameModeRules_Noop : CCSGameModeRules, ICSGameModeRules_Noop {

  public CCSGameModeRules_Noop(nint handle) : base(handle) {
  }

  public CCSGameModeRules_Noop(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}