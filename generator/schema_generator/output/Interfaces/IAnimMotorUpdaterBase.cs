using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimMotorUpdaterBase : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref bool Default { get; }
}