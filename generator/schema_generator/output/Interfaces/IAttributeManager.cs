using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAttributeManager : ISchemaClass {

  
  public ref CUtlVector<CHandle<CBaseEntity>> Providers { get; }
  
  public ref int ReapplyProvisionParity { get; }
  
  public ref CHandle<CBaseEntity> Outer { get; }
  
  public ref bool PreventLoopback { get; }
  
  public ref attributeprovidertypes_t ProviderType { get; }
  
// CUtlVector< CAttributeManager::cached_attribute_float_t >
  public ref CUtlVector CachedResults { get; }
}