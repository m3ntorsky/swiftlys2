using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAudioEmphasisSample : ISchemaClass {

  public ref float Time { get; }
  
  public ref float Value { get; }
  
}