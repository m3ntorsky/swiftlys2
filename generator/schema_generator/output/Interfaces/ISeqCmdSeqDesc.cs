using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqCmdSeqDesc : ISchemaClass {

  
  public ref CBufferString Name { get; }
  
  public ISeqSeqDescFlag Flags { get; }
  
  public ISeqTransition Transition { get; }
  
  public ref short FrameRangeSequence { get; }
  
  public ref short FrameCount { get; }
  
  public ref float FPS { get; }
  
  public ref short SubCycles { get; }
  
  public ref short NumLocalResults { get; }
  
// CUtlVector< CSeqCmdLayer >
  public ref CUtlVector CmdLayerArray { get; }
  
// CUtlVector< CAnimEventDefinition >
  public ref CUtlVector EventArray { get; }
  
// CUtlVector< CAnimActivity >
  public ref CUtlVector ActivityArray { get; }
  
// CUtlVector< CSeqPoseSetting >
  public ref CUtlVector PoseSettingArray { get; }
}