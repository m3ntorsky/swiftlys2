using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBasePlayerVData : IEntitySubclassVDataBase {

  public ISchemaUntypedField ModelName { get; }
  
  public ISkillFloat HeadDamageMultiplier { get; }
  
  public ISkillFloat ChestDamageMultiplier { get; }
  
  public ISkillFloat StomachDamageMultiplier { get; }
  
  public ISkillFloat ArmDamageMultiplier { get; }
  
  public ISkillFloat LegDamageMultiplier { get; }
  
  public ref float HoldBreathTime { get; }
  
  public ref float DrowningDamageInterval { get; }
  
  public ref int DrowningDamageInitial { get; }
  
  public ref int DrowningDamageMax { get; }
  
  public ref int WaterSpeed { get; }
  
  public ref float UseRange { get; }
  
  public ref float UseAngleTolerance { get; }
  
  public ref float CrouchTime { get; }
  
}