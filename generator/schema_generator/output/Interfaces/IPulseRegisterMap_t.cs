using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseRegisterMap_t : ISchemaClass {

  
  public ISchemaUntypedField Inparams { get; }
  
  public ISchemaUntypedField InparamsWhichCanBeMoved { get; }
  
  public ISchemaUntypedField Outparams { get; }
}