using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetCPOrientationToGroundNormal : IParticleFunctionOperator {

  public ref float InterpRate { get; }
  
  public ref float MaxTraceLength { get; }
  
  public ref float Tolerance { get; }
  
  public ref float TraceOffset { get; }
  
  public ISchemaFixedString CollisionGroupName { get; }
  
  public ref ParticleTraceSet_t TraceSet { get; }
  
  public ref int InputCP { get; }
  
  public ref int OutputCP { get; }
  
  public ref bool IncludeWater { get; }
  
}