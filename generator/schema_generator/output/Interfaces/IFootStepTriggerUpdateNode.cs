using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootStepTriggerUpdateNode : IUnaryUpdateNode {

  
// CUtlVector< FootStepTrigger >
  public ref CUtlVector Triggers { get; }
  
  public ref float Tolerance { get; }
}