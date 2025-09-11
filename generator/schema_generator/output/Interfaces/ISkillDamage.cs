using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISkillDamage : ISchemaClass {

  
  public ISkillFloat Damage { get; }
  
  public ref float NPCDamageScalarVsNPC { get; }
  
  public ref float PhysicsForceDamage { get; }
}