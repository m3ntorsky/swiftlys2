using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ShapeMatchingConstraint : IParticleFunctionConstraint {

  
  public ref float ShapeRestorationTime { get; }
}