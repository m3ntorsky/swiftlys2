using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmIKBody : ISchemaClass {

  
  public ref float Mass { get; }
  
  public ref Vector LocalMassCenter { get; }
  
  public ref Vector Radius { get; }
  
  public ref float Resistance { get; }
}