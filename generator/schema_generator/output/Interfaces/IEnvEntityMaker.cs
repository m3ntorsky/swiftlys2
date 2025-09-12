using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvEntityMaker : IPointEntity {

  
  public ref Vector EntityMins { get; }
  
  public ref Vector EntityMaxs { get; }
  
  public ref CHandle<CBaseEntity> CurrentInstance { get; }
  
  public ref CHandle<CBaseEntity> CurrentBlocker { get; }
  
  public ref Vector BlockerOrigin { get; }
  
  public ref QAngle PostSpawnDirection { get; }
  
  public ref float PostSpawnDirectionVariance { get; }
  
  public ref float PostSpawnSpeed { get; }
  
  public ref bool PostSpawnUseAngles { get; }
  
  public ISchemaUntypedField Template { get; }
  
  public IEntityIOOutput OutputOnSpawned { get; }
  
  public IEntityIOOutput OutputOnFailedSpawn { get; }
}