using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootStepTrigger : ISchemaClass {

  
  public ref CUtlVector<int> Tags { get; }
  
  public ref int FootIndex { get; }
  
  public ref StepPhase TriggerPhase { get; }
}