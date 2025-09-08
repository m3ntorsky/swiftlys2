using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISSDSMsg_LayerBase : ISchemaClass {

  public ISceneViewId_t ViewId { get; }
  
  public ref CUtlString ViewName { get; }
  
  public ref ulong LayerId { get; }
  
  public ref CUtlString LayerName { get; }
  
  public ref CUtlString DisplayText { get; }
  
}