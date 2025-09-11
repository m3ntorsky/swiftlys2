using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicRelay : ILogicalEntity {

  
  public ref bool Disabled { get; }
  
  public ref bool WaitForRefire { get; }
  
  public ref bool TriggerOnce { get; }
  
  public ref bool FastRetrigger { get; }
  
  public ref bool PassthoughCaller { get; }
}