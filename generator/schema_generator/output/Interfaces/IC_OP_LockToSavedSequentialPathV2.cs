using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LockToSavedSequentialPathV2 : IParticleFunctionOperator {

  public ref float FadeStart { get; }
  
  public ref float FadeEnd { get; }
  
  public ref bool CPPairs { get; }
  
  public IPathParameters PathParams { get; }
  
}