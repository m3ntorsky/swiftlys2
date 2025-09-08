using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISceneViewId_t : ISchemaClass {

  public ref ulong ViewId { get; }
  
  public ref ulong FrameCount { get; }
  
}