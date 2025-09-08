using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleFunctionEmitter : IParticleFunction {

  public ref int EmitterIndex { get; }
  
}