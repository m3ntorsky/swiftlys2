using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysSurfacePropertiesPhysics : ISchemaClass {

  public ref float Friction { get; }
  
  public ref float Elasticity { get; }
  
  public ref float Density { get; }
  
  public ref float Thickness { get; }
  
  public ref float SoftContactFrequency { get; }
  
  public ref float SoftContactDampingRatio { get; }
  
}