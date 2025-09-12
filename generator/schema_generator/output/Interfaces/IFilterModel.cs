using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFilterModel : IBaseFilter {

  
  public ISchemaUntypedField FilterModel { get; }
}