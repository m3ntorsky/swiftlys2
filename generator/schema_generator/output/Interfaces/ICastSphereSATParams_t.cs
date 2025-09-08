using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICastSphereSATParams_t : ISchemaClass {

  public ref Vector RayStart { get; }
  
  public ref Vector RayDelta { get; }
  
  public ref float Radius { get; }
  
  public ref float MaxFraction { get; }
  
  public ref float Scale { get; }
  
  public IRnHull_t Hull { get; }
  
}