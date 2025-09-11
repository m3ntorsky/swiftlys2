using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStateActionUpdater : ISchemaClass {

  
  public ISchemaUntypedField Action { get; }
  
  public ref StateActionBehavior Behavior { get; }
}