using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_FadeAndKillForTracers : IParticleFunctionOperator {

  
  public ref float StartFadeInTime { get; }
  
  public ref float EndFadeInTime { get; }
  
  public ref float StartFadeOutTime { get; }
  
  public ref float EndFadeOutTime { get; }
  
  public ref float StartAlpha { get; }
  
  public ref float EndAlpha { get; }
}