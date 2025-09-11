using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVSound : ISchemaClass {

  
  public ref int Rate { get; }
  
  public ref CVSoundFormat_t Format { get; }
  
  public ref uint Channels { get; }
  
  public ref int LoopStart { get; }
  
  public ref uint SampleCount { get; }
  
  public ref float Duration { get; }
  
// CUtlVector< CAudioSentence >
  public ref CUtlVector Sentences { get; }
  
  public ref uint StreamingSize { get; }
  
  public ref CUtlVector<int> SeekTable { get; }
  
  public ref int LoopEnd { get; }
  
  public ref CUtlBinaryBlock EncodedHeader { get; }
}