using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IConstantForceController : ISchemaClass {

  
  public ref Vector Linear { get; }
  
  public ISchemaUntypedField Angular { get; }
  
  public ref Vector LinearSave { get; }
  
  public ISchemaUntypedField AngularSave { get; }
}