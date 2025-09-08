using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicCompare : ILogicalEntity {

  public ref float InValue { get; }
  
  public ref float CompareValue { get; }
  
  public ISchemaUntypedField OnLessThan { get; }
  
  public ISchemaUntypedField OnEqualTo { get; }
  
  public ISchemaUntypedField OnNotEqualTo { get; }
  
  public ISchemaUntypedField OnGreaterThan { get; }
  
}