using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeTreeChildren_t : ISchemaClass {

  public ISchemaFixedArray<ushort> Child { get; }
  
}