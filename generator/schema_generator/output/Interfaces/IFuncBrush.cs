using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncBrush : IBaseModelEntity {

  
  public ref BrushSolidities_e Solidity { get; }
  
  public ref int Disabled { get; }
  
  public ref bool SolidBsp { get; }
  
  public ref CUtlSymbolLarge ExcludedClass { get; }
  
  public ref bool InvertExclusion { get; }
  
  public ref bool ScriptedMovement { get; }
}