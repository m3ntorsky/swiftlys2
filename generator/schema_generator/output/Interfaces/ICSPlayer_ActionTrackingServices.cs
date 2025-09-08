using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayer_ActionTrackingServices : IPlayerPawnComponent {

  public CHandle<IBasePlayerWeapon> LastWeaponBeforeC4AutoSwitch { get; }
  
  public ref bool IsRescuing { get; }
  
  public IWeaponPurchaseTracker_t WeaponPurchasesThisMatch { get; }
  
  public IWeaponPurchaseTracker_t WeaponPurchasesThisRound { get; }
  
}