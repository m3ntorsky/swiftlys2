using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeAxialEdgeBend_t : ISchemaClass {

  
  public ref float Te { get; }
  
  public ref float Tv { get; }
  
  public ref float Dist { get; }
  
  public ISchemaFixedArray<float> Weight { get; }
  
  public ISchemaFixedArray<ushort> Node { get; }
}