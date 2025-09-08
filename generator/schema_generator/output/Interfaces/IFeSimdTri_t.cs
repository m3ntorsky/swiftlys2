using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeSimdTri_t : ISchemaClass {

  public ISchemaFixedArray<uint[4]> Node { get; }
  
  public ref fltx4 W1 { get; }
  
  public ref fltx4 W2 { get; }
  
  public ref fltx4 V1x { get; }
  
  public ref FourVectors2D V2 { get; }
  
}