using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Value_Gradient : IPulseCell_BaseValue {

  public ISchemaUntypedField Gradient { get; }
  
}