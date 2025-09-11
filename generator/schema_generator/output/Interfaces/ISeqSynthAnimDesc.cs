using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqSynthAnimDesc : ISchemaClass {

  
  public ref CBufferString Name { get; }
  
  public ISeqSeqDescFlag Flags { get; }
  
  public ISeqTransition Transition { get; }
  
  public ref short LocalBaseReference { get; }
  
  public ref short LocalBoneMask { get; }
  
// CUtlVector< CAnimActivity >
  public ref CUtlVector ActivityArray { get; }
}