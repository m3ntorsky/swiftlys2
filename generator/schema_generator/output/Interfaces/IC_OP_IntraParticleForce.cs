using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_IntraParticleForce : IParticleFunctionForce {

  
  public ref float AttractionMinDistance { get; }
  
  public ref float AttractionMaxDistance { get; }
  
  public ref float AttractionMaxStrength { get; }
  
  public ref float RepulsionMinDistance { get; }
  
  public ref float RepulsionMaxDistance { get; }
  
  public ref float RepulsionMaxStrength { get; }
  
  public ref bool UseAABB { get; }
}