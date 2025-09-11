using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBasePlayerWeapon : IEconEntity {

  
  public IGameTick_t NextPrimaryAttackTick { get; }
  
  public ref float NextPrimaryAttackTickRatio { get; }
  
  public IGameTick_t NextSecondaryAttackTick { get; }
  
  public ref float NextSecondaryAttackTickRatio { get; }
  
  public ref int Clip1 { get; }
  
  public ref int Clip2 { get; }
  
  public ISchemaFixedArray<int> ReserveAmmo { get; }
  
  public IEntityIOOutput OnPlayerUse { get; }
}