using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INetworkVarChainer : ISchemaClass {

  
  public IChangeAccessorFieldPathIndex_t PathIndex { get; }
}