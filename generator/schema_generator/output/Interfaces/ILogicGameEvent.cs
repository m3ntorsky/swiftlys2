using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicGameEvent : ILogicalEntity {

  
  public ref CUtlSymbolLarge EventName { get; }
}