using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Ilocksound_t : ISchemaClass {

  public ref CUtlSymbolLarge LockedSound { get; }
  
  public ref CUtlSymbolLarge UnlockedSound { get; }
  
  public IGameTime_t FlwaitSound { get; }
  
}