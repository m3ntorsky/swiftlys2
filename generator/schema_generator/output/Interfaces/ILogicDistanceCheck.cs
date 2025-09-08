using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicDistanceCheck : ILogicalEntity {

  public ref CUtlSymbolLarge EntityA { get; }
  
  public ref CUtlSymbolLarge EntityB { get; }
  
  public ref float Zone1Distance { get; }
  
  public ref float Zone2Distance { get; }
  
  public IEntityIOOutput InZone1 { get; }
  
  public IEntityIOOutput InZone2 { get; }
  
  public IEntityIOOutput InZone3 { get; }
  
}