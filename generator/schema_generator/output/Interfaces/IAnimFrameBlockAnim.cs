using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimFrameBlockAnim : ISchemaClass {

  
  public ref int StartFrame { get; }
  
  public ref int EndFrame { get; }
  
  public ref CUtlVector<int> SegmentIndexArray { get; }
}