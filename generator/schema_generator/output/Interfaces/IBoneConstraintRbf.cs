using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBoneConstraintRbf : IBoneConstraintBase {

  public ref CUtlVector InputBones { get; }
  
  public ref CUtlVector OutputBones { get; }
  
}