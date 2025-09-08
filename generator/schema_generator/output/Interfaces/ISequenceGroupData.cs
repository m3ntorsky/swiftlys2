using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISequenceGroupData : ISchemaClass {

  public ref CBufferString Name { get; }
  
  public ref uint Flags { get; }
  
  public ref CUtlVector<CBufferString> LocalSequenceNameArray { get; }
  
  public ref CUtlVector LocalS1SeqDescArray { get; }
  
  public ref CUtlVector LocalMultiSeqDescArray { get; }
  
  public ref CUtlVector LocalSynthAnimDescArray { get; }
  
  public ref CUtlVector LocalCmdSeqDescArray { get; }
  
  public ref CUtlVector LocalBoneMaskArray { get; }
  
  public ref CUtlVector LocalScaleSetArray { get; }
  
  public ref CUtlVector<CBufferString> LocalBoneNameArray { get; }
  
  public ref CBufferString LocalNodeName { get; }
  
  public ref CUtlVector LocalPoseParamArray { get; }
  
  public ISchemaUntypedField KeyValues { get; }
  
  public ref CUtlVector LocalIKAutoplayLockArray { get; }
  
}