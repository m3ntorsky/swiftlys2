using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISpotlightEnd : IBaseModelEntity {

  
  public ref float LightScale { get; }
  
  public ref float Radius { get; }
  
  public ref Vector SpotlightDir { get; }
  
  public ref Vector SpotlightOrg { get; }
}