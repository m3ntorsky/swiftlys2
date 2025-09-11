using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvWindVolume : IBaseEntity {

  
  public ref bool Active { get; }
  
  public ref Vector BoxMins { get; }
  
  public ref Vector BoxMaxs { get; }
  
  public ref bool StartDisabled { get; }
  
  public ref int Shape { get; }
  
  public ref float WindSpeedMultiplier { get; }
  
  public ref float WindTurbulenceMultiplier { get; }
  
  public ref float WindSpeedVariationMultiplier { get; }
  
  public ref float WindDirectionVariationMultiplier { get; }
}