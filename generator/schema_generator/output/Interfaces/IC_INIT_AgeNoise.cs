using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_AgeNoise : IParticleFunctionInitializer {

  
  public ref bool AbsVal { get; }
  
  public ref bool AbsValInv { get; }
  
  public ref float Offset { get; }
  
  public ref float AgeMin { get; }
  
  public ref float AgeMax { get; }
  
  public ref float NoiseScale { get; }
  
  public ref float NoiseScaleLoc { get; }
  
  public ref Vector OffsetLoc { get; }
}