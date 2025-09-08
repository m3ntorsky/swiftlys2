using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseGraphExecutionHistoryCursorDesc_t : SchemaClass, IPulseGraphExecutionHistoryCursorDesc_t {

  public PulseGraphExecutionHistoryCursorDesc_t(nint handle) : base(handle) {
  }

  public ref CUtlVector AncestorCursorIDs {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xC94C4C1C39FD1094));
  }
  public IPulseDocNodeID_t SpawnNodeID {
    get => new PulseDocNodeID_t(_Handle + Schema.GetOffset(0xC94C4C1C95FE4E15));
  }
  public IPulseDocNodeID_t RetiredAtNodeID {
    get => new PulseDocNodeID_t(_Handle + Schema.GetOffset(0xC94C4C1C7FD10E42));
  }
  public ref float LastReferenced {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC94C4C1C22F5B0C8));
  }
  public ref int LastValidEntryIdx {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC94C4C1CBFAF995E));
  }


}