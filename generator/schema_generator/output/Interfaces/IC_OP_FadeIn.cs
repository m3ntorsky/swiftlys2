using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_FadeIn : IParticleFunctionOperator {

  
  public ref float FadeInTimeMin { get; }
  
  public ref float FadeInTimeMax { get; }
  
  public ref float FadeInTimeExp { get; }
  
  public ref bool Proportional { get; }
}