using SwiftlyS2.Core.EntitySystem;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Scheduler;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayer_WeaponServicesImpl {

  public void DropWeapon(CBasePlayerWeapon weapon) {
    GameFunctions.CCSPlayer_WeaponServices_DropWeapon(Address, weapon.Address);
  }

  public void RemoveWeapon(CBasePlayerWeapon weapon) {
    GameFunctions.CCSPlayer_WeaponServices_DropWeapon(Address, weapon.Address);
    weapon.Despawn();
  }

  public void SelectWeapon(CBasePlayerWeapon weapon) {
    GameFunctions.CCSPlayer_WeaponServices_SelectWeapon(Address, weapon.Address);
  }

  public void DropWeaponByClass<T>() where T : CBasePlayerWeapon {
    var name = EntitySystemService.TypeToDesignerName[typeof(T)];
    MyWeapons.ToList().ForEach(weapon => {
      if (weapon.Value?.Entity?.DesignerName == name) {
        DropWeapon(weapon.Value);
      }
    });
  }

  public void RemoveWeaponByClass<T>() where T : CBasePlayerWeapon {
    var name = EntitySystemService.TypeToDesignerName[typeof(T)];
    MyWeapons.ToList().ForEach(weapon => {
      if (weapon.Value?.Entity?.DesignerName == name) {
        RemoveWeapon(weapon.Value);
      }
    });
  }

  public void SelectWeaponByClass<T>() where T : CBasePlayerWeapon {
    var name = EntitySystemService.TypeToDesignerName[typeof(T)];
    MyWeapons.ToList().ForEach(weapon => {
      if (weapon.Value?.Entity?.DesignerName == name) {
        SelectWeapon(weapon.Value);
        return;
      }
    });
  }

}