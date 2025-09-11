using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_SequenceFromCP : IParticleFunctionInitializer {

  
  public ref bool KillUnused { get; }
  
  public ref bool RadiusScale { get; }
  
  public ref int CP { get; }
  
  public ref Vector Offset { get; }
}