using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_NoiseEmitter : IParticleFunctionEmitter {

  
  public ref float EmissionDuration { get; }
  
  public ref float StartTime { get; }
  
  public ref float EmissionScale { get; }
  
  public ref int ScaleControlPoint { get; }
  
  public ref int ScaleControlPointField { get; }
  
  public ref int WorldNoisePoint { get; }
  
  public ref bool AbsVal { get; }
  
  public ref bool AbsValInv { get; }
  
  public ref float Offset { get; }
  
  public ref float OutputMin { get; }
  
  public ref float OutputMax { get; }
  
  public ref float NoiseScale { get; }
  
  public ref float WorldNoiseScale { get; }
  
  public ref Vector OffsetLoc { get; }
  
  public ref float WorldTimeScale { get; }
}