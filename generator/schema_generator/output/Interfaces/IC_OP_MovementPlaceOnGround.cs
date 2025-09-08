using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_MovementPlaceOnGround : IParticleFunctionOperator {

  public IPerParticleFloatInput Offset { get; }
  
  public ref float MaxTraceLength { get; }
  
  public ref float Tolerance { get; }
  
  public ref float TraceOffset { get; }
  
  public ref float LerpRate { get; }
  
  public ISchemaFixedString CollisionGroupName { get; }
  
  public ref ParticleTraceSet_t TraceSet { get; }
  
  public ref int RefCP1 { get; }
  
  public ref int RefCP2 { get; }
  
  public ref int LerpCP { get; }
  
  public ref ParticleTraceMissBehavior_t TraceMissBehavior { get; }
  
  public ref bool IncludeShotHull { get; }
  
  public ref bool IncludeWater { get; }
  
  public ref bool SetNormal { get; }
  
  public ref bool ScaleOffset { get; }
  
  public ref int PreserveOffsetCP { get; }
  
  public ref int IgnoreCP { get; }
  
}