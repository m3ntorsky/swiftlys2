using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBoneConstraintRbf : IBoneConstraintBase {

  
// CUtlVector< std::pair< CUtlString, uint32 > >
  public ref CUtlVector InputBones { get; }
  
// CUtlVector< std::pair< CUtlString, uint32 > >
  public ref CUtlVector OutputBones { get; }
}