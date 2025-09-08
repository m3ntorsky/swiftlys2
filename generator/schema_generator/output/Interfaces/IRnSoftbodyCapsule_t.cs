using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRnSoftbodyCapsule_t : ISchemaClass {

  public ISchemaFixedArray<Vector> Center { get; }
  
  public ref float Radius { get; }
  
  public ISchemaFixedArray<ushort> Particle { get; }
  
}