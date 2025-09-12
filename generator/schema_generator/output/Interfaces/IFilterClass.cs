using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFilterClass : IBaseFilter {

  
  public ISchemaUntypedField FilterClass { get; }
}