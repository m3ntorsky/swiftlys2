using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_PlayEndCapWhenFinished : IParticleFunctionPreEmission {

  
  public ref bool FireOnEmissionEnd { get; }
  
  public ref bool IncludeChildren { get; }
}