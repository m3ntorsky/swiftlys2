using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPairedSequenceUpdateNode : ISequenceUpdateNodeBase {

  
  public ref CGlobalSymbol PairedSequenceRole { get; }
}