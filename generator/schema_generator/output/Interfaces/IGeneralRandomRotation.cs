using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGeneralRandomRotation : IParticleFunctionInitializer {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float Degrees { get; }
  
  public ref float DegreesMin { get; }
  
  public ref float DegreesMax { get; }
  
  public ref float RotationRandExponent { get; }
  
  public ref bool RandomlyFlipDirection { get; }
  
}