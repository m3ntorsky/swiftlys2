using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEventClientPostOutput_t : ISchemaClass {

  
  public IEngineLoopState_t LoopState { get; }
  
  public ref double RenderTime { get; }
  
  public ref float RenderFrameTime { get; }
  
  public ref float RenderFrameTimeUnbounded { get; }
  
  public ref bool RenderOnly { get; }
}