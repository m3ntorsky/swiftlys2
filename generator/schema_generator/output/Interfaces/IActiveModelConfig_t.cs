using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IActiveModelConfig_t : ISchemaClass {

  
  public IModelConfigHandle_t Handle { get; }
  
  public ISchemaUntypedField Name { get; }
  
  public ref CUtlVector<CHandle<CBaseModelEntity>> AssociatedEntities { get; }
  
// CNetworkUtlVectorBase< CUtlSymbolLarge >
  public ref CUtlVector AssociatedEntityNames { get; }
}