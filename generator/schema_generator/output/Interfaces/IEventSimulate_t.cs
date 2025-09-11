using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEventSimulate_t : ISchemaClass {

  
  public IEngineLoopState_t LoopState { get; }
  
  public ref bool FirstTick { get; }
  
  public ref bool LastTick { get; }
}