using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWeaponCZ75a : ICSWeaponBaseGun {

  public ref bool MagazineRemoved { get; }
  
}