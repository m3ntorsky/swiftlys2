using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimGraphDebugReplay : ISchemaClass {

  
  public ref CUtlString AnimGraphFileName { get; }
  
// CUtlVector< CSmartPtr< CAnimReplayFrame > >
  public ref CUtlVector FrameList { get; }
  
  public ref int StartIndex { get; }
  
  public ref int WriteIndex { get; }
  
  public ref int FrameCount { get; }
}