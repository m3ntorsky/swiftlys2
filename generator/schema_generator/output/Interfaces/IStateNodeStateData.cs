using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStateNodeStateData : ISchemaClass {

  public IAnimUpdateNodeRef Child { get; }
  
  public ISchemaUntypedField ExclusiveRootMotion { get; }
  
  public ISchemaUntypedField ExclusiveRootMotionFirstFrame { get; }
  
}