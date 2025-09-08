using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeSimdQuad_t : ISchemaClass {

  public ISchemaFixedArray<ushort[4]> Node { get; }
  
  public ref fltx4 F4Slack { get; }
  
  public ISchemaFixedArray<FourVectors> Shape { get; }
  
  public ISchemaFixedArray<fltx4> F4Weights { get; }
  
}