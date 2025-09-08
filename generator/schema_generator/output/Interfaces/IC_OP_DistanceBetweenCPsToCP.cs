using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_DistanceBetweenCPsToCP : IParticleFunctionPreEmission {

  public ref int StartCP { get; }
  
  public ref int EndCP { get; }
  
  public ref int OutputCP { get; }
  
  public ref int OutputCPField { get; }
  
  public ref bool SetOnce { get; }
  
  public ref float InputMin { get; }
  
  public ref float InputMax { get; }
  
  public ref float OutputMin { get; }
  
  public ref float OutputMax { get; }
  
  public ref float MaxTraceLength { get; }
  
  public ref float LOSScale { get; }
  
  public ref bool LOS { get; }
  
  public ISchemaFixedString CollisionGroupName { get; }
  
  public ref ParticleTraceSet_t TraceSet { get; }
  
  public ref ParticleParentSetMode_t SetParent { get; }
  
}