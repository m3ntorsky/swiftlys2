using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFourCovMatrices3 : ISchemaClass {

  
  public ref FourVectors Diag { get; }
  
  public ref fltx4 XY { get; }
  
  public ref fltx4 XZ { get; }
  
  public ref fltx4 YZ { get; }
}