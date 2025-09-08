using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleFunctionRenderer : IParticleFunction {

  public IParticleVisibilityInputs VisibilityInputs { get; }
  
  public ref bool CannotBeRefracted { get; }
  
  public ref bool SkipRenderingOnMobile { get; }
  
}