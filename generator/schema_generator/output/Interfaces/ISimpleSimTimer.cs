using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISimpleSimTimer : ISchemaClass {

  
  public IGameTime_t Next { get; }
  
  public ref uint WorldGroupId { get; }
}