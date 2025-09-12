using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerVolume : IBaseModelEntity {

  
  public ISchemaUntypedField FilterName { get; }
  
  public ref CHandle<CBaseFilter> Filter { get; }
}