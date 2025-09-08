using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDirectPlaybackTagData : ISchemaClass {

  public ref CUtlString SequenceName { get; }
  
  public ref CUtlVector Tags { get; }
  
}