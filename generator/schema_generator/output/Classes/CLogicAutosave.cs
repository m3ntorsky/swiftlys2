using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicAutosave : CLogicalEntity, ILogicAutosave {

  public CLogicAutosave(nint handle) : base(handle) {
  }

  public CLogicAutosave(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool ForceNewLevelUnit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE30CCBF21473BFDE));
  }
  public ref int MinHitPoints {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE30CCBF22C7E0C57));
  }
  public ref int MinHitPointsToCommit {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE30CCBF23AAC1C7F));
  }


}