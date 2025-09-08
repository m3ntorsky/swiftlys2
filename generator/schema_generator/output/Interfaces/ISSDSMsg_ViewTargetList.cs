using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISSDSMsg_ViewTargetList : ISchemaClass {

  public ISceneViewId_t ViewId { get; }
  
  public ref CUtlString ViewName { get; }
  
  public ref CUtlVector Targets { get; }
  
}