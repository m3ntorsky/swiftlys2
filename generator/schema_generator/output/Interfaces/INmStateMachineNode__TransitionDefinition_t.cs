using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmStateMachineNode__TransitionDefinition_t : ISchemaClass {

  public ref short TargetStateIdx { get; }
  
  public ref short ConditionNodeIdx { get; }
  
  public ref short TransitionNodeIdx { get; }
  
  public ref bool CanBeForced { get; }
  
}