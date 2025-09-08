using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayer_WeaponServices : IPlayer_WeaponServices {

  public IGameTime_t NextAttack { get; }
  
  public ref bool IsLookingAtWeapon { get; }
  
  public ref bool IsHoldingLookAtWeapon { get; }
  
  public ref CHandle<CBasePlayerWeapon> SavedWeapon { get; }
  
  public ref int TimeToMelee { get; }
  
  public ref int TimeToSecondary { get; }
  
  public ref int TimeToPrimary { get; }
  
  public ref int TimeToSniperRifle { get; }
  
  public ref bool IsBeingGivenItem { get; }
  
  public ref bool IsPickingUpItemWithUse { get; }
  
  public ref bool PickedUpWeapon { get; }
  
  public ref bool DisableAutoDeploy { get; }
  
  public ref bool IsPickingUpGroundWeapon { get; }
  
  public ref CUtlVector<byte> NetworkAnimTiming { get; }
  
  public ref bool BlockInspectUntilNextGraphUpdate { get; }
  
}