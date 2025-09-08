using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundOpvarSetEntity : IBaseEntity {

  public ref CUtlSymbolLarge StackName { get; }
  
  public ref CUtlSymbolLarge OperatorName { get; }
  
  public ref CUtlSymbolLarge OpvarName { get; }
  
  public ref int OpvarType { get; }
  
  public ref int OpvarIndex { get; }
  
  public ref float OpvarValue { get; }
  
  public ref CUtlSymbolLarge OpvarValueString { get; }
  
  public ref bool SetOnSpawn { get; }
  
}