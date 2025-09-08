using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlayerVisibility : IBaseEntity {

  public ref float VisibilityStrength { get; }
  
  public ref float FogDistanceMultiplier { get; }
  
  public ref float FogMaxDensityMultiplier { get; }
  
  public ref float FadeTime { get; }
  
  public ref bool StartDisabled { get; }
  
  public ref bool IsEnabled { get; }
  
}