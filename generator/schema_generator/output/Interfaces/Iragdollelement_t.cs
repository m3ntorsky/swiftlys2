using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Iragdollelement_t : ISchemaClass {

  
  public ref Vector OriginParentSpace { get; }
  
  public ref int ParentIndex { get; }
  
  public ref float Radius { get; }
  
  public ref int Height { get; }
}