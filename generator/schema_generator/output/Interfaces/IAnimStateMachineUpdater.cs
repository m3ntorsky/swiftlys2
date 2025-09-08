using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimStateMachineUpdater : ISchemaClass {

  public ref CUtlVector States { get; }
  
  public ref CUtlVector Transitions { get; }
  
  public ref int StartStateIndex { get; }
  
}