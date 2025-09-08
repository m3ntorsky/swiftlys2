using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicEventListener : ILogicalEntity {

  public ref CUtlString StrEventName { get; }
  
  public ref bool IsEnabled { get; }
  
  public ref int Team { get; }
  
  public IEntityIOOutput OnEventFired { get; }
  
}