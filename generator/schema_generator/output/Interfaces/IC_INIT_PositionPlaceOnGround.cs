using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_PositionPlaceOnGround : IParticleFunctionInitializer {

  public IPerParticleFloatInput Offset { get; }
  
  public IPerParticleFloatInput MaxTraceLength { get; }
  
  public ISchemaFixedString CollisionGroupName { get; }
  
  public ref ParticleTraceSet_t TraceSet { get; }
  
  public ref ParticleTraceMissBehavior_t TraceMissBehavior { get; }
  
  public ref bool IncludeWater { get; }
  
  public ref bool SetNormal { get; }
  
  public IParticleAttributeIndex_t Attribute { get; }
  
  public ref bool SetPXYZOnly { get; }
  
  public ref bool TraceAlongNormal { get; }
  
  public IParticleAttributeIndex_t TraceDirectionAttribute { get; }
  
  public ref bool OffsetonColOnly { get; }
  
  public ref float OffsetByRadiusFactor { get; }
  
  public ref int PreserveOffsetCP { get; }
  
  public ref int IgnoreCP { get; }
  
}