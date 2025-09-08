using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionNode : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public IAnimNodeID Id { get; }
  
}