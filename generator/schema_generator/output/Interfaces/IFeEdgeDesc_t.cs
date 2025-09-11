using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeEdgeDesc_t : ISchemaClass {

  
  public ISchemaFixedArray<ushort> Edge { get; }
  
  public ISchemaFixedArray<ushort[2]> Side { get; }
  
  public ISchemaFixedArray<ushort> VirtElem { get; }
}