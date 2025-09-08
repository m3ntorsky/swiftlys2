using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInfoGameEventProxy : IPointEntity {

  public ref CUtlSymbolLarge EventName { get; }
  
  public ref float Range { get; }
  
}