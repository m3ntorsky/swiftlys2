using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_DistanceToCPInit : IParticleFunctionInitializer {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IPerParticleFloatInput InputMin { get; }
  
  public IPerParticleFloatInput InputMax { get; }
  
  public IPerParticleFloatInput OutputMin { get; }
  
  public IPerParticleFloatInput OutputMax { get; }
  
  public ref int StartCP { get; }
  
  public ref bool LOS { get; }
  
  public ISchemaFixedString CollisionGroupName { get; }
  
  public ref ParticleTraceSet_t TraceSet { get; }
  
  public IPerParticleFloatInput MaxTraceLength { get; }
  
  public ref float LOSScale { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref bool ActiveRange { get; }
  
  public ref Vector DistanceScale { get; }
  
  public ref float RemapBias { get; }
}