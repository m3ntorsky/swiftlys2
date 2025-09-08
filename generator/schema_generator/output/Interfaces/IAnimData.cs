using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimData : ISchemaClass {

  public ref CBufferString Name { get; }
  
  public ref CUtlVector AnimArray { get; }
  
  public ref CUtlVector DecoderArray { get; }
  
  public ref int MaxUniqueFrameIndex { get; }
  
  public ref CUtlVector SegmentArray { get; }
  
}