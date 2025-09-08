using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvSplash : IPointEntity {

  public ref float Scale { get; }
  
}