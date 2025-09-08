using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseCSGrenade : ICSWeaponBase {

  public ref bool Redraw { get; }
  
  public ref bool IsHeldByPlayer { get; }
  
  public ref bool PinPulled { get; }
  
  public ref bool JumpThrow { get; }
  
  public ref bool ThrowAnimating { get; }
  
  public IGameTime_t ThrowTime { get; }
  
  public ref float ThrowStrength { get; }
  
  public IGameTime_t DropTime { get; }
  
  public IGameTime_t PinPullTime { get; }
  
  public ref bool JustPulledPin { get; }
  
  public IGameTick_t NextHoldTick { get; }
  
  public ref float NextHoldFrac { get; }
  
  public CHandle<ICSWeaponBase> SwitchToWeaponAfterThrow { get; }
  
}