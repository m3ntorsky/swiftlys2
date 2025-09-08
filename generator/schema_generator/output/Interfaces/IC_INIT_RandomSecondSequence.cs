using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomSecondSequence : IParticleFunctionInitializer {

  public ref int SequenceMin { get; }
  
  public ref int SequenceMax { get; }
  
}