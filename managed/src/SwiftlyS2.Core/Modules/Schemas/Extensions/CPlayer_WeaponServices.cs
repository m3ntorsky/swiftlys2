namespace SwiftlyS2.Shared.SchemaDefinitions;

public partial interface CPlayer_WeaponServices {

  /// <summary>
  /// Drop a weapon.
  /// </summary>
  /// <param name="weapon">The weapon to drop.</param>
  public void DropWeapon(CBasePlayerWeapon weapon);

  /// <summary>
  /// Drop and remove a weapon.
  /// </summary>
  /// <param name="weapon">The weapon to remove.</param>
  public void RemoveWeapon(CBasePlayerWeapon weapon);

  /// <summary>
  /// Make player select a weapon.
  /// </summary>
  /// <param name="weapon">The weapon to select.</param>
  public void SelectWeapon(CBasePlayerWeapon weapon);

  /// <summary>
  /// Drop all weapons with the specified class.
  /// </summary>
  /// <typeparam name="T">The weapon class.</typeparam>
  public void DropWeaponByClass<T>() where T : CBasePlayerWeapon;

  /// <summary>
  /// Drop and remove all weapons with the specified class.
  /// </summary>
  /// <typeparam name="T">The weapon class.</typeparam>
  public void RemoveWeaponByClass<T>() where T : CBasePlayerWeapon;

  /// <summary>
  /// Select a weapon by class.
  /// </summary>
  /// <typeparam name="T">The weapon class.</typeparam>
  public void SelectWeaponByClass<T>() where T : CBasePlayerWeapon;
}