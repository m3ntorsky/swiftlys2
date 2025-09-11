using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimEncodedFrames : ISchemaClass {

  
  public ref CBufferString FileName { get; }
  
  public ref int Frames { get; }
  
  public ref int FramesPerBlock { get; }
  
// CUtlVector< CAnimFrameBlockAnim >
  public ref CUtlVector FrameblockArray { get; }
  
  public IAnimEncodeDifference UsageDifferences { get; }
}