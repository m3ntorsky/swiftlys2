using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvDetailController : IBaseEntity {

  public ref float FadeStartDist { get; }
  
  public ref float FadeEndDist { get; }
  
}