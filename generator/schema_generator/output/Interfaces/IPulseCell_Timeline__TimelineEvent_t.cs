using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Timeline__TimelineEvent_t : ISchemaClass {

  
  public ref float TimeFromPrevious { get; }
  
  public IPulse_OutflowConnection EventOutflow { get; }
}