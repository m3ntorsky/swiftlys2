using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Isndopvarlatchdata_t : ISchemaClass {

  
  public ISchemaUntypedField Stack { get; }
  
  public ISchemaUntypedField Operator { get; }
  
  public ISchemaUntypedField Opvar { get; }
  
  public ref float Val { get; }
  
  public ref Vector Pos { get; }
}