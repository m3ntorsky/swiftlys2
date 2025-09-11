using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerMultiple : IBaseTrigger {

  
  public IEntityIOOutput OnTrigger { get; }
}