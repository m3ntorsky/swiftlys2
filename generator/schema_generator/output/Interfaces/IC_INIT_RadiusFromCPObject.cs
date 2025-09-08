using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RadiusFromCPObject : IParticleFunctionInitializer {

  public ref int ControlPoint { get; }
  
}