using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPropDoorRotatingBreakable : IPropDoorRotating {

  
  public ref bool Breakable { get; }
  
  public ref bool IsAbleToCloseAreaPortals { get; }
  
  public ref int CurrentDamageState { get; }
  
// CUtlVector< CUtlSymbolLarge >
  public ref CUtlVector DamageStates { get; }
}