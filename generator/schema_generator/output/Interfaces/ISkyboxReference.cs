using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISkyboxReference : IBaseEntity {

  
  public ref WorldGroupId_t WorldGroupId { get; }
  
  public ref CHandle<CSkyCamera> SkyCamera { get; }
}