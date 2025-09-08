using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleFunctionPreEmission : IParticleFunctionOperator {

  public ref bool RunOnce { get; }
  
}