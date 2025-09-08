using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRnSoftbodySpring_t : ISchemaClass {

  public ISchemaFixedArray<ushort> Particle { get; }
  
  public ref float Length { get; }
  
}