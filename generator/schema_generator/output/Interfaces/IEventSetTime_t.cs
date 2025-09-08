using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEventSetTime_t : ISchemaClass {

  public IEngineLoopState_t LoopState { get; }
  
  public ref int ClientOutputFrames { get; }
  
  public ref double RealTime { get; }
  
  public ref double RenderTime { get; }
  
  public ref double RenderFrameTime { get; }
  
  public ref double RenderFrameTimeUnbounded { get; }
  
  public ref double RenderFrameTimeUnscaled { get; }
  
  public ref double TickRemainder { get; }
  
}