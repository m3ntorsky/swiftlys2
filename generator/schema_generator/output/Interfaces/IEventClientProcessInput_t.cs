using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEventClientProcessInput_t : ISchemaClass {

  
  public IEngineLoopState_t LoopState { get; }
  
  public ref float RealTime { get; }
  
  public ref float TickInterval { get; }
  
  public ref double TickStartTime { get; }
}