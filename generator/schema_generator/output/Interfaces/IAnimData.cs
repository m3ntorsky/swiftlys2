using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimData : ISchemaClass {

  
  public ref CBufferString Name { get; }
  
// CUtlVector< CAnimDesc >
  public ref CUtlVector AnimArray { get; }
  
// CUtlVector< CAnimDecoder >
  public ref CUtlVector DecoderArray { get; }
  
  public ref int MaxUniqueFrameIndex { get; }
  
// CUtlVector< CAnimFrameSegment >
  public ref CUtlVector SegmentArray { get; }
}