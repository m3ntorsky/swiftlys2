using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILightEntity : IBaseModelEntity {

  
  public ILightComponent CLightComponent { get; }
}