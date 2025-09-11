using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStanceInfo_t : ISchemaClass {

  
  public ref Vector Position { get; }
  
  public ref float Direction { get; }
}