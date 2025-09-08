using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_InitialRepulsionVelocity : IParticleFunctionInitializer {

  public ISchemaFixedString CollisionGroupName { get; }
  
  public ref ParticleTraceSet_t TraceSet { get; }
  
  public ref Vector OutputMin { get; }
  
  public ref Vector OutputMax { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref bool PerParticle { get; }
  
  public ref bool Translate { get; }
  
  public ref bool Proportional { get; }
  
  public ref float TraceLength { get; }
  
  public ref bool PerParticleTR { get; }
  
  public ref bool Inherit { get; }
  
  public ref int ChildCP { get; }
  
  public ref int ChildGroupID { get; }
  
}