using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEventClientOutput_t : ISchemaClass {

  
  public IEngineLoopState_t LoopState { get; }
  
  public ref float RenderTime { get; }
  
  public ref float RealTime { get; }
  
  public ref float RenderFrameTimeUnbounded { get; }
  
  public ref bool RenderOnly { get; }
}