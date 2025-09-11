using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEngineLoopState_t : ISchemaClass {

  
  public ref int PlatWindowWidth { get; }
  
  public ref int PlatWindowHeight { get; }
  
  public ref int RenderWidth { get; }
  
  public ref int RenderHeight { get; }
}