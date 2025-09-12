using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicAuto : IBaseEntity {

  
  public IEntityIOOutput OnMapSpawn { get; }
  
  public IEntityIOOutput OnDemoMapSpawn { get; }
  
  public IEntityIOOutput OnNewGame { get; }
  
  public IEntityIOOutput OnLoadGame { get; }
  
  public IEntityIOOutput OnMapTransition { get; }
  
  public IEntityIOOutput OnBackgroundMap { get; }
  
  public IEntityIOOutput OnMultiNewMap { get; }
  
  public IEntityIOOutput OnMultiNewRound { get; }
  
  public IEntityIOOutput OnVREnabled { get; }
  
  public IEntityIOOutput OnVRNotEnabled { get; }
  
  public ISchemaUntypedField Globalstate { get; }
}