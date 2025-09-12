using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPropDataComponent : IEntityComponent {

  
  public ref float DmgModBullet { get; }
  
  public ref float DmgModClub { get; }
  
  public ref float DmgModExplosive { get; }
  
  public ref float DmgModFire { get; }
  
  public ISchemaUntypedField PhysicsDamageTableName { get; }
  
  public ISchemaUntypedField BasePropData { get; }
  
  public ref int Interactions { get; }
  
  public ref bool SpawnMotionDisabled { get; }
  
  public ref int DisableTakePhysicsDamageSpawnFlag { get; }
  
  public ref int MotionDisabledSpawnFlag { get; }
}