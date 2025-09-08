using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAttributeManager : ISchemaClass {

  public ref CUtlVector<CHandle<CBaseEntity>> Providers { get; }
  
  public ref int ReapplyProvisionParity { get; }
  
  public ref CHandle<CBaseEntity> Outer { get; }
  
  public ref bool PreventLoopback { get; }
  
  public ref attributeprovidertypes_t ProviderType { get; }
  
  public ref CUtlVector CachedResults { get; }
  
}