using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleFunctionInitializer : IParticleFunction {

  public ref int AssociatedEmitterIndex { get; }
  
}