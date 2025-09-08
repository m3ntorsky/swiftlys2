using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeNodeIntegrator_t : ISchemaClass {

  public ref float PointDamping { get; }
  
  public ref float AnimationForceAttraction { get; }
  
  public ref float AnimationVertexAttraction { get; }
  
  public ref float Gravity { get; }
  
}