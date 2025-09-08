using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundStackSave : ILogicalEntity {

  public ref CUtlSymbolLarge StackName { get; }
  
}