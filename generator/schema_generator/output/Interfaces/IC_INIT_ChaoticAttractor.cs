using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_ChaoticAttractor : IParticleFunctionInitializer {

  
  public ref float AParm { get; }
  
  public ref float BParm { get; }
  
  public ref float CParm { get; }
  
  public ref float DParm { get; }
  
  public ref float Scale { get; }
  
  public ref float SpeedMin { get; }
  
  public ref float SpeedMax { get; }
  
  public ref int BaseCP { get; }
  
  public ref bool UniformSpeed { get; }
}