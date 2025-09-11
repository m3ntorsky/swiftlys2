using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicGameEventListener : ILogicalEntity {

  
  public IEntityIOOutput OnEventFired { get; }
  
  public ref CUtlSymbolLarge GameEventName { get; }
  
  public ref CUtlSymbolLarge GameEventItem { get; }
  
  public ref bool Enabled { get; }
  
  public ref bool StartDisabled { get; }
}