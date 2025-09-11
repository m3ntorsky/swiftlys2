using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEventClientPollInput_t : ISchemaClass {

  
  public IEngineLoopState_t LoopState { get; }
  
  public ref float RealTime { get; }
}