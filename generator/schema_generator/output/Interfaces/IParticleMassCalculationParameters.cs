using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleMassCalculationParameters : ISchemaClass {

  public ref ParticleMassMode_t MassMode { get; }
  
  public IPerParticleFloatInput Radius { get; }
  
  public IPerParticleFloatInput NominalRadius { get; }
  
  public IPerParticleFloatInput Scale { get; }
  
}