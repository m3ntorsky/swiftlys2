using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSWeaponBaseGun : ICSWeaponBase {

  
  public ref int ZoomLevel { get; }
  
  public ref int BurstShotsRemaining { get; }
  
  public ref int SilencedModelIndex { get; }
  
  public ref bool InPrecache { get; }
  
  public ref bool NeedsBoltAction { get; }
  
  public ref int RevolverCylinderIdx { get; }
  
  public ref bool SkillReloadAvailable { get; }
  
  public ref bool SkillReloadLiftedReloadKey { get; }
  
  public ref bool SkillBoltInterruptAvailable { get; }
  
  public ref bool SkillBoltLiftedFireKey { get; }
}