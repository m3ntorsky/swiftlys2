using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvEntityIgniter : IBaseEntity {

  public ref float Lifetime { get; }
  
}