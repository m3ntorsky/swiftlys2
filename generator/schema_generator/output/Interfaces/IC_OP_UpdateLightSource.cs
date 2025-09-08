using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_UpdateLightSource : IParticleFunctionOperator {

  public ref Color ColorTint { get; }
  
  public ref float BrightnessScale { get; }
  
  public ref float RadiusScale { get; }
  
  public ref float MinimumLightingRadius { get; }
  
  public ref float MaximumLightingRadius { get; }
  
  public ref float PositionDampingConstant { get; }
  
}