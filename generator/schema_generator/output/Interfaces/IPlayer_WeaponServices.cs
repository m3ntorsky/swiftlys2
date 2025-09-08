using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlayer_WeaponServices : IPlayerPawnComponent {

  public ref CUtlVector MyWeapons { get; }
  
  public CHandle<IBasePlayerWeapon> ActiveWeapon { get; }
  
  public CHandle<IBasePlayerWeapon> LastWeapon { get; }
  
  public ISchemaFixedArray<ushort> Ammo { get; }
  
  public ref bool PreventWeaponPickup { get; }
  
}