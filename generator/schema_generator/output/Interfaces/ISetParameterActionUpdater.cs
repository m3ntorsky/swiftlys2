using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISetParameterActionUpdater : IAnimActionUpdater {

  public IAnimParamHandle Param { get; }
  
  public ISchemaUntypedField Value { get; }
  
}