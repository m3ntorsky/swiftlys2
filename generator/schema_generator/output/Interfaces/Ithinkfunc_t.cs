using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Ithinkfunc_t : ISchemaClass {

  
  public ISchemaUntypedField Fn { get; }
  
  public ref CUtlStringToken Context { get; }
  
  public IGameTick_t NextThinkTick { get; }
  
  public IGameTick_t LastThinkTick { get; }
}