using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqTransition : ISchemaClass {

  
  public ref float FadeInTime { get; }
  
  public ref float FadeOutTime { get; }
}