using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeSimdAnimStrayRadius_t : ISchemaClass {

  
  public ISchemaFixedArray<ushort[4]> Node { get; }
  
  public ref fltx4 MaxDist { get; }
  
  public ref fltx4 RelaxationFactor { get; }
}