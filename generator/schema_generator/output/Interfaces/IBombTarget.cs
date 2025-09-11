using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBombTarget : IBaseTrigger {

  
  public IEntityIOOutput OnBombExplode { get; }
  
  public IEntityIOOutput OnBombPlanted { get; }
  
  public IEntityIOOutput OnBombDefused { get; }
  
  public ref bool IsBombSiteB { get; }
  
  public ref bool IsHeistBombTarget { get; }
  
  public ref bool BombPlantedHere { get; }
  
  public ref CUtlSymbolLarge MountTarget { get; }
  
  public ref CHandle<CBaseEntity> InstructorHint { get; }
  
  public ref int BombSiteDesignation { get; }
}