using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysSurfacePropertiesAudio : ISchemaClass {

  
  public ref float Reflectivity { get; }
  
  public ref float HardnessFactor { get; }
  
  public ref float RoughnessFactor { get; }
  
  public ref float RoughThreshold { get; }
  
  public ref float HardThreshold { get; }
  
  public ref float HardVelocityThreshold { get; }
  
  public ref float StaticImpactVolume { get; }
  
  public ref float OcclusionFactor { get; }
}