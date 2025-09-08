using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICS2ChickenGraphController : IAnimGraphControllerBase {

  public ISchemaUntypedField Action { get; }
  
  public ISchemaUntypedField ActionSubtype { get; }
  
  public ISchemaUntypedField ActionReset { get; }
  
  public ISchemaUntypedField IdleVariation { get; }
  
  public ISchemaUntypedField RunVariation { get; }
  
  public ISchemaUntypedField PanicVariation { get; }
  
  public ISchemaUntypedField SquatVariation { get; }
  
  public ISchemaUntypedField InWater { get; }
  
  public ref bool HasActionCompletedEvent { get; }
  
  public ref bool WaitingForCompletedEvent { get; }
  
}