using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointToImpactPoint : IParticleFunctionPreEmission {

  
  public ref int CPOut { get; }
  
  public ref int CPIn { get; }
  
  public ref float UpdateRate { get; }
  
  public IParticleCollectionFloatInput TraceLength { get; }
  
  public ref float StartOffset { get; }
  
  public ref float Offset { get; }
  
  public ref Vector TraceDir { get; }
  
  public ISchemaFixedString CollisionGroupName { get; }
  
  public ref ParticleTraceSet_t TraceSet { get; }
  
  public ref bool SetToEndpoint { get; }
  
  public ref bool TraceToClosestSurface { get; }
  
  public ref bool IncludeWater { get; }
}