using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITonemapTrigger : IBaseTrigger {

  
  public ISchemaUntypedField TonemapControllerName { get; }
  
  public ref CHandle<IEntityInstance> TonemapController { get; }
}