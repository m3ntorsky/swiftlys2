using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqS1SeqDesc : ISchemaClass {

  public ref CBufferString Name { get; }
  
  public ISeqSeqDescFlag Flags { get; }
  
  public ISeqMultiFetch Fetch { get; }
  
  public ref int LocalWeightlist { get; }
  
  public ref CUtlVector AutoLayerArray { get; }
  
  public ref CUtlVector IKLockArray { get; }
  
  public ISeqTransition Transition { get; }
  
  public ISchemaUntypedField SequenceKeys { get; }
  
  public ref CBufferString LegacyKeyValueText { get; }
  
  public ref CUtlVector ActivityArray { get; }
  
  public ref CUtlVector FootMotion { get; }
  
}