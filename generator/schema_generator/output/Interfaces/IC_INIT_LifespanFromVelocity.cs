using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_LifespanFromVelocity : IParticleFunctionInitializer {

  
  public ref Vector ComponentScale { get; }
  
  public ref float TraceOffset { get; }
  
  public ref float MaxTraceLength { get; }
  
  public ref float TraceTolerance { get; }
  
  public ref int MaxPlanes { get; }
  
  public ISchemaFixedString CollisionGroupName { get; }
  
  public ref ParticleTraceSet_t TraceSet { get; }
  
  public ref bool IncludeWater { get; }
}