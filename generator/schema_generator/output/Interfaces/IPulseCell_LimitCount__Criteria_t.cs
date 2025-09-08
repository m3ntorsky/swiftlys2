using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_LimitCount__Criteria_t : ISchemaClass {

  public ref bool LimitCountPasses { get; }
  
}