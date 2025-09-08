using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INodeData_t : ISchemaClass {

  public ref int Parent { get; }
  
  public ref Vector Origin { get; }
  
  public ref Vector MinBounds { get; }
  
  public ref Vector MaxBounds { get; }
  
  public ref float MinimumDistance { get; }
  
  public ref CUtlVector<int> ChildNodeIndices { get; }
  
  public ref CUtlString WorldNodePrefix { get; }
  
}