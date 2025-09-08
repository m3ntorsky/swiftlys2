using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeSourceEdge_t : ISchemaClass {

  public ISchemaFixedArray<ushort> Node { get; }
  
}