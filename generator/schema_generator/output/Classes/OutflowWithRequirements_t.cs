using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class OutflowWithRequirements_t : SchemaClass, IOutflowWithRequirements_t {

  public OutflowWithRequirements_t(nint handle) : base(handle) {
  }

  public OutflowWithRequirements_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulse_OutflowConnection Connection {
    get => new CPulse_OutflowConnection(_Handle + Schema.GetOffset(0x5BFC4DD4D4CD5F59));
  }
  public IPulseDocNodeID_t DestinationFlowNodeID {
    get => new PulseDocNodeID_t(_Handle + Schema.GetOffset(0x5BFC4DD4C986A186));
  }
  public ref CUtlVector< PulseDocNodeID_t > RequirementNodeIDs {
    get => ref _Handle.AsRef<CUtlVector< PulseDocNodeID_t >>(Schema.GetOffset(0x5BFC4DD47DAC9EFE));
  }
  public ref CUtlVector< int32 > CursorStateBlockIndex {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0x5BFC4DD46CECC07B));
  }


}