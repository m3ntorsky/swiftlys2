using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICovMatrix3 : ISchemaClass {

  
  public ref Vector Diag { get; }
  
  public ref float XY { get; }
  
  public ref float XZ { get; }
  
  public ref float YZ { get; }
}