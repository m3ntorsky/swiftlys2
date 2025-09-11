using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseConstraint : IBoneConstraintBase {

  
  public ref CUtlString Name { get; }
  
  public ref Vector UpVector { get; }
  
  public ref CUtlLeanVector<CConstraintSlave> Slaves { get; }
  
// CUtlVector< CConstraintTarget >
  public ref CUtlVector Targets { get; }
}