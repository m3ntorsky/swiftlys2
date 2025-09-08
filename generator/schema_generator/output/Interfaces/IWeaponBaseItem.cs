using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWeaponBaseItem : ICSWeaponBase {

  public ref bool SequenceInProgress { get; }
  
  public ref bool Redraw { get; }
  
}