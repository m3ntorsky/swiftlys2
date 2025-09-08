using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEconItemAttribute : ISchemaClass {

  public ref ushort AttributeDefinitionIndex { get; }
  
  public ref float Value { get; }
  
  public ref float InitialValue { get; }
  
  public ref int RefundableCurrency { get; }
  
  public ref bool SetBonus { get; }
  
}