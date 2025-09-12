using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInfoSpawnGroupLoadUnload : ILogicalEntity {

  
  public IEntityIOOutput OnSpawnGroupLoadStarted { get; }
  
  public IEntityIOOutput OnSpawnGroupLoadFinished { get; }
  
  public IEntityIOOutput OnSpawnGroupUnloadStarted { get; }
  
  public IEntityIOOutput OnSpawnGroupUnloadFinished { get; }
  
  public ISchemaUntypedField SpawnGroupName { get; }
  
  public ISchemaUntypedField SpawnGroupFilterName { get; }
  
  public ISchemaUntypedField LandmarkName { get; }
  
  public ref CUtlString FixedSpawnGroupName { get; }
  
  public ref float TimeoutInterval { get; }
  
  public ref bool AutoActivate { get; }
  
  public ref bool UnloadingStarted { get; }
  
  public ref bool QueueActiveSpawnGroupChange { get; }
  
  public ref bool QueueFinishLoading { get; }
}