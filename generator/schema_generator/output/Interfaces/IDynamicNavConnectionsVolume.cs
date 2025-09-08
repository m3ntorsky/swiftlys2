using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDynamicNavConnectionsVolume : ITriggerMultiple {

  public ref CUtlSymbolLarge ConnectionTarget { get; }
  
  public ref CUtlVector Connections { get; }
  
  public ref CGlobalSymbol TransitionType { get; }
  
  public ref bool ConnectionsEnabled { get; }
  
  public ref float TargetAreaSearchRadius { get; }
  
  public ref float UpdateDistance { get; }
  
  public ref float MaxConnectionDistance { get; }
  
}