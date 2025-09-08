using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlayer_WeaponServices : IPlayerPawnComponent {

  public ref CUtlVector<CHandle<CBasePlayerWeapon>> MyWeapons { get; }
  
  public ref CHandle<CBasePlayerWeapon> ActiveWeapon { get; }
  
  public ref CHandle<CBasePlayerWeapon> LastWeapon { get; }
  
  public ISchemaFixedArray<ushort> Ammo { get; }
  
  public ref bool PreventWeaponPickup { get; }
  
}