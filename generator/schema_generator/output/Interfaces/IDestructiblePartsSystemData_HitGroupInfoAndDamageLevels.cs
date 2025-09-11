using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDestructiblePartsSystemData_HitGroupInfoAndDamageLevels : ISchemaClass {

  
  public ref CGlobalSymbol DebugName { get; }
  
  public ref HitGroup_t HitGroup { get; }
  
  public ref bool DisableHitGroupWhenDestroyed { get; }
  
  public ref CUtlVector<HitGroup_t> OtherHitgroupsToDestroyWhenFullyDestructed { get; }
  
  public ref bool OnlyDestroyWhenGibbing { get; }
  
  public ref CGlobalSymbol BodyGroupName { get; }
  
// CUtlVector< CDestructiblePartsSystemData_DamageLevel >
  public ref CUtlVector DamageLevels { get; }
}