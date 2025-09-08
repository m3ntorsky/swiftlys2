using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPropDoorRotatingBreakable : IPropDoorRotating {

  public ref bool Breakable { get; }
  
  public ref bool IsAbleToCloseAreaPortals { get; }
  
  public ref int CurrentDamageState { get; }
  
  public ref CUtlVector<CUtlSymbolLarge> DamageStates { get; }
  
}