using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMathColorBlend : ILogicalEntity {

  
  public ref float InMin { get; }
  
  public ref float InMax { get; }
  
  public ref Color OutColor1 { get; }
  
  public ref Color OutColor2 { get; }
  
  public ISchemaUntypedField OutValue { get; }
}