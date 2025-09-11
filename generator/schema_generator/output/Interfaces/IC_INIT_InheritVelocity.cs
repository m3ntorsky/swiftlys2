using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_InheritVelocity : IParticleFunctionInitializer {

  
  public ref int ControlPointNumber { get; }
  
  public ref float VelocityScale { get; }
}