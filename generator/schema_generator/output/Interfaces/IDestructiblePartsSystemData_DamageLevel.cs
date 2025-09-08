using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDestructiblePartsSystemData_DamageLevel : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public ref CGlobalSymbol BreakablePieceName { get; }
  
  public ref int BodyGroupValue { get; }
  
  public ISkillInt Health { get; }
  
  public ref EDestructiblePartDamagePassThroughType DamagePassthroughType { get; }
  
  public ref DestructiblePartDestructionDeathBehavior_t DestructionDeathBehavior { get; }
  
  public ref CGlobalSymbol CustomDeathHandshake { get; }
  
  public ref bool ShouldDestroyOnDeath { get; }
  
  public IRangeFloat DeathDestroyTime { get; }
  
}