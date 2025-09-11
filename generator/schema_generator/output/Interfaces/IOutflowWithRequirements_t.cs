using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IOutflowWithRequirements_t : ISchemaClass {

  
  public IPulse_OutflowConnection Connection { get; }
  
  public IPulseDocNodeID_t DestinationFlowNodeID { get; }
  
// CUtlVector< PulseDocNodeID_t >
  public ref CUtlVector RequirementNodeIDs { get; }
  
  public ref CUtlVector<int> CursorStateBlockIndex { get; }
}