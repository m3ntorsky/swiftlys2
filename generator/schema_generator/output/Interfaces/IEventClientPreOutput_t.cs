using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEventClientPreOutput_t : ISchemaClass {

  public IEngineLoopState_t LoopState { get; }
  
  public ref double RenderTime { get; }
  
  public ref double RenderFrameTime { get; }
  
  public ref double RenderFrameTimeUnbounded { get; }
  
  public ref float RealTime { get; }
  
  public ref bool RenderOnly { get; }
  
}