using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWeaponTaser : ICSWeaponBaseGun {

  public IGameTime_t FireTime { get; }
  
  public ref int LastAttackTick { get; }
  
}