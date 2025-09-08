using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_FadeOut : IParticleFunctionOperator {

  public ref float FadeOutTimeMin { get; }
  
  public ref float FadeOutTimeMax { get; }
  
  public ref float FadeOutTimeExp { get; }
  
  public ref float FadeBias { get; }
  
  public ref bool Proportional { get; }
  
  public ref bool EaseInAndOut { get; }
  
}