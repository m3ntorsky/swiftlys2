using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundOpvarSetPointBase : IBaseEntity {

  public ref bool Disabled { get; }
  
  public ref CEntityHandle Source { get; }
  
  public ref CUtlSymbolLarge SourceEntityName { get; }
  
  public ref Vector LastPosition { get; }
  
  public ref CUtlSymbolLarge StackName { get; }
  
  public ref CUtlSymbolLarge OperatorName { get; }
  
  public ref CUtlSymbolLarge OpvarName { get; }
  
  public ref int OpvarIndex { get; }
  
  public ref bool UseAutoCompare { get; }
  
}