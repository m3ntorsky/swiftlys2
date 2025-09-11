using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerActiveWeaponDetect : IBaseTrigger {

  
  public IEntityIOOutput OnTouchedActiveWeapon { get; }
  
  public ref CUtlSymbolLarge WeaponClassName { get; }
}